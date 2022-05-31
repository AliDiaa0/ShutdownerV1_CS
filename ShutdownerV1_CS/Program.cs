using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownerV1_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PC Shutdowner V1.0 (by Ali Diaa)";

            Console.Write("Enter 'Shutdown' to shut down your computer.\n\r" + "Enter 'Restart' to reboot your computer: ");
            string input = Console.ReadLine();

            //Shut down
            ProcessStartInfo shutdown = new ProcessStartInfo();
            shutdown.FileName = "cmd.exe";
            shutdown.WindowStyle = ProcessWindowStyle.Hidden;
            shutdown.Arguments = @"/k shutdown /s /t 0";

            //Reboot
            ProcessStartInfo reboot = new ProcessStartInfo();
            reboot.FileName = "cmd.exe";
            reboot.WindowStyle = ProcessWindowStyle.Hidden;
            reboot.Arguments = @"/k shutdown /r /t 0";

            if (input == "Shutdown")
            {
                Process.Start(shutdown);
            }
            else if (input == "Restart")
            {
                Process.Start(reboot);
            }
            else
            {
                MessageBox.Show("Invalid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
