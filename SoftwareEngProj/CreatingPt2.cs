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
    public partial class CreatingPt2 : Form
    {
        public CreatingPt2()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            CreatingPt3 cp3 = new CreatingPt3();
            cp3.Show();
            Close();
        }

        private void CreatingPt2_Load(object sender, EventArgs e)
        {

        }
    }
}
