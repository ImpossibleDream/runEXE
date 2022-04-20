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
                    Console.Write("The EXE path: ");
                    myProcess.StartInfo.FileName = Console .ReadLine ();
                    myProcess.Start();
                    Console.WriteLine("This project is also able to print anything (including normal output and exception) that the EXE will print.");
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
