using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Reflection;

namespace Autorun_Killer.Class
{
    public class Global
    {
        public static string SelectedPath = null;
        public static List<string> ListOfFolders = new List<string>(); //String List of all Folders...

        //this codes disables the form's close bottons created by M.Taghadosi...
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);


        /// <summary>
        /// this methode disables the form's close botton
        /// </summary>
        /// <param name="a">please write this.Handle</param>
        /// <param name="b">Please Write False</param>
        /// <param name="SC_CLOSE">Please Write 0xF060</param>
        /// <param name="MF_GRAYED">Please Write 0x1</param>
        public static void DisableCloseBotton(IntPtr a, bool b, int SC_CLOSE, int MF_GRAYED)
        {
            EnableMenuItem(GetSystemMenu(a, b), SC_CLOSE, MF_GRAYED);
        }



        /// <summary>
        /// pervents explorer to auto start after killing m.taghadosi
        /// </summary>
        /// <param name="txtResultsViewer"></param>
        /// <returns></returns>
        public static bool DisableAutoStartExplorer()
        {
            bool IsSucceed = true;
            try
            {
                RegistryKey AutoStart = Registry.LocalMachine;
                AutoStart.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true).SetValue("AutoRestartShell", 0);
            }
            catch
            {
                IsSucceed = false;
            }
            if (IsSucceed)
                return IsSucceed;
            else
                return IsSucceed;
        }

        /// <summary>
        /// Enables auto starting explorer process after all operations completed m.taghadosi
        /// </summary>
        /// <param name="txtResultsViewer"></param>
        /// <returns></returns>
        public static bool EnablingAutoStartProcess()
        {
            bool IsSucceed = true;
            try
            {
                RegistryKey AutoStart = Registry.LocalMachine;
                AutoStart.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true).SetValue("AutoRestartShell", 1);
            }
            catch
            {
                IsSucceed = false;
            }
            if (IsSucceed)
                return IsSucceed;
            else
                return IsSucceed;
        }


        /// <summary>
        /// Kills Explorer Process, m-taghadosi
        /// </summary>
        /// <param name="txtResultsViewer"></param>
        /// <returns></returns>
        public static bool KillingExplorerProcess(ref RichTextBox txtResultsViewer)
        {
            bool IstheProcessKilled = true;
            txtResultsViewer.Text += "Trying to Stop Explorer Process... ";
            Process[] SystemCurrentProceses = System.Diagnostics.Process.GetProcesses();
            foreach (Process CurrentProcess in SystemCurrentProceses)
            {
                try
                {
                    Application.DoEvents();
                    if (CurrentProcess.ProcessName == "explorer")
                        CurrentProcess.Kill();
                }
                catch
                {
                    IstheProcessKilled = false;
                }
            }
            if (IstheProcessKilled)
            {
                txtResultsViewer.Text += " ==> (Succeed)\n";
                Application.DoEvents();
                return IstheProcessKilled;
            }
            else
            {
                System.Threading.Thread.Sleep(500);
                txtResultsViewer.Text += " ==> (Failed)\n";
                Application.DoEvents();
                return IstheProcessKilled;
            }
        }


        /// <summary>
        /// kills all other Processes when caled m-taghadosi
        /// </summary>
        /// <param name="txtResultsViewer"></param>
        /// <returns></returns>
        public static bool KillAllOtherProcesses(ref RichTextBox txtResultsViewer)
        {
            bool IsAllKilled = true;
            txtResultsViewer.Text += "Trying to Stop Processes that are using by System... \n";
            Application.DoEvents();
            Process[] SystemCurrentProceses = System.Diagnostics.Process.GetProcesses();
            foreach (Process CurrentProcess in SystemCurrentProceses)
            {
                try
                {
                    if (CurrentProcess.ProcessName != "Idle" && CurrentProcess.ProcessName != "svchost" &&
                        CurrentProcess.ProcessName != "smss" && CurrentProcess.ProcessName != "csrss" &&
                        CurrentProcess.ProcessName != "winlogon" && CurrentProcess.ProcessName != "services" &&
                        CurrentProcess.ProcessName != "lsass" && CurrentProcess.ProcessName != "ctfmon" &&
                        CurrentProcess.ProcessName != "Autorun Killer.vshost" && CurrentProcess.ProcessName != "devenv" &&
                        CurrentProcess.ProcessName != "spoolsv" && CurrentProcess.ProcessName != "System" && 
                        CurrentProcess.ProcessName!="Autorun Killer" && CurrentProcess.ProcessName!="dwm" && CurrentProcess.ProcessName!="lsm" &&
                        CurrentProcess.ProcessName != "wininit")
                    {
                        CurrentProcess.Kill();
                        txtResultsViewer.Text += "Ending Process: " + CurrentProcess.ProcessName + " ==> (Succeed)\n";
                    }
                    Application.DoEvents();
                }
                catch
                {
                    txtResultsViewer.Text +="Ending Process: " + CurrentProcess.ProcessName + " ==> (Failed)\n";
                    Application.DoEvents();
                    IsAllKilled = false;
                }
            }
            if (IsAllKilled)
            {
                txtResultsViewer.Text += "All Succeed, Continuing Operations...\n";
                return IsAllKilled;
            }
            else
                return IsAllKilled;
        }

        /// <summary>
        /// Starts Explorer after all operations Completed - m.taghadosi.
        /// </summary>
        /// <param name="txtResultsViewer"></param>
        public static void StartExplorer(ref RichTextBox txtResultsViewer)
        {
            bool i = true;
            Process[] SystemCurrentProceses = System.Diagnostics.Process.GetProcesses();
            foreach (Process CurrentProcess in SystemCurrentProceses)
            {
                try
                {
                    if (CurrentProcess.ProcessName == "explorer")
                    {
                        i = false;
                    }
                }
                catch
                {
                    //==m.taghadosi
                }
            }
            if (i == true)
            {
                txtResultsViewer.Text += "Starting Explorer... ";
                Application.DoEvents();
                try
                {
                    System.Diagnostics.Process.Start("explorer");
                    System.Threading.Thread.Sleep(2000);
                    txtResultsViewer.Text += " ==> (Succeed)\n";
                    Application.DoEvents();
                }
                catch
                {
                    txtResultsViewer.Text += " ==> (Failed)\n";
                    Application.DoEvents();
                }
            }
        }

        public static bool RestartSystem()
        {
            try
            {
                Process.Start(@"shutdown.exe", "-r -t 10 -c Autorun_Killer_Software_M_Taghadosi");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
