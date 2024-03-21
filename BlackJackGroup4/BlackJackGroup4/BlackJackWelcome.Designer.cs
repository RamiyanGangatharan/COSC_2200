namespace BlackJackGroup4
{
    partial class formBlackJackWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBlackJackWelcome));
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.buttonMultiPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSoundOn = new System.Windows.Forms.Button();
            this.buttonSoundOff = new System.Windows.Forms.Button();
            this.groupBoxMainOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxMainOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(495, 76);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(187, 66);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitle.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(282, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 61);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "BlackJack";
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.Location = new System.Drawing.Point(109, 76);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(187, 66);
            this.buttonSinglePlayer.TabIndex = 1;
            this.buttonSinglePlayer.Text = "Single Player";
            this.buttonSinglePlayer.UseVisualStyleBackColor = true;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSingle_Click);
            this.buttonSinglePlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonSingle_Click);
            // 
            // buttonMultiPlay
            // 
            this.buttonMultiPlay.Location = new System.Drawing.Point(302, 76);
            this.buttonMultiPlay.Name = "buttonMultiPlay";
            this.buttonMultiPlay.Size = new System.Drawing.Size(187, 66);
            this.buttonMultiPlay.TabIndex = 2;
            this.buttonMultiPlay.Text = "Multiplayer ";
            this.buttonMultiPlay.UseVisualStyleBackColor = true;
            this.buttonMultiPlay.Click += new System.EventHandler(this.buttonMultiPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(213, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change buttons to radio buttons/Arrow selection \r\n\r\n";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSettings.BackgroundImage")));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.Location = new System.Drawing.Point(12, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 70);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click_1);
            // 
            // buttonSoundOn
            // 
            this.buttonSoundOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSoundOn.BackgroundImage")));
            this.buttonSoundOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOn.Location = new System.Drawing.Point(93, 12);
            this.buttonSoundOn.Name = "buttonSoundOn";
            this.buttonSoundOn.Size = new System.Drawing.Size(75, 70);
            this.buttonSoundOn.TabIndex = 8;
            this.buttonSoundOn.UseVisualStyleBackColor = true;
            this.buttonSoundOn.Click += new System.EventHandler(this.buttonSoundOn_Click);
            // 
            // buttonSoundOff
            // 
            this.buttonSoundOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSoundOff.BackgroundImage")));
            this.buttonSoundOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOff.Location = new System.Drawing.Point(93, 12);
            this.buttonSoundOff.Name = "buttonSoundOff";
            this.buttonSoundOff.Size = new System.Drawing.Size(75, 70);
            this.buttonSoundOff.TabIndex = 9;
            this.buttonSoundOff.UseVisualStyleBackColor = true;
            this.buttonSoundOff.Visible = false;
            this.buttonSoundOff.Click += new System.EventHandler(this.buttonSoundOff_Click);
            // 
            // groupBoxMainOptions
            // 
            this.groupBoxMainOptions.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMainOptions.Controls.Add(this.buttonSinglePlayer);
            this.groupBoxMainOptions.Controls.Add(this.buttonQuit);
            this.groupBoxMainOptions.Controls.Add(this.label1);
            this.groupBoxMainOptions.Controls.Add(this.buttonMultiPlay);
            this.groupBoxMainOptions.Location = new System.Drawing.Point(12, 138);
            this.groupBoxMainOptions.Name = "groupBoxMainOptions";
            this.groupBoxMainOptions.Size = new System.Drawing.Size(776, 188);
            this.groupBoxMainOptions.TabIndex = 10;
            this.groupBoxMainOptions.TabStop = false;
            this.groupBoxMainOptions.Text = "groupBox1";
            this.groupBoxMainOptions.Enter += new System.EventHandler(this.groupBoxMainOptions_Enter);
            // 
            // formBlackJackWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSoundOn);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSoundOff);
            this.Controls.Add(this.groupBoxMainOptions);
            this.Name = "formBlackJackWelcome";
            this.Text = " Welcome!";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.formBlackJackWelcome_Load);
            this.Enter += new System.EventHandler(this.formBlackJackWelcome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formBlackJackWelcome_Load);
            this.groupBoxMainOptions.ResumeLayout(false);
            this.groupBoxMainOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSinglePlayer;
        private System.Windows.Forms.Button buttonMultiPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSoundOn;
        private System.Windows.Forms.Button buttonSoundOff;
        private System.Windows.Forms.GroupBox groupBoxMainOptions;
    }
}

