using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Autorun_Killer.Class
{
    public class VirusKiller
    {
        public static List<string> VirusFolders = new List<string>();


        /// <summary>
        /// Tries to fix system hidden folders
        /// </summary>
        /// <param name="txtResultViewer"></param>
        /// <returns></returns>
        public static bool FixFolders(ref RichTextBox txtResultViewer, ref ToolStripStatusLabel toolStripStatusLabel1)
        {
            bool AnyDamagedFolder = false;
            txtResultViewer.Text += "Trying to Fix Damaged Folders...\n";
            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
            txtResultViewer.ScrollToCaret();
            Application.DoEvents();
            System.Threading.Thread.Sleep(350);
            foreach (string CurrentPath in Global.ListOfFolders)
            {
                DirectoryInfo DIR = new DirectoryInfo(CurrentPath);
                toolStripStatusLabel1.Text = DIR.FullName;
                Application.DoEvents();
                if (DIR.Attributes == (FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory ))
                {
                    AnyDamagedFolder = true;
                    try
                    {
                        DIR.Attributes = FileAttributes.Normal;
                        txtResultViewer.Text += CurrentPath.ToString() + " ==> Succeed !!!\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                    catch (Exception er)
                    {
                        System.Threading.Thread.Sleep(1000);
                        txtResultViewer.Text += CurrentPath.ToString() + " ==> Failed (" + er.Message + ") !!!\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                }
            }
            if (AnyDamagedFolder)
                return AnyDamagedFolder;
            else
            {
                txtResultViewer.Text += "Note: No Damaged Folder Detected.\n";
                txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                txtResultViewer.ScrollToCaret();
                return AnyDamagedFolder;
            }
        }


        /// <summary>
        /// Kills the Main File of viruses.
        /// </summary>
        /// <param name="txtResultViewer"></param>
        /// <param name="toolStripStatusLabel1"></param>
        /// <returns></returns>
        public static bool KillingExtremelyHiddenViruses(ref RichTextBox txtResultViewer, ref ToolStripStatusLabel toolStripStatusLabel1)
        {
            bool AnyHiddenVirus = false;
            txtResultViewer.Text += "Trying to Detect Extremely Hidden Viruses... \n";
            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
            txtResultViewer.ScrollToCaret();
            Application.DoEvents();
            System.Threading.Thread.Sleep(350);
            foreach (string CurrentPath in Global.ListOfFolders)
            {
                DirectoryInfo DIR = new DirectoryInfo(CurrentPath);
                toolStripStatusLabel1.Text = DIR.FullName;
                Application.DoEvents();
                if (DIR.Attributes == (FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory))
                {
                    AnyHiddenVirus = true;
                    try
                    {
                        DIR.Attributes = FileAttributes.Normal;
                        txtResultViewer.Text += CurrentPath.ToString() + " ==> Succeed !!!\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                        FileInfo[] fileatt = DIR.GetFiles();
                        foreach (FileInfo a in fileatt)
                        {
                            try
                            {
                                txtResultViewer.Text += "Virus Detected, Cleaning... '" + a.Name.ToString() + "'";
                                txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                                txtResultViewer.ScrollToCaret();
                                Application.DoEvents();
                                a.Attributes = FileAttributes.Normal;
                                a.Delete();
                                txtResultViewer.Text += " ==> (Cleaned)\n";
                                txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                                txtResultViewer.ScrollToCaret();
                                Application.DoEvents();
                            }
                            catch
                            {
                                System.Threading.Thread.Sleep(1000);
                                txtResultViewer.Text += " ==> (Failed)\n";
                                txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                                txtResultViewer.ScrollToCaret();
                                Application.DoEvents();
                            }
                        }
                    }
                    catch (Exception er)
                    {
                        System.Threading.Thread.Sleep(1000);
                        txtResultViewer.Text += CurrentPath.ToString() + " ==> Failed (" + er.Message + ") !!!\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                    try
                    {
                        DIR.Delete(true);
                    }
                    catch(Exception err)
                    {
                        txtResultViewer.Text += CurrentPath.ToString() + " ==> Failed to Dellete (" + err.Message + ") !!!\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                }
            }
            if (AnyHiddenVirus)
            {
                return AnyHiddenVirus;
            }
            else
                return AnyHiddenVirus;
        }


        /// <summary>
        /// Kills the exe file that are like the folders and created by Viruses.
        /// </summary>
        /// <param name="txtResultViewer"></param>
        /// <param name="toolStripStatusLabel1"></param>
        /// <returns></returns>
        public static bool KillingFolderSkinExeFiles(ref RichTextBox txtResultViewer, ref ToolStripStatusLabel toolStripStatusLabel1)
        {
            bool HaveAnyExeFolder = false;
            txtResultViewer.Text += "Trying to Detect Folder Skined Hidden Viruses... \n";
            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
            txtResultViewer.ScrollToCaret();
            Application.DoEvents();
            System.Threading.Thread.Sleep(350);
            foreach (string CurrentFolder in Global.ListOfFolders)
            {
                DirectoryInfo DIR = new DirectoryInfo(CurrentFolder);
                toolStripStatusLabel1.Text = DIR.FullName;
                Application.DoEvents();
                string Virus = DIR.FullName + ".exe";
                FileInfo VirusFile = new FileInfo(Virus);
                if (VirusFile.Exists)
                {
                    HaveAnyExeFolder = true;
                    try
                    {
                        txtResultViewer.Text += "Virus Detected, Trying to Delete '" + DIR.Name + ".exe' ==> ";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        File.Delete(Virus);
                        Application.DoEvents();
                        txtResultViewer.Text += "(Succeed!)\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                    catch
                    {
                        System.Threading.Thread.Sleep(100);
                        txtResultViewer.Text += "(Failed!)\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                }
            }

            if (HaveAnyExeFolder)
            {
                txtResultViewer.Text += "All Folder Skined Viruses Cleaned Successfully. \n";
            }
            else
            {
                txtResultViewer.Text += "No Folder Skined Exe Folder Detected. \n";
            }
                

            //Search for Persian named Viruses, with Different Coddings
            HaveAnyExeFolder = false;
            txtResultViewer.Text += "Searching for Persian Named Virus Files...\n";
            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
            txtResultViewer.ScrollToCaret();
            Application.DoEvents();
            List<byte> bytes = new List<byte>();
            string strings = null;
            foreach (string CurrentFolder in Global.ListOfFolders)
            {
                DirectoryInfo DIR = new DirectoryInfo(CurrentFolder);
                toolStripStatusLabel1.Text = DIR.FullName;
                Application.DoEvents();
                string Virus = DIR.FullName + ".exe";
                FileInfo PersianNamedVirusFiles = new FileInfo(Virus);
                char[] chars = PersianNamedVirusFiles.FullName.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 1740)
                    {
                        chars[i] = 'ي';
                    }
                }
                bytes = Encoding.UTF32.GetBytes(chars).ToList();
                strings = Encoding.UTF32.GetString(bytes.ToArray());
                FileInfo fi = new FileInfo(strings);
                if (fi.Exists)
                {
                    HaveAnyExeFolder = true;
                    try
                    {
                        txtResultViewer.Text += "Virus Detected, Trying to Delete '" + DIR.Name + ".exe' ==> ";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        File.Delete(strings);
                        Application.DoEvents();
                        txtResultViewer.Text += "(Succeed!)\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                    catch
                    {
                        System.Threading.Thread.Sleep(100);
                        txtResultViewer.Text += "(Failed!)\n";
                        txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                        txtResultViewer.ScrollToCaret();
                        Application.DoEvents();
                    }
                }
            }
            if (HaveAnyExeFolder)
                return HaveAnyExeFolder;
            else
            {
                toolStripStatusLabel1.Text = "Note: No Persian Named Exe Folder Virus Detected.";
                return HaveAnyExeFolder;
            }
        }


        /// <summary>
        /// Deletes the autorun.inf main launcher file.
        /// </summary>
        /// <param name="txtResultViewer"></param>
        /// <returns></returns>
        public static bool KillAutorunInfFile(ref RichTextBox txtResultViewer)
        {
            bool IsAnyAutorunFileDetected = false;
            foreach (string CurrentDIR in Global.ListOfFolders)
            {
                DirectoryInfo DIR = new DirectoryInfo(CurrentDIR);
                FileInfo[] Files = DIR.GetFiles();
                foreach (FileInfo f in Files)
                {
                    if (File.Exists(DIR.FullName + @"\autorun.inf"))
                    {
                        IsAnyAutorunFileDetected = true;
                        try
                        {
                            txtResultViewer.Text += "Deleting the Autorun.inf File, at: '" + DIR.FullName + "'";
                            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                            txtResultViewer.ScrollToCaret();
                            Application.DoEvents();
                            f.Delete();
                            txtResultViewer.Text += " ==> (Succeed)\n";
                            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                            txtResultViewer.ScrollToCaret();
                            Application.DoEvents();
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(500);
                            txtResultViewer.Text += " ==> (Failed)\n";
                            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                            txtResultViewer.ScrollToCaret();
                            Application.DoEvents();
                        }
                    }
                }
            }
            if (!IsAnyAutorunFileDetected)
            {
                txtResultViewer.Text += "\nNo Autorun.inf File Detected.\n";
                txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                txtResultViewer.ScrollToCaret();
                return true;
            }
            else
                return false;
        }
    }
}
