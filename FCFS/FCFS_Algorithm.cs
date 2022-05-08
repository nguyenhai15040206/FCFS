using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    public class FCFS_Algorithm
    {
        //inputs
        public int numProcess; // số lượng tiến trình
        public int[] cpuBrustTime; 
        public int[] arrivalTime;
        public int[] priority; // độ ưu tiên


        // outputs
        public int[] waitingTime;
        public int[] turnaroundTime;
        public int[] start;
        public int[] end;
        public int[] proc;
        public float avg_waiting;
        public float avg_turnaround;
        public int lastValid;


        //
        public FCFS_Algorithm(int[]a, int[] b, int[] c, int num)
        {
            numProcess = num;
            arrivalTime = a;
            cpuBrustTime = b;
            priority = c;
            waitingTime = new int[2000];
            turnaroundTime = new int[2000];
            start = new int[2000];
            end = new int[2000];
            proc = new int[2000];
            for(int i=0; i< 2000; i++)
            {
                waitingTime[i] = 0;
                turnaroundTime[i] = 0;
                start[i] = 0;
                end[i] = 0;
                proc[i] = -1;
            }
        }

        //
        public void ClearData()
        {
            arrivalTime = new int[0];
            cpuBrustTime = new int[0];
            priority = new int[0];
            for (int i = 0; i < 2000; i++)
            {
                waitingTime[i] = 0;
                turnaroundTime[i] = 0;
                start[i] = 0;
                end[i] = 0;
                proc[i] = -1;
            }
        }


        public void ComputeFCFS()
        {
            List<Process> listProcess = new List<Process>(numProcess);
            for(int i=0; i< numProcess; i++)
            {
                listProcess.Add(new Process(i, arrivalTime[i], cpuBrustTime[i]));
            }

            Process.Sort(listProcess);

            int cnt = 0, idx = 0;

            for(int i=0; i< numProcess; i++)
            {
                if(listProcess[i].arrival<= cnt)
                {
                    start[i] = cnt;
                    end[i] = cnt + listProcess[i].brustTime;
                    proc[i] = listProcess[i].index;
                    waitingTime[i] = start[idx] - listProcess[i].arrival;
                    turnaroundTime[i] = end[idx] - listProcess[i].arrival;

                    cnt += listProcess[i].brustTime;
                    idx++;
                }
                else
                {
                    start[idx] = cnt;
                    end[idx] = listProcess[i].arrival;
                    proc[idx] = -1;
                    cnt = listProcess[i].arrival;
                    idx++;
                    start[idx] = cnt;
                    end[idx] = cnt + listProcess[i].brustTime;
                    proc[idx] = listProcess[i].index;
                    waitingTime[i] = start[idx] - listProcess[i].arrival;
                    turnaroundTime[i] = end[idx] - listProcess[i].arrival;
                    cnt += listProcess[i].brustTime;
                    idx++;
                }
            }

            for(int i=0; i< numProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= numProcess;

            for (int i = 0; i < numProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= numProcess;
            lastValid = idx;
        }
        
        // không đọc quyền
        public void ComputerSJF_N()
        {
            List<Process> listProcess = new List<Process>(numProcess);


            for (int i = 0; i < numProcess; i++)
            {
                listProcess.Add(new Process(i, arrivalTime[i], cpuBrustTime[i]));
            }
            Process.Sort(listProcess);
            int cnt = 0;
            int idx = 0;

            while (listProcess.Count != 0)
            {
                List<Process> ready = new List<Process>(numProcess);
                if (listProcess.First().arrival > cnt)
                {
                    start[idx] = cnt;
                    end[idx] = listProcess.First().arrival;
                    proc[idx] = -1;
                    idx++;
                    cnt = listProcess.First().arrival;
                }
                for (int i = 0, j = 0; j < listProcess.Count; i++)
                {
                    if (listProcess[j].arrival <= cnt)
                    {
                        ready.Add(listProcess[j]);
                        listProcess.RemoveAt(j);
                    }
                    else j++;
                }
                while (ready.Count != 0)
                {
                    Process.Sort3(ready);
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    start[idx] = cnt;
                    end[idx] = cnt + readyProcess.brustTime;
                    proc[idx] = readyProcess.index;
                    waitingTime[idx] = start[idx] - readyProcess.arrival;
                    turnaroundTime[idx] = end[idx] - readyProcess.arrival;
                    idx++;
                    cnt += readyProcess.brustTime;
                    for (int i = 0, j = 0; i < listProcess.Count; i++)
                    {
                        if (listProcess[j].arrival <= cnt)
                        {
                            ready.Add(listProcess[j]);
                            listProcess.RemoveAt(j);
                        }
                        else j++;
                    }
                }

            }
            for (int i = 0; i < numProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= numProcess;
            for (int i = 0; i < numProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= numProcess;
            lastValid = idx;
        }


        public void ComputerSJF_P()
        {
            List<Process> p = new List<Process>(numProcess);
            for (int i = 0; i < numProcess; i++)
            {
                p.Add(new Process(i, arrivalTime[i], cpuBrustTime[i], priority[i]));
            }
            Process.Sort(p);
            int cnt = 0;
            int idx = -1;
            if (p[0].arrival > cnt)
            { idx = 0; }
            while (p.Count != 0)
            {
                List<Process> ready = new List<Process>(numProcess);
                if (p.First().arrival > cnt)
                {
                    start[idx] = cnt;
                    end[idx] = p.First().arrival;
                    proc[idx] = -1;
                    idx++;
                    cnt = p.First().arrival;
                }
                for (int i = 0, j = 0; j < p.Count; i++)
                {
                    if (p[j].arrival <= cnt)
                    {
                        ready.Add(p[j]);
                        p.RemoveAt(j);
                    }
                    else j++;
                }
                int cur = -2;
                while (ready.Count != 0)
                {
                    Process.Sort3(ready);
                    Process readyProcess = ready[0];
                    ready.RemoveAt(0);
                    if (cur != readyProcess.index)
                    {
                        idx++;
                        start[idx] = cnt;
                        proc[idx] = readyProcess.index;

                        readyProcess.brustTime--;
                        cur = readyProcess.index;
                        cnt++;
                        end[idx] = cnt;
                        if (readyProcess.brustTime > 0)
                        {
                            ready.Add(readyProcess);
                        }
                        else
                        {


                        }
                        for (int i = 0, j = 0; j < p.Count; i++)
                        {
                            if (p[j].arrival <= cnt)
                            {
                                ready.Add(p[j]);
                                p.RemoveAt(j);
                            }
                            else j++;
                        }
                    }
                    else
                    {
                        readyProcess.brustTime--;
                        cur = readyProcess.index;
                        cnt++;
                        end[idx] = cnt;
                        if (readyProcess.brustTime > 0)
                        {
                            ready.Add(readyProcess);
                        }
                        else
                        {


                        }
                        for (int i = 0, j = 0; j < p.Count; i++)
                        {
                            if (p[j].arrival <= cnt)
                            {
                                ready.Add(p[j]);
                                p.RemoveAt(j);
                            }
                            else j++;
                        }
                    }
                }
            }
            for (int j = 0; j < numProcess; j++)
            {
                bool k = false; int wait = 0;
                for (int i = 0; i <= idx; i++)
                {
                    if (proc[i] == j)
                    {
                        if (!k)
                        {
                            waitingTime[j] = start[i] - arrivalTime[j]; k = true;
                            wait = end[i];

                        }
                        else if (k)
                        {
                            waitingTime[j] += start[i] - wait;
                            wait = end[i];
                        }
                        turnaroundTime[j] = wait - arrivalTime[j];
                    }
                }
            }
            for (int i = 0; i < numProcess; i++)
            {
                if (waitingTime[i] == 0) continue;
                else
                {
                    avg_waiting += waitingTime[i];
                }
            }
            avg_waiting /= numProcess;
            for (int i = 0; i < numProcess; i++)
            {
                if (turnaroundTime[i] == 0) continue;
                else
                {
                    avg_turnaround += turnaroundTime[i];
                }
            }
            avg_turnaround /= numProcess;
            lastValid = idx + 1;
        }
    }
}
