using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Writing_into_the_file
{
     
    class Program
    {
        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                input.set_info();
                inFile.set_file();
                inFile.writeInFile();
                inConsole.writeInConsole();
                
                Console.Write("Result was saved in the file! \n Do you want to continue? \n 1) yes \n 2) no \n");
                choose = int.Parse(Console.ReadLine());
            } while (choose == 1);
        }

    }
}
