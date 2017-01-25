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
    public partial class CreatingPt4 : Form
    {
        public CreatingPt4()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            MeetingDisplay mtd = new MeetingDisplay();
            mtd.Show();
            Close();
        }

        private void StartOverBtn_Click(object sender, EventArgs e)
        {
            CreatingPt1 cp1 = new CreatingPt1();
            cp1.Show();
            Close();
        }

        private void CreatingPt4_Load(object sender, EventArgs e)
        {

        }
    }
}
