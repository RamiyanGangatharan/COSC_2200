using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public partial class frmSinglePlayer : Form
    {
        private formBlackJackWelcome mainMenu;
        private Theme theme;
        private Deck deck;
        private Card drawnCard;

        // Track original size of the button
        private Size originalButtonSize;

        // Constructor to receive the theme instance
        public frmSinglePlayer(formBlackJackWelcome mainMenuForm, Image backgroundImage, string musicPath)
        {
            InitializeComponent();
            this.theme = new Theme(this, backgroundImage, musicPath);
            pictureBox.Parent = this;
            button1.Parent = pictureBox;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, Color.LightBlue);
            button1.BackColor = Color.FromArgb(115, Color.WhiteSmoke);

        // Store the original size of the button
            originalButtonSize = button1.Size;

        // Subscribe to MouseEnter and MouseLeave events for button
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            deck = new Deck();
            mainMenu = mainMenuForm;
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {
            deck.Shuffle();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (drawnCard != null)
            {
                MessageBox.Show($"Drawn card: {drawnCard}");
            }
            else
            {
                MessageBox.Show("No card has been drawn yet.");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

           drawnCard = deck.Deal();

        // Display the card's image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = drawnCard.Image;

        // Print the name of the card to the console
            Console.WriteLine($"Drawn card: {drawnCard}");

            if (deck.IsEmpty())
            {
                deck.Reset();
                deck.Shuffle();
            }
        }

        // Event handler for mouse entering the button
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
        // Adjust the size of the button to create a zoom effect (10%)
            button1.Size = new Size((int)(originalButtonSize.Width * 1.1), (int)(originalButtonSize.Height * 1.1));
        }

        // Event handler for mouse leaving the button
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
        // Restore the original size of the button
            button1.Size = originalButtonSize;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
        }
    }
}
