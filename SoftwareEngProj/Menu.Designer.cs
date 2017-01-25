namespace SoftwareEngProj
{
    partial class Menu
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
            this.MeetingsList = new System.Windows.Forms.ListBox();
            this.MeetingDetails = new System.Windows.Forms.ListBox();
            this.StaffList = new System.Windows.Forms.ListBox();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.MeetingsLabel = new System.Windows.Forms.Label();
            this.MeetingDetailsLabel = new System.Windows.Forms.Label();
            this.StaffLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MeetingsList
            // 
            this.MeetingsList.FormattingEnabled = true;
            this.MeetingsList.Location = new System.Drawing.Point(34, 42);
            this.MeetingsList.Name = "MeetingsList";
            this.MeetingsList.Size = new System.Drawing.Size(145, 147);
            this.MeetingsList.TabIndex = 0;
            // 
            // MeetingDetails
            // 
            this.MeetingDetails.FormattingEnabled = true;
            this.MeetingDetails.Location = new System.Drawing.Point(245, 42);
            this.MeetingDetails.Name = "MeetingDetails";
            this.MeetingDetails.Size = new System.Drawing.Size(145, 147);
            this.MeetingDetails.TabIndex = 1;
            // 
            // StaffList
            // 
            this.StaffList.FormattingEnabled = true;
            this.StaffList.Location = new System.Drawing.Point(448, 42);
            this.StaffList.Name = "StaffList";
            this.StaffList.Size = new System.Drawing.Size(145, 147);
            this.StaffList.TabIndex = 2;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(34, 228);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(145, 31);
            this.Create.TabIndex = 3;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(34, 277);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(144, 31);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(245, 228);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(143, 31);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel meeting";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(469, 287);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(145, 31);
            this.Help.TabIndex = 6;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // MeetingsLabel
            // 
            this.MeetingsLabel.AutoSize = true;
            this.MeetingsLabel.Location = new System.Drawing.Point(35, 13);
            this.MeetingsLabel.Name = "MeetingsLabel";
            this.MeetingsLabel.Size = new System.Drawing.Size(50, 13);
            this.MeetingsLabel.TabIndex = 7;
            this.MeetingsLabel.Text = "Meetings";
            // 
            // MeetingDetailsLabel
            // 
            this.MeetingDetailsLabel.AutoSize = true;
            this.MeetingDetailsLabel.Location = new System.Drawing.Point(242, 13);
            this.MeetingDetailsLabel.Name = "MeetingDetailsLabel";
            this.MeetingDetailsLabel.Size = new System.Drawing.Size(80, 13);
            this.MeetingDetailsLabel.TabIndex = 8;
            this.MeetingDetailsLabel.Text = "Meeting Details";
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.Location = new System.Drawing.Point(447, 13);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(29, 13);
            this.StaffLabel.TabIndex = 9;
            this.StaffLabel.Text = "Staff";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 330);
            this.Controls.Add(this.StaffLabel);
            this.Controls.Add(this.MeetingDetailsLabel);
            this.Controls.Add(this.MeetingsLabel);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.StaffList);
            this.Controls.Add(this.MeetingDetails);
            this.Controls.Add(this.MeetingsList);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MeetingsList;
        private System.Windows.Forms.ListBox MeetingDetails;
        private System.Windows.Forms.ListBox StaffList;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label MeetingsLabel;
        private System.Windows.Forms.Label MeetingDetailsLabel;
        private System.Windows.Forms.Label StaffLabel;
    }
}

