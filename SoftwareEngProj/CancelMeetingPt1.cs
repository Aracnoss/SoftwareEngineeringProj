using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngProj
{
    public partial class CancelMeetingPt1 : Form
    {
        public CancelMeetingPt1()
        {
            InitializeComponent();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            CancelMeetingPt2 cm2 = new CancelMeetingPt2();
            cm2.Show();
            Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
