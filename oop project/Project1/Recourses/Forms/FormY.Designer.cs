
namespace Project1.Forms
{
    partial class FormY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormY));
            this.btnSing = new FontAwesome.Sharp.IconButton();
            this.btnSpeak = new FontAwesome.Sharp.IconButton();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEat = new FontAwesome.Sharp.IconButton();
            this.lblText = new System.Windows.Forms.Label();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.btnPause = new FontAwesome.Sharp.IconButton();
            this.btnSocialize = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSing
            // 
            this.btnSing.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSing.ForeColor = System.Drawing.Color.Black;
            this.btnSing.IconChar = FontAwesome.Sharp.IconChar.MicrophoneAlt;
            this.btnSing.IconColor = System.Drawing.Color.Purple;
            this.btnSing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSing.IconSize = 20;
            this.btnSing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSing.Location = new System.Drawing.Point(14, 74);
            this.btnSing.Name = "btnSing";
            this.btnSing.Size = new System.Drawing.Size(100, 26);
            this.btnSing.TabIndex = 5;
            this.btnSing.Text = "Sing";
            this.btnSing.UseVisualStyleBackColor = true;
            this.btnSing.Click += new System.EventHandler(this.btnSing_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.ForeColor = System.Drawing.Color.Black;
            this.btnSpeak.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.btnSpeak.IconColor = System.Drawing.Color.Purple;
            this.btnSpeak.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSpeak.IconSize = 20;
            this.btnSpeak.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpeak.Location = new System.Drawing.Point(13, 125);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(100, 32);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(128, 12);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(456, 234);
            this.Media.TabIndex = 6;
            // 
            // btnEat
            // 
            this.btnEat.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEat.ForeColor = System.Drawing.Color.Black;
            this.btnEat.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.btnEat.IconColor = System.Drawing.Color.Purple;
            this.btnEat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEat.IconSize = 20;
            this.btnEat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEat.Location = new System.Drawing.Point(13, 187);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(100, 24);
            this.btnEat.TabIndex = 7;
            this.btnEat.Text = "Eat";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.lblText.Location = new System.Drawing.Point(124, 289);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 19);
            this.lblText.TabIndex = 8;
            // 
            // btnPlay
            // 
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.Purple;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 20;
            this.btnPlay.Location = new System.Drawing.Point(128, 253);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnStop.IconColor = System.Drawing.Color.Purple;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.IconSize = 20;
            this.btnStop.Location = new System.Drawing.Point(195, 254);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(22, 20);
            this.btnStop.TabIndex = 11;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPause.IconChar = FontAwesome.Sharp.IconChar.PauseCircle;
            this.btnPause.IconColor = System.Drawing.Color.Purple;
            this.btnPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPause.IconSize = 20;
            this.btnPause.Location = new System.Drawing.Point(167, 254);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(22, 20);
            this.btnPause.TabIndex = 10;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSocialize
            // 
            this.btnSocialize.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocialize.ForeColor = System.Drawing.Color.Black;
            this.btnSocialize.IconChar = FontAwesome.Sharp.IconChar.MicrophoneAlt;
            this.btnSocialize.IconColor = System.Drawing.Color.Purple;
            this.btnSocialize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSocialize.IconSize = 20;
            this.btnSocialize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocialize.Location = new System.Drawing.Point(14, 28);
            this.btnSocialize.Name = "btnSocialize";
            this.btnSocialize.Size = new System.Drawing.Size(99, 26);
            this.btnSocialize.TabIndex = 12;
            this.btnSocialize.Text = "Socialize";
            this.btnSocialize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocialize.UseVisualStyleBackColor = true;
            this.btnSocialize.Click += new System.EventHandler(this.btnSocialize_Click);
            // 
            // FormY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(596, 317);
            this.Controls.Add(this.btnSocialize);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.btnSing);
            this.Controls.Add(this.btnSpeak);
            this.Name = "FormY";
            this.Text = "FormY";
            this.Load += new System.EventHandler(this.FormY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSing;
        private FontAwesome.Sharp.IconButton btnSpeak;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private FontAwesome.Sharp.IconButton btnEat;
        private System.Windows.Forms.Label lblText;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnStop;
        private FontAwesome.Sharp.IconButton btnPause;
        private FontAwesome.Sharp.IconButton btnSocialize;
    }
}