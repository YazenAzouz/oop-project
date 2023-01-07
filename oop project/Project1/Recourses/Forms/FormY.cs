using System;
using System.Windows.Forms;


namespace Project1.Forms
{
    public partial class FormY : Form
    {
        private bool btnSpeakClicked = false;
        static string MyName = "Pablo";
        static string MyAncestor = "";
        YY Humanoid1 = new YY(MyName, MyAncestor );
        public FormY()
        {

          

            InitializeComponent();

            btnSing.Enabled = false;
            btnSpeak.Enabled = false;

        }
       

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            Humanoid1.Speak();
            Media.URL = Humanoid1.Media;
             btnSpeakClicked = true;

        }


        private void FormY_Load(object sender, EventArgs e)
        {
            Media.settings.autoStart = false;
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            Humanoid1.Sing();
            Media.URL = Humanoid1.Media;
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            Humanoid1.Eat();
            Media.URL = Humanoid1.Media;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Media.URL = Humanoid1.Media;
            this.Media.Ctlcontrols.play();
            lblText.Visible = false;
            if (btnSpeakClicked)
            {
                lblText.Visible = true;
                lblText.Text = "Hi I'm Humanoid YY my name is "+ MyName +
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

        private void btnSocialize_Click(object sender, EventArgs e)
        {
            if (btnSocialize.Enabled)
            {
                btnSing.Enabled = true;
                btnSpeak.Enabled = true;
            }
            else
            {
                btnSing.Enabled = false;
                btnSpeak.Enabled = false;
            }
        }
    }
    
}
