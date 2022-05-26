using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    public class Process
    {
        public int arrival;
        public int index;
        public int brustTime;
        public int priority;

        public Process()
        {

        }

        public Process(int i, int value, int b)
        {
            index = i;
            arrival = value;
            brustTime = b;
        }

        public Process(int i, int value, int b, int p)
        {
            index = i;
            arrival = value;
            brustTime = b;
            priority = p;
        }


        public static void Sort(List<Process> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].arrival < list[j].arrival)
                    {
                        Process temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public static void Sort2(List<Process> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].priority < list[j].priority)
                    {
                        Process temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public static void Sort3(List<Process> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].brustTime < list[j].brustTime)
                    {
                        Process temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public static void Sort4(List<Process> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].brustTime <= l[j].brustTime)
                    {
                        Process temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }
    }
}
