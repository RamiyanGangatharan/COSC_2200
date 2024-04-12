namespace BlackJackGroup4
{
    partial class BlackJackWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackWelcome));
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSoundOn = new System.Windows.Forms.Button();
            this.buttonSoundOff = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.buttonMultiPlay = new System.Windows.Forms.Button();
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnJoker = new System.Windows.Forms.Button();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.pnlMenuOptions = new System.Windows.Forms.Panel();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.grpPlayers.SuspendLayout();
            this.grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.pnlMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSettings.BackgroundImage = global::BlackJackGroup4.Properties.Resources.settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.Location = new System.Drawing.Point(12, 11);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(55, 53);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSoundOn
            // 
            this.buttonSoundOn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSoundOn.BackgroundImage = global::BlackJackGroup4.Properties.Resources.sound_on;
            this.buttonSoundOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOn.Location = new System.Drawing.Point(73, 11);
            this.buttonSoundOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSoundOn.Name = "buttonSoundOn";
            this.buttonSoundOn.Size = new System.Drawing.Size(55, 53);
            this.buttonSoundOn.TabIndex = 2;
            this.buttonSoundOn.UseVisualStyleBackColor = false;
            this.buttonSoundOn.Click += new System.EventHandler(this.buttonSoundOn_Click);
            // 
            // buttonSoundOff
            // 
            this.buttonSoundOff.BackgroundImage = global::BlackJackGroup4.Properties.Resources.sound_off;
            this.buttonSoundOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOff.Location = new System.Drawing.Point(73, 11);
            this.buttonSoundOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSoundOff.Name = "buttonSoundOff";
            this.buttonSoundOff.Size = new System.Drawing.Size(55, 53);
            this.buttonSoundOff.TabIndex = 9;
            this.buttonSoundOff.UseVisualStyleBackColor = true;
            this.buttonSoundOff.Visible = false;
            this.buttonSoundOff.Click += new System.EventHandler(this.buttonSoundOff_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(39, 293);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(337, 53);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.Enter += new System.EventHandler(this.Button_Enter);
            this.btnStart.Leave += new System.EventHandler(this.Button_Leave);
            this.btnStart.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.btnStart.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(76, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tab over to change button selection";
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Location = new System.Drawing.Point(127, 350);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(165, 53);
            this.buttonQuit.TabIndex = 15;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonQuit.Enter += new System.EventHandler(this.Button_Enter);
            this.buttonQuit.Leave += new System.EventHandler(this.Button_Leave);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // grpPlayers
            // 
            this.grpPlayers.BackColor = System.Drawing.Color.Transparent;
            this.grpPlayers.Controls.Add(this.buttonMultiPlay);
            this.grpPlayers.Controls.Add(this.buttonSinglePlayer);
            this.grpPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayers.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPlayers.Location = new System.Drawing.Point(21, 101);
            this.grpPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Padding = new System.Windows.Forms.Padding(4);
            this.grpPlayers.Size = new System.Drawing.Size(376, 89);
            this.grpPlayers.TabIndex = 11;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Players";
            // 
            // buttonMultiPlay
            // 
            this.buttonMultiPlay.Enabled = false;
            this.buttonMultiPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonMultiPlay.Location = new System.Drawing.Point(191, 22);
            this.buttonMultiPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMultiPlay.Name = "buttonMultiPlay";
            this.buttonMultiPlay.Size = new System.Drawing.Size(165, 53);
            this.buttonMultiPlay.TabIndex = 1;
            this.buttonMultiPlay.Text = "Two Players";
            this.buttonMultiPlay.UseVisualStyleBackColor = true;
            this.buttonMultiPlay.Enter += new System.EventHandler(this.Button_Enter);
            this.buttonMultiPlay.Leave += new System.EventHandler(this.Button_Leave);
            this.buttonMultiPlay.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonMultiPlay.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinglePlayer.ForeColor = System.Drawing.Color.Black;
            this.buttonSinglePlayer.Location = new System.Drawing.Point(20, 22);
            this.buttonSinglePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(165, 53);
            this.buttonSinglePlayer.TabIndex = 0;
            this.buttonSinglePlayer.Text = "Single Player";
            this.buttonSinglePlayer.UseVisualStyleBackColor = true;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSingle_Click);
            this.buttonSinglePlayer.Enter += new System.EventHandler(this.Button_Enter);
            this.buttonSinglePlayer.Leave += new System.EventHandler(this.Button_Leave);
            this.buttonSinglePlayer.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonSinglePlayer.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // grpMode
            // 
            this.grpMode.BackColor = System.Drawing.Color.Transparent;
            this.grpMode.Controls.Add(this.btnClassic);
            this.grpMode.Controls.Add(this.btnJoker);
            this.grpMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpMode.Location = new System.Drawing.Point(23, 198);
            this.grpMode.Margin = new System.Windows.Forms.Padding(4);
            this.grpMode.Name = "grpMode";
            this.grpMode.Padding = new System.Windows.Forms.Padding(4);
            this.grpMode.Size = new System.Drawing.Size(376, 89);
            this.grpMode.TabIndex = 12;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // btnClassic
            // 
            this.btnClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassic.ForeColor = System.Drawing.Color.Black;
            this.btnClassic.Location = new System.Drawing.Point(21, 22);
            this.btnClassic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(165, 53);
            this.btnClassic.TabIndex = 0;
            this.btnClassic.Text = "Classic";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            this.btnClassic.Enter += new System.EventHandler(this.Button_Enter);
            this.btnClassic.Leave += new System.EventHandler(this.Button_Leave);
            this.btnClassic.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.btnClassic.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // btnJoker
            // 
            this.btnJoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoker.ForeColor = System.Drawing.Color.Black;
            this.btnJoker.Location = new System.Drawing.Point(193, 22);
            this.btnJoker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoker.Name = "btnJoker";
            this.btnJoker.Size = new System.Drawing.Size(165, 53);
            this.btnJoker.TabIndex = 1;
            this.btnJoker.Text = "Joker\'s Revenge";
            this.btnJoker.UseVisualStyleBackColor = true;
            this.btnJoker.Click += new System.EventHandler(this.btnJoker_Click);
            this.btnJoker.Enter += new System.EventHandler(this.Button_Enter);
            this.btnJoker.Leave += new System.EventHandler(this.Button_Leave);
            this.btnJoker.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.btnJoker.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.Image = global::BlackJackGroup4.Properties.Resources.title3;
            this.pbTitle.Location = new System.Drawing.Point(28, 0);
            this.pbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(368, 75);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitle.TabIndex = 16;
            this.pbTitle.TabStop = false;
            // 
            // pnlMenuOptions
            // 
            this.pnlMenuOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuOptions.Controls.Add(this.btnStart);
            this.pnlMenuOptions.Controls.Add(this.pbTitle);
            this.pnlMenuOptions.Controls.Add(this.grpPlayers);
            this.pnlMenuOptions.Controls.Add(this.buttonQuit);
            this.pnlMenuOptions.Controls.Add(this.label1);
            this.pnlMenuOptions.Controls.Add(this.grpMode);
            this.pnlMenuOptions.Location = new System.Drawing.Point(181, 110);
            this.pnlMenuOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenuOptions.Name = "pnlMenuOptions";
            this.pnlMenuOptions.Size = new System.Drawing.Size(421, 406);
            this.pnlMenuOptions.TabIndex = 17;
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTutorial.BackgroundImage = global::BlackJackGroup4.Properties.Resources.tutorial;
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutorial.FlatAppearance.BorderSize = 0;
            this.btnTutorial.Location = new System.Drawing.Point(717, 11);
            this.btnTutorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(55, 53);
            this.btnTutorial.TabIndex = 18;
            this.btnTutorial.UseVisualStyleBackColor = false;
            // 
            // BlackJackWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGroup4.Properties.Resources.vegas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 578);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.buttonSoundOn);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSoundOff);
            this.Controls.Add(this.pnlMenuOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(802, 625);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(802, 625);
            this.Name = "BlackJackWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Welcome!";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.BlackJackWelcome_Load);
            this.Enter += new System.EventHandler(this.BlackJackWelcome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlackJackWelcome_Load);
            this.grpPlayers.ResumeLayout(false);
            this.grpMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.pnlMenuOptions.ResumeLayout(false);
            this.pnlMenuOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSoundOn;
        private System.Windows.Forms.Button buttonSoundOff;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.Button buttonMultiPlay;
        private System.Windows.Forms.Button buttonSinglePlayer;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnJoker;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Panel pnlMenuOptions;
        private System.Windows.Forms.Button btnTutorial;
    }
}

