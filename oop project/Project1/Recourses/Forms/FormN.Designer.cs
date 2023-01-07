
namespace Project1.Forms
{
    partial class FormN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormN));
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSocialize = new FontAwesome.Sharp.IconButton();
            this.btnWriteCode = new FontAwesome.Sharp.IconButton();
            this.lblText = new System.Windows.Forms.Label();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.btnPause = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.Purple;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 20;
            this.btnPlay.Location = new System.Drawing.Point(128, 267);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 23);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(128, 26);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(456, 234);
            this.Media.TabIndex = 12;
            this.Media.Enter += new System.EventHandler(this.Media_Enter);
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
            this.btnSocialize.Location = new System.Drawing.Point(12, 104);
            this.btnSocialize.Name = "btnSocialize";
            this.btnSocialize.Size = new System.Drawing.Size(99, 26);
            this.btnSocialize.TabIndex = 11;
            this.btnSocialize.Text = "Socialize";
            this.btnSocialize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocialize.UseVisualStyleBackColor = true;
            this.btnSocialize.Click += new System.EventHandler(this.btnSocialize_Click);
            // 
            // btnWriteCode
            // 
            this.btnWriteCode.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteCode.ForeColor = System.Drawing.Color.Black;
            this.btnWriteCode.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.btnWriteCode.IconColor = System.Drawing.Color.Purple;
            this.btnWriteCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWriteCode.IconSize = 20;
            this.btnWriteCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWriteCode.Location = new System.Drawing.Point(13, 56);
            this.btnWriteCode.Name = "btnWriteCode";
            this.btnWriteCode.Size = new System.Drawing.Size(99, 32);
            this.btnWriteCode.TabIndex = 10;
            this.btnWriteCode.Text = "Writecode";
            this.btnWriteCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteCode.UseVisualStyleBackColor = true;
            this.btnWriteCode.Click += new System.EventHandler(this.btnWriteCode_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblText.Location = new System.Drawing.Point(163, 293);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 19);
            this.lblText.TabIndex = 15;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnStop.IconColor = System.Drawing.Color.Purple;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.IconSize = 20;
            this.btnStop.Location = new System.Drawing.Point(199, 268);
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
            this.btnPause.Location = new System.Drawing.Point(171, 268);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(22, 20);
            this.btnPause.TabIndex = 16;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // FormN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(596, 317);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.btnSocialize);
            this.Controls.Add(this.btnWriteCode);
            this.Name = "FormN";
            this.Text = "FormN";
            this.Load += new System.EventHandler(this.FormN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private FontAwesome.Sharp.IconButton btnSocialize;
        private FontAwesome.Sharp.IconButton btnWriteCode;
        private System.Windows.Forms.Label lblText;
        private FontAwesome.Sharp.IconButton btnStop;
        private FontAwesome.Sharp.IconButton btnPause;
    }
}