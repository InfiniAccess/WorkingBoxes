using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> Boxes = new List<object>();

            Boxes.Add(7);
            Boxes.Add(28);
            Boxes.Add(-1);
            Boxes.Add(true);
            Boxes.Add("chair");

            int sum = 0;
            foreach (object item in Boxes)
            {
                if (item is int)
                {
                    sum += (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
