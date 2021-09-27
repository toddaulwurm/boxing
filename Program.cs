using System;
using System.Collections.Generic;

namespace multi
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<object> boxy = new List<object>();
            boxy.Add(7);
            boxy.Add(28);
            boxy.Add(-1);
            boxy.Add(true);
            boxy.Add("chair");
            int sum = 0;
            foreach(object item in boxy)
            {
                Console.WriteLine(item);
                if(item is int)
                {
                    sum+= (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
