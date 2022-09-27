using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Autorun_Killer.Class
{
    public class TargetSelectionAndSearch
    {
        /// <summary>
        /// show's the dialog box for selecting the target for scan, m.taghadosi
        /// </summary>
        /// <param name="a"></param>
        public static void ShowTargetSelectionDialog(FolderBrowserDialog a)
        {
            a.ShowNewFolderButton = false;
            a.Description = "لطفا یک درایو یا پوشه را جهت عملیات اسکن برای پیدا کردن ویروس اتوران انتخاب کنید";
            a.ShowDialog();
            if (a.SelectedPath != "")
            {
                Global.SelectedPath = a.SelectedPath;
            }
        }

        /// <summary>
        /// Make a Full list of folders And sub folders that user selected
        /// </summary>
        /// <param name="Target"></param>
        /// <returns></returns>
        public static List<string> GetFolderLists(string Target, ref RichTextBox txtResultViewer)
        {
            DirectoryInfo[] DirectoryLists = new DirectoryInfo(Target).GetDirectories();
            List<string> OpenFolders = new List<string>();
            List<string> FolderNames = new List<string>();
            List<string> ClosedFolders = new List<string>();
            DirectoryInfo CurrentFolder = null;
            txtResultViewer.Clear();
            txtResultViewer.Text += "Generating List of Folders for Scan Process, Please Wait... ";
            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
            txtResultViewer.ScrollToCaret();
            Application.DoEvents();
            OpenFolders.Add(Target); //Ads Root Folder that User Selected
            while (OpenFolders.Count != 0)
            {
                string CurrentPath = OpenFolders[0];
                OpenFolders.RemoveAt(0);
                try
                {
                    DirectoryInfo[] Neighbors = new DirectoryInfo(CurrentPath).GetDirectories();
                    for (int i = 0; i < Neighbors.Length; i++)
                    {
                        CurrentFolder = Neighbors[i];
                        OpenFolders.Add(CurrentFolder.FullName);
                        FolderNames.Add(CurrentFolder.FullName);
                    }
                    ClosedFolders.Add(CurrentPath);
                }
                catch
                {
                    txtResultViewer.Text += "\n Access to Folder '" + CurrentFolder.Name + "', is Denied.\nGenerating List of Folders for Scan Process... ";
                    txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
                    txtResultViewer.ScrollToCaret();
                    Application.DoEvents();
                }
            }
            ClosedFolders.Sort();
            System.Threading.Thread.Sleep(1000);
            txtResultViewer.Text += " ==> (Done)\n";
            txtResultViewer.Select(txtResultViewer.Text.Length - 2, 1);
            txtResultViewer.ScrollToCaret();
            Application.DoEvents();
            return ClosedFolders;
        }
    }
}
