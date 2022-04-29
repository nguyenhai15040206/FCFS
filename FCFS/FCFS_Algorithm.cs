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
    }
}
