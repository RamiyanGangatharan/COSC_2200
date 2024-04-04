﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public partial class gameSettings : Form
    {
        private formBlackJackWelcome mainMenu;
        private Image selectedBackground;
        private static string selectedMusicFilePath;
        private Theme theme;

        public gameSettings(formBlackJackWelcome mainMenuForm, Theme theme)
        {
            InitializeComponent();
            mainMenu = mainMenuForm;
            this.theme = theme;
            SetInitialSettings();
        }
        private void SetInitialSettings()
        {
            // Retrieve the current background and music from the theme
            selectedBackground = mainMenu.BackgroundImage;

            // Set the background image on the form
            this.BackgroundImage = selectedBackground;

            // Apply the current theme to the form
            theme.ApplyTheme(selectedBackground, selectedMusicFilePath);
        }

        private void gameSettings_Load(object sender, EventArgs e)
        {
        }
        private void btnVegasImg_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.vegas;
            selectedBackground = Properties.Resources.vegas;
            selectedMusicFilePath = "blackjack.wav";
            ApplySettings();
        }

        private void btnParisImg_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.paris;
            selectedBackground = Properties.Resources.paris;
            selectedMusicFilePath = "france.wav";
            ApplySettings();
        }

        private void btnNiagaraImg_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.niagara;
            selectedBackground = Properties.Resources.niagara;
            selectedMusicFilePath = "canada.wav";
            ApplySettings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the formBlackJackWelcome form
            if (mainMenu != null)
            {
            // Pass the selected background image and music file path to Theme.ApplyTheme
                //Theme theme = new Theme(mainMenu);
                theme.ApplyTheme(selectedBackground, selectedMusicFilePath);
                mainMenu.Show();
            }
        }

        private void ApplySettings()
        {
            // Set the background image and play the selected music
            Theme theme = new Theme(mainMenu);
            theme.ApplyTheme(selectedBackground, selectedMusicFilePath);
        }
        public static string GetSelectedMusicFilePath()
        {
            return selectedMusicFilePath;
        }
    }
}
