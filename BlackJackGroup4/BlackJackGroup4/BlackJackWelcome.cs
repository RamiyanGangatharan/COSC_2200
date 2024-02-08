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
    }
}
