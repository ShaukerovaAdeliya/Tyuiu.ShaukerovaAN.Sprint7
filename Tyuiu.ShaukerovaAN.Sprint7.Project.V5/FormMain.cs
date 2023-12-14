using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }
        
        private void buttonHelp_SAN_Click(object sender, EventArgs e)
        {
            FormAbout_SAN formAbout = new FormAbout_SAN();
            formAbout.ShowDialog();
        }

        private void buttonHelp_SAN_MouseEnter(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Hand;
        }
        private void buttonHelp_SAN_MouseLeave(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Default;
        }

    }
}
