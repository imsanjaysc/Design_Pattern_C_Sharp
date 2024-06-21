using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class lock_vs_Monitor
    {
        static object _lock;
        static int Total = 0;

        public static void LockKeyword() {
            for (int i = 0; i < 100; i++) {
                lock (_lock)
                {
                    Total++;
                }
            }
        }

        public static void MonitorClass()
        {
            for (int i = 0; i < 100; i++)
            {
                /*below code is same as 
                    lock (_lock)
                    {
                        Total++;
                    }
                 */
                Monitor.Enter(_lock);
                try
                {
                    Total++;
                }
                finally { 
                    Monitor.Exit(_lock);
                }
            }
        }
    }
}

/*
Definition: Both Monitor class and lock keyword provides a mechanism that synchronizes access to objects.
lock is the shorcut for Monitor.Enter with try and finally
 */
