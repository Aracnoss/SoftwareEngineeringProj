namespace SoftwareEngProj
{
    partial class CreatingPt2
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
            this.PotentialParticipantsLst = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentParticipantsLst
            // 
            this.CurrentParticipantsLst.FormattingEnabled = true;
            this.CurrentParticipantsLst.Location = new System.Drawing.Point(50, 47);
            this.CurrentParticipantsLst.Name = "CurrentParticipantsLst";
            this.CurrentParticipantsLst.Size = new System.Drawing.Size(192, 199);
            this.CurrentParticipantsLst.TabIndex = 0;
            // 
            // PotentialParticipantsLst
            // 
            this.PotentialParticipantsLst.FormattingEnabled = true;
            this.PotentialParticipantsLst.Location = new System.Drawing.Point(390, 47);
            this.PotentialParticipantsLst.Name = "PotentialParticipantsLst";
            this.PotentialParticipantsLst.Size = new System.Drawing.Size(192, 199);
            this.PotentialParticipantsLst.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(296, 60);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(44, 37);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "<<";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(296, 124);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(44, 37);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "✓";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(296, 193);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(44, 37);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = ">>";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(479, 271);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(145, 31);
            this.Help.TabIndex = 7;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // CreatingPt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 314);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PotentialParticipantsLst);
            this.Controls.Add(this.CurrentParticipantsLst);
            this.Name = "CreatingPt2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreatingPt2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CurrentParticipantsLst;
        private System.Windows.Forms.ListBox PotentialParticipantsLst;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button Help;
    }
}