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
    public partial class CreatingPt1 : Form
    {
        Meeting temp;
        public CreatingPt1()
        {
            InitializeComponent();
            temp = new Meeting();
        }

        private void CreatingPt1_Load(object sender, EventArgs e)
        {
        }

        private void Create_Click(object sender, EventArgs e)
        {
            //Save the data in the window
            temp.meetingName = MeetingNameTxt.Text;
            temp.meetingDesc = MeetingDescTxt.Text;
            //close the current window.
            CreatingPt2 cp2 = new CreatingPt2();
            cp2.Show();
            Close();            
        }
    }
}
