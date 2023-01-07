using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Recourses.Forms
{
    public partial class FormNs : Form
    {
        public FormNs()
        {
            InitializeComponent();
        }

        private void FormNs_Load(object sender, EventArgs e)
        {

        }

        private void FormNs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Media1.Ctlcontrols.stop();
        }
    }
}
