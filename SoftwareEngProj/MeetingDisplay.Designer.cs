namespace SoftwareEngProj
{
    partial class MeetingDisplay
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
            this.ParticipantsEditBtn = new System.Windows.Forms.Button();
            this.EditDetailsBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.DateRangeGbx = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // CurrentParticipantsLst
            // 
            this.CurrentParticipantsLst.FormattingEnabled = true;
            this.CurrentParticipantsLst.Location = new System.Drawing.Point(252, 12);
            this.CurrentParticipantsLst.Name = "CurrentParticipantsLst";
            this.CurrentParticipantsLst.Size = new System.Drawing.Size(192, 199);
            this.CurrentParticipantsLst.TabIndex = 24;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(120, 128);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(74, 13);
            this.DateLbl.TabIndex = 23;
            this.DateLbl.Text = "(Date Range:)";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(120, 75);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(110, 13);
            this.DescriptionLbl.TabIndex = 22;
            this.DescriptionLbl.Text = "(Meeting Description:)";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(120, 23);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(78, 13);
            this.NameLbl.TabIndex = 21;
            this.NameLbl.Text = "(meetingName)";
            // 
            // DateRangeLbl
            // 
            this.DateRangeLbl.AutoSize = true;
            this.DateRangeLbl.Location = new System.Drawing.Point(45, 128);
            this.DateRangeLbl.Name = "DateRangeLbl";
            this.DateRangeLbl.Size = new System.Drawing.Size(68, 13);
            this.DateRangeLbl.TabIndex = 20;
            this.DateRangeLbl.Text = "Date Range:";
            // 
            // MeetingDescLbl
            // 
            this.MeetingDescLbl.AutoSize = true;
            this.MeetingDescLbl.Location = new System.Drawing.Point(9, 75);
            this.MeetingDescLbl.Name = "MeetingDescLbl";
            this.MeetingDescLbl.Size = new System.Drawing.Size(104, 13);
            this.MeetingDescLbl.TabIndex = 19;
            this.MeetingDescLbl.Text = "Meeting Description:";
            // 
            // MeetingNameLbl
            // 
            this.MeetingNameLbl.AutoSize = true;
            this.MeetingNameLbl.Location = new System.Drawing.Point(34, 23);
            this.MeetingNameLbl.Name = "MeetingNameLbl";
            this.MeetingNameLbl.Size = new System.Drawing.Size(79, 13);
            this.MeetingNameLbl.TabIndex = 18;
            this.MeetingNameLbl.Text = "Meeting Name:";
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(580, 328);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(145, 31);
            this.HelpBtn.TabIndex = 25;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            // 
            // ParticipantsEditBtn
            // 
            this.ParticipantsEditBtn.Location = new System.Drawing.Point(450, 14);
            this.ParticipantsEditBtn.Name = "ParticipantsEditBtn";
            this.ParticipantsEditBtn.Size = new System.Drawing.Size(57, 31);
            this.ParticipantsEditBtn.TabIndex = 26;
            this.ParticipantsEditBtn.Text = "Edit";
            this.ParticipantsEditBtn.UseVisualStyleBackColor = true;
            // 
            // EditDetailsBtn
            // 
            this.EditDetailsBtn.Location = new System.Drawing.Point(49, 169);
            this.EditDetailsBtn.Name = "EditDetailsBtn";
            this.EditDetailsBtn.Size = new System.Drawing.Size(145, 31);
            this.EditDetailsBtn.TabIndex = 27;
            this.EditDetailsBtn.Text = "Edit Details";
            this.EditDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(540, 91);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(145, 31);
            this.CancelBtn.TabIndex = 28;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(540, 169);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(145, 31);
            this.ConfirmBtn.TabIndex = 29;
            this.ConfirmBtn.Text = "Confirm Edit";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // DateRangeGbx
            // 
            this.DateRangeGbx.Location = new System.Drawing.Point(48, 233);
            this.DateRangeGbx.Name = "DateRangeGbx";
            this.DateRangeGbx.Size = new System.Drawing.Size(459, 126);
            this.DateRangeGbx.TabIndex = 30;
            this.DateRangeGbx.TabStop = false;
            this.DateRangeGbx.Text = "Date Range";
            // 
            // MeetingDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 374);
            this.Controls.Add(this.DateRangeGbx);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditDetailsBtn);
            this.Controls.Add(this.ParticipantsEditBtn);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.CurrentParticipantsLst);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.DateRangeLbl);
            this.Controls.Add(this.MeetingDescLbl);
            this.Controls.Add(this.MeetingNameLbl);
            this.Name = "MeetingDisplay";
            this.Text = "MeetingDisplay";
            this.Load += new System.EventHandler(this.MeetingDisplay_Load);
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
        private System.Windows.Forms.Button ParticipantsEditBtn;
        private System.Windows.Forms.Button EditDetailsBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.GroupBox DateRangeGbx;
    }
}