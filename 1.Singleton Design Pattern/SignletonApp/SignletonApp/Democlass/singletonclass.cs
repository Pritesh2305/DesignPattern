using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignletonApp.Democlass
{
    public sealed class singletonclass
    {
        private static singletonclass instance;
        private static object obj;
        private singletonclass() { }
        public static singletonclass GetInstance()
        {
            lock (obj)
            {
                if (instance == null)
                {
                    instance = new singletonclass();
                }
                return instance;
            }
        }        
    }
}

