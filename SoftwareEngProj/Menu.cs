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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreatingPt1 cp1 = new CreatingPt1();
            cp1.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelMeetingPt1 cm1 = new CancelMeetingPt1();
            cm1.Show();            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MeetingDisplay mtd = new MeetingDisplay();
            mtd.Show();
        }
    }
}
