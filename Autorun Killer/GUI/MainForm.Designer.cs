namespace Autorun_Killer
{
    partial class frmLanguegeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanguegeSelection));
            this.btnPersian = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultsViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPersian
            // 
            this.btnPersian.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPersian.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPersian.Location = new System.Drawing.Point(311, 101);
            this.btnPersian.Name = "btnPersian";
            this.btnPersian.Size = new System.Drawing.Size(75, 23);
            this.btnPersian.TabIndex = 0;
            this.btnPersian.Text = "&Persian";
            this.btnPersian.UseVisualStyleBackColor = true;
            this.btnPersian.Click += new System.EventHandler(this.btnPersian_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnglish.Enabled = false;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnglish.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEnglish.Location = new System.Drawing.Point(230, 101);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(75, 23);
            this.btnEnglish.TabIndex = 1;
            this.btnEnglish.Text = "&English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(149, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtResultsViewer
            // 
            this.txtResultsViewer.Location = new System.Drawing.Point(177, 106);
            this.txtResultsViewer.Name = "txtResultsViewer";
            this.txtResultsViewer.Size = new System.Drawing.Size(12, 11);
            this.txtResultsViewer.TabIndex = 4;
            this.txtResultsViewer.Text = "";
            this.txtResultsViewer.Visible = false;
            // 
            // frmLanguegeSelection
            // 
            this.AcceptButton = this.btnPersian;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(398, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnPersian);
            this.Controls.Add(this.txtResultsViewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLanguegeSelection";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Languege Selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLanguegeSelection_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersian;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResultsViewer;
    }
}

