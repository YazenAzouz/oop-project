using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1.Forms
{
    public partial class FormD : Form
    {
        static string MyName = "Miguel";
        static string MyAncestor = "NN";
        DD Humanoid4 = new DD(MyName, MyAncestor);
        public FormD()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.play();
        }

        private void btnSnore_Click(object sender, EventArgs e)
        {
            Humanoid4.Snore();
            Media.URL = Humanoid4.mdPlay;
            lblText.Visible = true;
            lblText.Text = "Hi I'm Humanoid DD my name is " + MyName +
                                  "\n and Ancestor is:"+MyAncestor;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.stop();
        }

        private void FormD_Load(object sender, EventArgs e)
        {

        }
    }
}
