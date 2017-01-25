namespace SoftwareEngProj
{
    partial class CreatingPt3
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
            this.CurrentParticipantsLst = new System.Windows.Forms.ListBox();
            this.Help = new System.Windows.Forms.Button();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.ActiveChk = new System.Windows.Forms.CheckBox();
            this.ImportantChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CurrentParticipantsLst
            // 
            this.CurrentParticipantsLst.FormattingEnabled = true;
            this.CurrentParticipantsLst.Location = new System.Drawing.Point(37, 15);
            this.CurrentParticipantsLst.Name = "CurrentParticipantsLst";
            this.CurrentParticipantsLst.Size = new System.Drawing.Size(215, 264);
            this.CurrentParticipantsLst.TabIndex = 0;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(489, 275);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(145, 31);
            this.Help.TabIndex = 7;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(436, 170);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(145, 31);
            this.ClearAllBtn.TabIndex = 8;
            this.ClearAllBtn.Text = "Clear All";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(436, 90);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(145, 31);
            this.NextBtn.TabIndex = 9;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ActiveChk
            // 
            this.ActiveChk.AutoSize = true;
            this.ActiveChk.Location = new System.Drawing.Point(303, 90);
            this.ActiveChk.Name = "ActiveChk";
            this.ActiveChk.Size = new System.Drawing.Size(56, 17);
            this.ActiveChk.TabIndex = 10;
            this.ActiveChk.Text = "Active";
            this.ActiveChk.UseVisualStyleBackColor = true;
            // 
            // ImportantChk
            // 
            this.ImportantChk.AutoSize = true;
            this.ImportantChk.Location = new System.Drawing.Point(303, 170);
            this.ImportantChk.Name = "ImportantChk";
            this.ImportantChk.Size = new System.Drawing.Size(70, 17);
            this.ImportantChk.TabIndex = 11;
            this.ImportantChk.Text = "Important";
            this.ImportantChk.UseVisualStyleBackColor = true;
            // 
            // CreatingPt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 318);
            this.Controls.Add(this.ImportantChk);
            this.Controls.Add(this.ActiveChk);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.CurrentParticipantsLst);
            this.Name = "CreatingPt3";
            this.Text = "CreatingPt3";
            this.Load += new System.EventHandler(this.CreatingPt3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CurrentParticipantsLst;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.CheckBox ActiveChk;
        private System.Windows.Forms.CheckBox ImportantChk;
    }
}