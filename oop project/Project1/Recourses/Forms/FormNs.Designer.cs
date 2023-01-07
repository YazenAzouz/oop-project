
namespace Project1.Recourses.Forms
{
    partial class FormNs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNs));
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Media1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Media1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // Media1
            // 
            this.Media1.Enabled = true;
            this.Media1.Location = new System.Drawing.Point(177, 25);
            this.Media1.Name = "Media1";
            this.Media1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media1.OcxState")));
            this.Media1.Size = new System.Drawing.Size(432, 240);
            this.Media1.TabIndex = 0;
            this.Media1.Enter += new System.EventHandler(this.FormNs_Load);
            // 
            // FormNs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Media1);
            this.Name = "FormNs";
            this.Text = "Socialize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNs_FormClosed);
            this.Load += new System.EventHandler(this.FormNs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer Media1;
    }
}