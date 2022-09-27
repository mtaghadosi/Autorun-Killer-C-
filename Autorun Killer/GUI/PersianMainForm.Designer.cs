namespace Autorun_Killer.GUI
{
    partial class PersianMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersianMainForm));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BeginKillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultsViewer = new System.Windows.Forms.RichTextBox();
            this.cmstxtResultViewer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearSCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.NewSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTargetSelection = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.mnuMainMenu.SuspendLayout();
            this.cmstxtResultViewer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AboutMeToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(564, 24);
            this.mnuMainMenu.TabIndex = 9;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectFolderToolStripMenuItem,
            this.BeginKillToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "&عملیات";
            // 
            // SelectFolderToolStripMenuItem
            // 
            this.SelectFolderToolStripMenuItem.Name = "SelectFolderToolStripMenuItem";
            this.SelectFolderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.SelectFolderToolStripMenuItem.Text = "... انتخاب پوشه";
            this.SelectFolderToolStripMenuItem.Click += new System.EventHandler(this.SelectFolderToolStripMenuItem_Click);
            // 
            // BeginKillToolStripMenuItem
            // 
            this.BeginKillToolStripMenuItem.Name = "BeginKillToolStripMenuItem";
            this.BeginKillToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.BeginKillToolStripMenuItem.Text = "شروع عملیات پاکسازی";
            this.BeginKillToolStripMenuItem.Click += new System.EventHandler(this.BeginKillToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ExitToolStripMenuItem.Text = "خـــروج";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutMeToolStripMenuItem
            // 
            this.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem";
            this.AboutMeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.AboutMeToolStripMenuItem.Text = "درباره &من";
            this.AboutMeToolStripMenuItem.Click += new System.EventHandler(this.AboutMeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "وضعیت:";
            // 
            // txtResultsViewer
            // 
            this.txtResultsViewer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResultsViewer.ContextMenuStrip = this.cmstxtResultViewer;
            this.txtResultsViewer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResultsViewer.Location = new System.Drawing.Point(12, 50);
            this.txtResultsViewer.Name = "txtResultsViewer";
            this.txtResultsViewer.ReadOnly = true;
            this.txtResultsViewer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtResultsViewer.Size = new System.Drawing.Size(540, 215);
            this.txtResultsViewer.TabIndex = 11;
            this.txtResultsViewer.Text = "";
            this.txtResultsViewer.WordWrap = false;
            // 
            // cmstxtResultViewer
            // 
            this.cmstxtResultViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FailedToolStripMenuItem,
            this.toolStripSeparator2,
            this.SaveToolStripMenuItem,
            this.ClearSCRToolStripMenuItem,
            this.toolStripSeparator3,
            this.NewSearchToolStripMenuItem,
            this.ExittToolStripMenuItem});
            this.cmstxtResultViewer.Name = "cmstxtResultViewer";
            this.cmstxtResultViewer.Size = new System.Drawing.Size(193, 126);
            // 
            // FailedToolStripMenuItem
            // 
            this.FailedToolStripMenuItem.Name = "FailedToolStripMenuItem";
            this.FailedToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.FailedToolStripMenuItem.Text = "نمایش موارد عدم موفقیت";
            this.FailedToolStripMenuItem.Click += new System.EventHandler(this.FailedToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.SaveToolStripMenuItem.Text = "... ذخیره نتایج در فایل";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ClearSCRToolStripMenuItem
            // 
            this.ClearSCRToolStripMenuItem.Name = "ClearSCRToolStripMenuItem";
            this.ClearSCRToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ClearSCRToolStripMenuItem.Text = "پاکسازی صفحه";
            this.ClearSCRToolStripMenuItem.Click += new System.EventHandler(this.ClearSCRToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // NewSearchToolStripMenuItem
            // 
            this.NewSearchToolStripMenuItem.Name = "NewSearchToolStripMenuItem";
            this.NewSearchToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.NewSearchToolStripMenuItem.Text = "... جستجوی جدید";
            this.NewSearchToolStripMenuItem.Click += new System.EventHandler(this.NewSearchToolStripMenuItem_Click);
            // 
            // ExittToolStripMenuItem
            // 
            this.ExittToolStripMenuItem.Name = "ExittToolStripMenuItem";
            this.ExittToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ExittToolStripMenuItem.Text = "خروج از برنامه";
            this.ExittToolStripMenuItem.Click += new System.EventHandler(this.ExittToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(564, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnTargetSelection
            // 
            this.btnTargetSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTargetSelection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTargetSelection.Location = new System.Drawing.Point(335, 274);
            this.btnTargetSelection.Name = "btnTargetSelection";
            this.btnTargetSelection.Size = new System.Drawing.Size(136, 23);
            this.btnTargetSelection.TabIndex = 14;
            this.btnTargetSelection.Text = "...انتخاب مسیر جستجو";
            this.btnTargetSelection.UseVisualStyleBackColor = true;
            this.btnTargetSelection.Click += new System.EventHandler(this.btnTargetSelection_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartScan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStartScan.Location = new System.Drawing.Point(477, 274);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(75, 23);
            this.btnStartScan.TabIndex = 13;
            this.btnStartScan.Text = "شروع";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(254, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "&خــروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_restart.ForeColor = System.Drawing.Color.Red;
            this.btn_restart.Location = new System.Drawing.Point(173, 274);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 16;
            this.btn_restart.Text = "ریستارت";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // PersianMainForm
            // 
            this.AcceptButton = this.btnTargetSelection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(564, 327);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTargetSelection);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtResultsViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuMainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersianMainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorun Killer - By M.Taghadosi Ver 3.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersianMainForm_FormClosing);
            this.Load += new System.EventHandler(this.PersianMainForm_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.cmstxtResultViewer.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BeginKillToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResultsViewer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnTargetSelection;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip cmstxtResultViewer;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearSCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FailedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem NewSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExittToolStripMenuItem;
        private System.Windows.Forms.Button btn_restart;
    }
}