namespace SoftwareEngProj
{
    partial class CreatingPt4
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
            this.DateRangeLbl = new System.Windows.Forms.Label();
            this.MeetingDescLbl = new System.Windows.Forms.Label();
            this.MeetingNameLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.CurrentParticipantsLst = new System.Windows.Forms.ListBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.StartOverBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateRangeLbl
            // 
            this.DateRangeLbl.AutoSize = true;
            this.DateRangeLbl.Location = new System.Drawing.Point(60, 214);
            this.DateRangeLbl.Name = "DateRangeLbl";
            this.DateRangeLbl.Size = new System.Drawing.Size(68, 13);
            this.DateRangeLbl.TabIndex = 13;
            this.DateRangeLbl.Text = "Date Range:";
            // 
            // MeetingDescLbl
            // 
            this.MeetingDescLbl.AutoSize = true;
            this.MeetingDescLbl.Location = new System.Drawing.Point(24, 161);
            this.MeetingDescLbl.Name = "MeetingDescLbl";
            this.MeetingDescLbl.Size = new System.Drawing.Size(104, 13);
            this.MeetingDescLbl.TabIndex = 12;
            this.MeetingDescLbl.Text = "Meeting Description:";
            // 
            // MeetingNameLbl
            // 
            this.MeetingNameLbl.AutoSize = true;
            this.MeetingNameLbl.Location = new System.Drawing.Point(49, 109);
            this.MeetingNameLbl.Name = "MeetingNameLbl";
            this.MeetingNameLbl.Size = new System.Drawing.Size(79, 13);
            this.MeetingNameLbl.TabIndex = 11;
            this.MeetingNameLbl.Text = "Meeting Name:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(135, 214);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(74, 13);
            this.DateLbl.TabIndex = 16;
            this.DateLbl.Text = "(Date Range:)";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(135, 161);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(110, 13);
            this.DescriptionLbl.TabIndex = 15;
            this.DescriptionLbl.Text = "(Meeting Description:)";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(135, 109);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(78, 13);
            this.NameLbl.TabIndex = 14;
            this.NameLbl.Text = "(meetingName)";
            // 
            // CurrentParticipantsLst
            // 
            this.CurrentParticipantsLst.FormattingEnabled = true;
            this.CurrentParticipantsLst.Location = new System.Drawing.Point(269, 74);
            this.CurrentParticipantsLst.Name = "CurrentParticipantsLst";
            this.CurrentParticipantsLst.Size = new System.Drawing.Size(192, 199);
            this.CurrentParticipantsLst.TabIndex = 17;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(577, 313);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(145, 31);
            this.HelpBtn.TabIndex = 18;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            // 
            // StartOverBtn
            // 
            this.StartOverBtn.Location = new System.Drawing.Point(533, 196);
            this.StartOverBtn.Name = "StartOverBtn";
            this.StartOverBtn.Size = new System.Drawing.Size(145, 31);
            this.StartOverBtn.TabIndex = 19;
            this.StartOverBtn.Text = "Start Over";
            this.StartOverBtn.UseVisualStyleBackColor = true;
            this.StartOverBtn.Click += new System.EventHandler(this.StartOverBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(533, 118);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(145, 31);
            this.CreateBtn.TabIndex = 20;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CreatingPt4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 356);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.StartOverBtn);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.CurrentParticipantsLst);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.DateRangeLbl);
            this.Controls.Add(this.MeetingDescLbl);
            this.Controls.Add(this.MeetingNameLbl);
            this.Name = "CreatingPt4";
            this.Text = "CreatingPt4";
            this.Load += new System.EventHandler(this.CreatingPt4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateRangeLbl;
        private System.Windows.Forms.Label MeetingDescLbl;
        private System.Windows.Forms.Label MeetingNameLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ListBox CurrentParticipantsLst;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button StartOverBtn;
        private System.Windows.Forms.Button CreateBtn;
    }
}