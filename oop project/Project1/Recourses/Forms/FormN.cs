using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project1.Recourses.Forms;

namespace Project1.Forms
{
    public partial class FormN : Form
    {
        static string MyName = "Taha";
        static string MyAncestor = "ZZ";
        NN Humanoid2 = new NN(MyName, MyAncestor);
        public FormN()
        {
            InitializeComponent();
        }

        private void btnWriteCode_Click(object sender, EventArgs e)
        {
            Humanoid2.WriteCode();           
            Media.URL = Humanoid2.playMedia;
            lblText.Visible = true;
            lblText.Text = "Hi I'm Humanoid NN my name is " + MyName +
                     "\n and the Ancestor is:" + MyAncestor;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.play();
            

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Media.Ctlcontrols.stop();
        }

        private void btnSocialize_Click(object sender, EventArgs e)
        {
            FormNs form = new FormNs();

            form.ShowDialog();
        }

        private void FormN_Load(object sender, EventArgs e)
        {

        }

        private void Media_Enter(object sender, EventArgs e)
        {

        }
    }
}
