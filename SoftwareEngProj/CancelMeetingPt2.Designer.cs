namespace SoftwareEngProj
{
    partial class CancelMeetingPt2
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
            this.MeetingCancelledLbl = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeetingCancelledLbl
            // 
            this.MeetingCancelledLbl.AutoSize = true;
            this.MeetingCancelledLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingCancelledLbl.Location = new System.Drawing.Point(199, 146);
            this.MeetingCancelledLbl.Name = "MeetingCancelledLbl";
            this.MeetingCancelledLbl.Size = new System.Drawing.Size(279, 37);
            this.MeetingCancelledLbl.TabIndex = 0;
            this.MeetingCancelledLbl.Text = "Meeting Cancelled";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(266, 233);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(145, 31);
            this.OkBtn.TabIndex = 33;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelMeetingPt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 431);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.MeetingCancelledLbl);
            this.Name = "CancelMeetingPt2";
            this.Text = "CancelMeetingPt2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeetingCancelledLbl;
        private System.Windows.Forms.Button OkBtn;
    }
}