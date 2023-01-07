
namespace Project1.Forms
{
    partial class FormZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZ));
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.lblText = new System.Windows.Forms.Label();
            this.btnDance = new FontAwesome.Sharp.IconButton();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSing = new FontAwesome.Sharp.IconButton();
            this.btnSpeak = new FontAwesome.Sharp.IconButton();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.btnPause = new FontAwesome.Sharp.IconButton();
            this.btnSocialize = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.Purple;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 20;
            this.btnPlay.Location = new System.Drawing.Point(128, 251);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 23);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.lblText.Location = new System.Drawing.Point(124, 287);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 19);
            this.lblText.TabIndex = 14;
            // 
            // btnDance
            // 
            this.btnDance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDance.ForeColor = System.Drawing.Color.Black;
            this.btnDance.IconChar = FontAwesome.Sharp.IconChar.HandsClapping;
            this.btnDance.IconColor = System.Drawing.Color.Purple;
            this.btnDance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDance.IconSize = 20;
            this.btnDance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDance.Location = new System.Drawing.Point(12, 130);
            this.btnDance.Name = "btnDance";
            this.btnDance.Size = new System.Drawing.Size(101, 32);
            this.btnDance.TabIndex = 13;
            this.btnDance.Text = "Dance";
            this.btnDance.UseVisualStyleBackColor = true;
            this.btnDance.Click += new System.EventHandler(this.btnDance_Click);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(128, 10);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(456, 234);
            this.Media.TabIndex = 12;
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
            this.btnSing.Location = new System.Drawing.Point(12, 188);
            this.btnSing.Name = "btnSing";
            this.btnSing.Size = new System.Drawing.Size(101, 26);
            this.btnSing.TabIndex = 11;
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
            this.btnSpeak.Location = new System.Drawing.Point(12, 40);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(101, 32);
            this.btnSpeak.TabIndex = 10;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnStop.IconColor = System.Drawing.Color.Purple;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.IconSize = 20;
            this.btnStop.Location = new System.Drawing.Point(195, 252);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(22, 20);
            this.btnStop.TabIndex = 17;
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
            this.btnPause.Location = new System.Drawing.Point(167, 252);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(22, 20);
            this.btnPause.TabIndex = 16;
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
            this.btnSocialize.Location = new System.Drawing.Point(14, 89);
            this.btnSocialize.Name = "btnSocialize";
            this.btnSocialize.Size = new System.Drawing.Size(99, 26);
            this.btnSocialize.TabIndex = 18;
            this.btnSocialize.Text = "Socialize";
            this.btnSocialize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocialize.UseVisualStyleBackColor = true;
            this.btnSocialize.Click += new System.EventHandler(this.btnSocialize_Click);
            // 
            // FormZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(663, 317);
            this.Controls.Add(this.btnSocialize);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnDance);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.btnSing);
            this.Controls.Add(this.btnSpeak);
            this.Name = "FormZ";
            this.Text = "FormZ";
            this.Load += new System.EventHandler(this.FormZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Label lblText;
        private FontAwesome.Sharp.IconButton btnDance;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private FontAwesome.Sharp.IconButton btnSing;
        private FontAwesome.Sharp.IconButton btnSpeak;
        private FontAwesome.Sharp.IconButton btnStop;
        private FontAwesome.Sharp.IconButton btnPause;
        private FontAwesome.Sharp.IconButton btnSocialize;
    }
}