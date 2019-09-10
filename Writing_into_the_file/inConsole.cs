using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Writing_into_the_file
{
    class inConsole
    {
        protected static string file = inFile.get_file();
        public static void writeInConsole()
        {
            StreamReader result_in = new StreamReader(file);
            Console.WriteLine(File.ReadAllText(file));
        }
    }
}
