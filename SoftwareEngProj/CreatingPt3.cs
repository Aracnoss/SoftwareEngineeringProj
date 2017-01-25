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
    public partial class CreatingPt3 : Form
    {
        public CreatingPt3()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CreatingPt4 cp4 = new CreatingPt4();
            cp4.Show();
            Close();
        }

        private void CreatingPt3_Load(object sender, EventArgs e)
        {

        }
    }
}
