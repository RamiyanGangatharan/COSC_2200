using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlackJackGroup4
{
    public partial class formBlackJackWelcome : Form
    {
        Theme theme;
        int numPlayers = 0;
        String mode = "";


        public formBlackJackWelcome()
        {
            InitializeComponent();
;           Button_Effects();
            UpdateStartButtonEnabledState();
        }

        private void Button_Effects()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control ctrl in groupBox.Controls)
                    {
                        if (ctrl is GroupBox grpBox)
                        {
                            foreach (Control cntrl in grpBox.Controls)
                            {
                                if (cntrl is Button btn)
                                {
                                    btn.Enter += Button_Enter;
                                    btn.Leave += Button_Leave;
                                }
                            }
                        }
                        else
                        {
                            if (ctrl is Button button)
                            {
                                button.Enter += Button_Enter;
                                button.Leave += Button_Leave;
                            }
                        }

                    }
                }
            }
        }
        private void Button_Enter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
        // Invert button colors
                button.ForeColor = Color.WhiteSmoke;
                button.BackColor = Color.Black;
            }
        }

        // Event handler for button Leave event
        private void Button_Leave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
        // Restore button colors
                button.BackColor = button.ForeColor;
                button.ForeColor = SystemColors.ControlText;
            }
        }


        private void formBlackJackWelcome_Load(object sender, EventArgs e)
        {
           theme = new Theme(this);
        }

        private void buttonMultiPlay_Click(object sender, EventArgs e)
        {
            numPlayers = 2;
            buttonSinglePlayer.Enabled = true;
            buttonMultiPlay.Enabled = false;
            UpdateStartButtonEnabledState();
        }


        private void formBlackJackWelcome_Load(object sender, KeyEventArgs e)
        {

        }


        private void buttonSingle_Click(object sender, EventArgs e)
        {
            numPlayers = 1;
            buttonSinglePlayer.Enabled = false;
            buttonMultiPlay.Enabled = true;
            UpdateStartButtonEnabledState();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonSoundOff_Click(object sender, EventArgs e)
        {
            buttonSoundOn.Visible = true;
            buttonSoundOff.Visible = false;
        }

        private void buttonSoundOn_Click(object sender, EventArgs e)
        {
            buttonSoundOn.Visible = false;
            buttonSoundOff.Visible = true;

        }

        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
            gameSettings settingsMenuForm = new gameSettings(this, theme);
            settingsMenuForm.Show();
            this.Hide();
        }

        private void btnJoker_Click(object sender, EventArgs e)
        {
            mode = "j";
            btnClassic.Enabled = true;
            btnJoker.Enabled = false;
            UpdateStartButtonEnabledState();
        }
        private void btnClassic_Click(object sender, EventArgs e)
        {
            mode = "c";
            btnClassic.Enabled = false;
            btnJoker.Enabled = true;
            UpdateStartButtonEnabledState();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            if (numPlayers == 1 && mode == "c")
            {
                string selectedMusicFilePath = gameSettings.GetSelectedMusicFilePath();
                frmSinglePlayer singlePlayer = new frmSinglePlayer(this, this.BackgroundImage, selectedMusicFilePath);
                singlePlayer.Show();
                this.Hide();
            }
        }
        private void UpdateStartButtonEnabledState()
        {
            btnStart.Enabled = (numPlayers != 0 && !string.IsNullOrEmpty(mode));
        }
    }
}
