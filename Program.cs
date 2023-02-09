using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Management.Automation;

namespace PSGPO_Evasion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerShell ps = PowerShell.Create();
            string command;
            Collection<PSObject> PSOutput;
            while (true)
            {
                command = Console.ReadLine();
                PSOutput = ps.AddScript(command).Invoke();

                if (command == "exit")
                {
                    break;
                }
                for (int i = 0; i < PSOutput.Count; i++)
                {
                    Console.WriteLine(PSOutput[i].ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
