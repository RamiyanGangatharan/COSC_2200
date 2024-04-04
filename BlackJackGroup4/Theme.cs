using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public class Theme
    {
        private Form form; // Instance variable to hold the form

        public Theme(Form form)
        {
            this.form = form;
            ApplyDefaultTheme(); // Apply default theme when instantiated
        }

        public Theme(Form form, Image backgroundImage, string musicPath)
        {
            this.form = form;
            ApplyTheme(backgroundImage, musicPath); // Allow user to set custom theme
        }

        public void ApplyTheme(Image backgroundImage, string musicPath)
        {
            // Set background image
            if (backgroundImage != null)
            {
                form.BackgroundImage = backgroundImage;
                form.BackgroundImageLayout = ImageLayout.Stretch;
            }

            // Play background music
            if (!string.IsNullOrEmpty(musicPath) && System.IO.File.Exists(musicPath))
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(musicPath);
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing background music: " + ex.Message);
                }
            }
        }

        public void ApplyDefaultTheme()
        {
            // Set default image and music paths here
            Image defaultBackground = Properties.Resources.vegas; // Default background image
            string defaultMusicPath = "blackjack.wav"; // Default music path
            ApplyTheme(defaultBackground, defaultMusicPath);
        }

    }
}
