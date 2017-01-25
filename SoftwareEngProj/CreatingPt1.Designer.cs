namespace SoftwareEngProj
{
    partial class CreatingPt1
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
            this.MeetingNameLbl = new System.Windows.Forms.Label();
            this.MeetingDescLbl = new System.Windows.Forms.Label();
            this.DateRangeLbl = new System.Windows.Forms.Label();
            this.MeetingNameTxt = new System.Windows.Forms.TextBox();
            this.MeetingDescTxt = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ToLbl = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeetingNameLbl
            // 
            this.MeetingNameLbl.AutoSize = true;
            this.MeetingNameLbl.Location = new System.Drawing.Point(50, 46);
            this.MeetingNameLbl.Name = "MeetingNameLbl";
            this.MeetingNameLbl.Size = new System.Drawing.Size(79, 13);
            this.MeetingNameLbl.TabIndex = 8;
            this.MeetingNameLbl.Text = "Meeting Name:";
            // 
            // MeetingDescLbl
            // 
            this.MeetingDescLbl.AutoSize = true;
            this.MeetingDescLbl.Location = new System.Drawing.Point(50, 98);
            this.MeetingDescLbl.Name = "MeetingDescLbl";
            this.MeetingDescLbl.Size = new System.Drawing.Size(104, 13);
            this.MeetingDescLbl.TabIndex = 9;
            this.MeetingDescLbl.Text = "Meeting Description:";
            // 
            // DateRangeLbl
            // 
            this.DateRangeLbl.AutoSize = true;
            this.DateRangeLbl.Location = new System.Drawing.Point(50, 151);
            this.DateRangeLbl.Name = "DateRangeLbl";
            this.DateRangeLbl.Size = new System.Drawing.Size(68, 13);
            this.DateRangeLbl.TabIndex = 10;
            this.DateRangeLbl.Text = "Date Range:";
            // 
            // MeetingNameTxt
            // 
            this.MeetingNameTxt.Location = new System.Drawing.Point(240, 46);
            this.MeetingNameTxt.Name = "MeetingNameTxt";
            this.MeetingNameTxt.Size = new System.Drawing.Size(383, 20);
            this.MeetingNameTxt.TabIndex = 11;
            // 
            // MeetingDescTxt
            // 
            this.MeetingDescTxt.Location = new System.Drawing.Point(240, 95);
            this.MeetingDescTxt.Name = "MeetingDescTxt";
            this.MeetingDescTxt.Size = new System.Drawing.Size(383, 20);
            this.MeetingDescTxt.TabIndex = 12;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(53, 238);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(145, 31);
            this.Create.TabIndex = 13;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(383, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(240, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(383, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(422, 197);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(16, 13);
            this.ToLbl.TabIndex = 16;
            this.ToLbl.Text = "to";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(511, 279);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(145, 31);
            this.Help.TabIndex = 17;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // CreatingPt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 322);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.ToLbl);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.MeetingDescTxt);
            this.Controls.Add(this.MeetingNameTxt);
            this.Controls.Add(this.DateRangeLbl);
            this.Controls.Add(this.MeetingDescLbl);
            this.Controls.Add(this.MeetingNameLbl);
            this.Name = "CreatingPt1";
            this.Text = "Create Meeting";
            this.Load += new System.EventHandler(this.CreatingPt1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeetingNameLbl;
        private System.Windows.Forms.Label MeetingDescLbl;
        private System.Windows.Forms.Label DateRangeLbl;
        private System.Windows.Forms.TextBox MeetingNameTxt;
        private System.Windows.Forms.TextBox MeetingDescTxt;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Button Help;
    }
}