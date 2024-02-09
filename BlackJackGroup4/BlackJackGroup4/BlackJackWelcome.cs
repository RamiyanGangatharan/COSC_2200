using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlackJackGroup4
{
    public partial class formBlackJackWelcome : Form
    {
   
        


        public formBlackJackWelcome()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enables the form to receive key events before the event is passed to the control that has focus
            this.PreviewKeyDown += formBlackJackWelcome_Load;
            //groupBoxMainOptions.KeyDown += groupBoxMainOptions_KeyDown;

        }

        private void formBlackJackWelcome_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonMultiPlay_Click(object sender, EventArgs e)
        {
            multiPlayerSettings gameMenuForm = new multiPlayerSettings();
            gameMenuForm.Show();

            this.Hide();
        }

        private void buttonSingle_Click(object sender, KeyPressEventArgs e)
        {

        }

        private void formBlackJackWelcome_Load(object sender, KeyEventArgs e)
        {
            
        }


        private void buttonSingle_Click(object sender, EventArgs e)
        {

        }


        private void buttonSettings_MouseEnter(object sender, EventArgs e)
        {
           
            
        }

        private void buttonSettings_MouseLeave(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
           
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
            gameSettings settingsMenuForm = new gameSettings();
            settingsMenuForm.Show();
            this.Hide();
        }

        private void groupBoxMainOptions_Enter(object sender, EventArgs e)
        {

        }
    }
}
