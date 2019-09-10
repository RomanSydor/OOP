using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Writing_into_the_file
{
    class input
    {
        protected static double a, b, step;
        public static void set_info()
        {
            Console.Write("Input a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Input step: ");
            step = double.Parse(Console.ReadLine());
        }

        public static double get_a()
        {
            return a;
        }
        public static double get_b()
        {
            return b;
        }
        public static double get_step()
        {
            return step;
        }
    }
}
