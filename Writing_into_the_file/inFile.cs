using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Writing_into_the_file
{
    class inFile
    {
        protected static double a, b, step, i, choose, j = 0;
        protected static string file;

        public static double function(double x)
        {
            return x * x;
        }


        public static void set_file()
        {
            Console.Write("Choose type of file \n 1).docx \n 2).txt \n 3).odt \n");
            choose = double.Parse(Console.ReadLine());
            if (choose == 1) file = @"C:\С#\Writing_into_the_file\Writing_into_the_file\result.docx";
            if (choose == 2) file = @"C:\С#\Writing_into_the_file\Writing_into_the_file\result.txt";
            if (choose == 3) file = @"C:\С#\Writing_into_the_file\Writing_into_the_file\result.odt";
        }

        public static string get_file()
        {
            return file;
        }


        public static void writeInFile()
        { 
            a = input.get_a();
            b = input.get_b();
            step = input.get_step();

            StreamWriter result_out = new StreamWriter(file);

            for (i = a; i <= b; i += step)
            {
                j++;
                result_out.WriteLine(j + ") Result (x = " + i + ") : " + function(i));
            }

            result_out.Close();
        }
    }

}
