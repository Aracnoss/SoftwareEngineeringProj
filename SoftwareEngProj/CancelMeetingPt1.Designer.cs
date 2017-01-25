namespace SoftwareEngProj
{
    partial class CancelMeetingPt1
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
            this.DateLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.DateRangeLbl = new System.Windows.Forms.Label();
            this.MeetingDescLbl = new System.Windows.Forms.Label();
            this.MeetingNameLbl = new System.Windows.Forms.Label();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.SureTxtLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentParticipantsLst
            // 
            this.CurrentParticipantsLst.FormattingEnabled = true;
            this.CurrentParticipantsLst.Location = new System.Drawing.Point(347, 22);
            this.CurrentParticipantsLst.Name = "CurrentParticipantsLst";
            this.CurrentParticipantsLst.Size = new System.Drawing.Size(192, 199);
            this.CurrentParticipantsLst.TabIndex = 31;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(215, 157);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(74, 13);
            this.DateLbl.TabIndex = 30;
            this.DateLbl.Text = "(Date Range:)";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(215, 104);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(110, 13);
            this.DescriptionLbl.TabIndex = 29;
            this.DescriptionLbl.Text = "(Meeting Description:)";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(215, 52);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(78, 13);
            this.NameLbl.TabIndex = 28;
            this.NameLbl.Text = "(meetingName)";
            // 
            // DateRangeLbl
            // 
            this.DateRangeLbl.AutoSize = true;
            this.DateRangeLbl.Location = new System.Drawing.Point(140, 157);
            this.DateRangeLbl.Name = "DateRangeLbl";
            this.DateRangeLbl.Size = new System.Drawing.Size(68, 13);
            this.DateRangeLbl.TabIndex = 27;
            this.DateRangeLbl.Text = "Date Range:";
            // 
            // MeetingDescLbl
            // 
            this.MeetingDescLbl.AutoSize = true;
            this.MeetingDescLbl.Location = new System.Drawing.Point(104, 104);
            this.MeetingDescLbl.Name = "MeetingDescLbl";
            this.MeetingDescLbl.Size = new System.Drawing.Size(104, 13);
            this.MeetingDescLbl.TabIndex = 26;
            this.MeetingDescLbl.Text = "Meeting Description:";
            // 
            // MeetingNameLbl
            // 
            this.MeetingNameLbl.AutoSize = true;
            this.MeetingNameLbl.Location = new System.Drawing.Point(129, 52);
            this.MeetingNameLbl.Name = "MeetingNameLbl";
            this.MeetingNameLbl.Size = new System.Drawing.Size(79, 13);
            this.MeetingNameLbl.TabIndex = 25;
            this.MeetingNameLbl.Text = "Meeting Name:";
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(518, 325);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(145, 31);
            this.HelpBtn.TabIndex = 32;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            // 
            // YesBtn
            // 
            this.YesBtn.Location = new System.Drawing.Point(130, 279);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(145, 31);
            this.YesBtn.TabIndex = 33;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.Location = new System.Drawing.Point(370, 279);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(145, 31);
            this.NoBtn.TabIndex = 34;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // SureTxtLbl
            // 
            this.SureTxtLbl.AutoSize = true;
            this.SureTxtLbl.Location = new System.Drawing.Point(215, 251);
            this.SureTxtLbl.Name = "SureTxtLbl";
            this.SureTxtLbl.Size = new System.Drawing.Size(205, 13);
            this.SureTxtLbl.TabIndex = 35;
            this.SureTxtLbl.Text = "Are you sure you want to cancel meeting?";
            // 
            // CancelMeetingPt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 368);
            this.Controls.Add(this.SureTxtLbl);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.CurrentParticipantsLst);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.DateRangeLbl);
            this.Controls.Add(this.MeetingDescLbl);
            this.Controls.Add(this.MeetingNameLbl);
            this.Name = "CancelMeetingPt1";
            this.Text = "CancelMeetingPt1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CurrentParticipantsLst;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label DateRangeLbl;
        private System.Windows.Forms.Label MeetingDescLbl;
        private System.Windows.Forms.Label MeetingNameLbl;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Label SureTxtLbl;
    }
}