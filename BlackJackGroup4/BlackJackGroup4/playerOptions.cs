using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGroup4
{
    internal class playerOptions
    {
        // Array to store player options
        public static readonly string[] options1 = { "CPU", "Player2" };

        public static readonly string[] options2 = { "CPU", "Player3", "Player4" };

        // Property to get the player options
        public static string[] Options
        {
            get { return options1; }
        }

        // Method to set options for a ComboBox
        //public static void SetComboBoxOptions1(ComboBox comboBox)
        //{
        //    comboBox.Items.Clear();  // Clear existing items

        //    foreach (string option1 in options1)
        //    {
        //        if (!comboBox.Items.Contains(option1))
        //        {
        //            comboBox.Items.Add(option1);
        //        }
        //    }
        //}

        //public static void SetComboBoxOptions2(ComboBox comboBox)
        //{
        //    comboBox.Items.Clear();  // Clear existing items

        //    foreach (string option2 in options2)
        //    {
        //        if (!comboBox.Items.Contains(option2))
        //        {
        //            comboBox.Items.Add(option2);
        //        }
        //    }
        //}
    }
}
