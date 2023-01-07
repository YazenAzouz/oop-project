using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1.Forms
{
    public partial class FormZ : Form
    {
        private bool btnSpeakClicked = false;
        static string MyName = "de Gea";
        static string MyAncestor = "";
        ZZ Humanoid3 = new ZZ(MyName, MyAncestor);
        public FormZ()
        {
            InitializeComponent();
            btnSing.Enabled = false;
            btnDance.Enabled = false;
        }

        private void btnSocialize_Click(object sender, EventArgs e)
        {
            if (btnSocialize.Enabled)
            {
                btnSing.Enabled = true;
                btnDance.Enabled = true;
            }
            else
            {
                btnSing.Enabled = false;
                btnDance.Enabled = false;
            }

           
        }
        private void btnDance_Click(object sender, EventArgs e)
        {
            Humanoid3.Dance();
            Media.URL = Humanoid3.Mediaplay;
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            Humanoid3.Sing();
            Media.URL = Humanoid3.Mediaplay;
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            Humanoid3.Speak();
            Media.URL = Humanoid3.Mediaplay;
            btnSpeakClicked = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Media.URL = Humanoid3.Mediaplay;
            this.Media.Ctlcontrols.play();
            lblText.Visible = false;
            if (btnSpeakClicked)
            {
                lblText.Visible = true;
                lblText.Text = "Hi I'm Humanoid ZZ my name is " + MyName +
                    " and I speak French \n " +
                      "I don't have Ancestors";
            }
            else
                lblText.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.stop();
        }

        private void FormZ_Load(object sender, EventArgs e)
        {

        }

       
    }
}
