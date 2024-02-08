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
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.buttonMultiPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(35, 281);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(89, 66);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(329, 281);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(187, 66);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
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
            // buttonSingle
            // 
            this.buttonSingle.Location = new System.Drawing.Point(329, 137);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(187, 66);
            this.buttonSingle.TabIndex = 3;
            this.buttonSingle.Text = "Single Player";
            this.buttonSingle.UseVisualStyleBackColor = true;
            // 
            // buttonMultiPlay
            // 
            this.buttonMultiPlay.Location = new System.Drawing.Point(329, 209);
            this.buttonMultiPlay.Name = "buttonMultiPlay";
            this.buttonMultiPlay.Size = new System.Drawing.Size(187, 66);
            this.buttonMultiPlay.TabIndex = 4;
            this.buttonMultiPlay.Text = "Multiplayer ";
            this.buttonMultiPlay.UseVisualStyleBackColor = true;
            this.buttonMultiPlay.Click += new System.EventHandler(this.buttonMultiPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Icon here to button";
            // 
            // formBlackJackWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMultiPlay);
            this.Controls.Add(this.buttonSingle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSettings);
            this.Name = "formBlackJackWelcome";
            this.Text = "Welcome To Black Jack!";
            this.Load += new System.EventHandler(this.formBlackJackWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.Button buttonMultiPlay;
        private System.Windows.Forms.Label label2;
    }
}

