using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.ComponentModel;

namespace runEXE
{
    class runEXE
    {
        static void Main(string[] args)
        {
            try
            {
                using (Process myProcess = new Process ())
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = @"c:\Users\admin\source\repos\DirectoryStatistic\DirectoryStatistic\bin\Debug\DirectoryStatistic.exe";
                    myProcess.Start();
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
