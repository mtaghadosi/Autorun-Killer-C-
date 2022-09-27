using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Autorun_Killer.Class;
using System.IO;

namespace Autorun_Killer.GUI
{
    public partial class PersianMainForm : Form
    {
        public PersianMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Text = "Wait...";
            btnExit.Enabled = false;
            Application.DoEvents();
            Application.Exit();
        }

        private void btnTargetSelection_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FldrBrowser = new FolderBrowserDialog();
            TargetSelectionAndSearch.ShowTargetSelectionDialog(FldrBrowser);
            if (FldrBrowser.SelectedPath != "")
            {
                statusStrip1.RightToLeft = RightToLeft.No;
                toolStripStatusLabel1.Text = Global.SelectedPath + " + [All SubFolders]";
            }

        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            btnStartScan.Text = "Wait...";
            btnStartScan.Enabled = false;
            BeginKillToolStripMenuItem.Enabled = false;
            Application.DoEvents();
            if (Global.SelectedPath == "" || Global.SelectedPath == null)
            {
                MessageBox.Show("لطفا اول یک درایو یا یک پوشه انتخاب کنید", "خــــطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                btnStartScan.Text = "شروع";
                btnStartScan.Enabled = true;
                BeginKillToolStripMenuItem.Enabled = true;
                Application.DoEvents();
                return;
            }
            Global.ListOfFolders = TargetSelectionAndSearch.GetFolderLists(Global.SelectedPath,ref txtResultsViewer);
            System.Threading.Thread.Sleep(500);
            /*
            if (!Global.KillingExplorerProcess(ref txtResultsViewer))
            {
                MessageBox.Show("از نرم افزار استفاده کنید Safe Mode خطا در بستن یکی از پردازش های سیستم، پیشنهاد می شود در حالت", "خــــطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Application.Exit();
                return;
            }
             */
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            VirusKiller.FixFolders(ref txtResultsViewer, ref toolStripStatusLabel1);

            //Global.KillAllOtherProcesses(ref txtResultsViewer);

            if (!VirusKiller.KillingExtremelyHiddenViruses(ref txtResultsViewer, ref toolStripStatusLabel1))
                txtResultsViewer.Text += "Note: No Hidden Virus Detected. \n";
            VirusKiller.KillingFolderSkinExeFiles(ref txtResultsViewer, ref toolStripStatusLabel1);
            VirusKiller.KillAutorunInfFile(ref txtResultsViewer);
            Global.StartExplorer(ref txtResultsViewer);
            txtResultsViewer.Text += "\nAll Operations Completed.\n";
            txtResultsViewer.Select(txtResultsViewer.Text.Length - 2, 1);
            txtResultsViewer.ScrollToCaret();
            btnStartScan.Text = "شروع";
            btnStartScan.Enabled = true;
            BeginKillToolStripMenuItem.Enabled = true;
            Application.DoEvents();
            Global.SelectedPath = null;
            toolStripStatusLabel1.Text = "هیچ درایو / پوشه ای انتخاب نشده لطفا یک درایو را انتخاب کنید";
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            Application.DoEvents();
            btn_restart.Visible = true;
            MessageBox.Show("عملیات پاکسازی انجام شد شما می توانید اطلاعات بدست آمده را برای بررسی بیشتر با کلیک راست روی قسمت نمایش اطلاعات ذخیره کنید، در صورتی که خطایی در برنامه وجود دارد آن را به همراه فایل لاگ برای نویسنده برنامه ایمیل کنید شدیدا توصیه می شود با کلیک بر روی دکمه ریستارت رایانه ی خود را ریستارت کنید", "پیشنهاد نرم افزار",
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void PersianMainForm_Load(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("در هنگامی که عملیات پاکسازی توسط این برنامه صورت می گیرد امکان دارد که بعضی برنامه ها روی سیستم شما بسته شوند لطفا اطمینان حاصل کنید که تمام برنامه های خود را ذخیره کردیده اید، حتی امکان دارد منوی استارت و آیکن ها نیز ناپدید شوند اما بعد از اتمام عملیات همه چیز به حالت اولیه بر می گردد. آیا تایید می کنید؟", "برنامه نیاز به تایید شما دارد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (DialogResult == DialogResult.No)
            {
                Application.Exit();
                return;
            }
            if (!Global.DisableAutoStartExplorer())
            {
                MessageBox.Show("عدم توانایی در دسترسی به رجیستری سیستم، لطفا با کاربری با مجوز مدیر وارد سیستم شوید", "خــــطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Application.Exit();
                return;
            }
            Global.DisableCloseBotton(this.Handle, false, 0xF060, 0x1);
            toolStripStatusLabel1.Text = "هیچ درایو / پوشه ای انتخاب نشده لطفا یک درایو را انتخاب کنید";
        }

        private void SelectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTargetSelection_Click(sender, e);
        }

        private void BeginKillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStartScan_Click(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit.Text = "Wait...";
            btnExit.Enabled = false;
            Application.DoEvents();
            Application.Exit();
        }

        private void NewSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTargetSelection_Click(sender, e);
        }

        private void ClearSCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultsViewer.Clear();
        }

        private void AboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarsiAboutBox frsab = new FarsiAboutBox();
            frsab.ShowDialog();
        }

        private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> LinesLists = new List<string>();
            LinesLists = txtResultsViewer.Lines.ToList<string>();
            foreach (string a in LinesLists)
            {
                if(a.Equals("Failed",StringComparison.CurrentCultureIgnoreCase))
                {
                    //on the make!!!
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo Desktop = new DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            txtResultsViewer.SaveFile(Desktop.FullName+@"\ScanResults.doc", RichTextBoxStreamType.RichText);
            MessageBox.Show("اطلاعات بصورت فایلی متنی در دسکتاپ ذخیره گردید", "ذخیره موفق آمیز",
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void PersianMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.StartExplorer(ref txtResultsViewer);
            Global.EnablingAutoStartProcess();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            if (!Global.RestartSystem())
            {
                MessageBox.Show("در ریستارت مجدد سیستم مشکلی پیش آمده است لطفا بصورت دستی این عمل را انجام دهید", "خطــا",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}
