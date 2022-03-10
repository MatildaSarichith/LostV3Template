using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }


            /// Display text and game options to screen based on the 
            /// current page

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 99;
            }


            /// Display text and game options to screen based on the 
            /// current page

        }

        public void DisplayPage()
        {
            outputLabel.Text = "You are lost in a forest";
            option1Label.Text = "Go north";
            option2Label.Text = "Go south";

            imageBox.Image = Properties.Resources.deepBrush;
            SoundPlayer player = new SoundPlayer(Properties.Resources.jungle);
            player.Play();


            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are lost in a forest";
                    option1Label.Text = "Go north";
                    option2Label.Text = "Go south";

                    imageBox.Image = Properties.Resources.deepBrush;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.jungle);
                    player1.Play();
                    break;
                case 2:
                    outputLabel.Text = "You come to a lake. Do you want to drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.forestLake;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.brook);
                    player2.Play();
                    break;
                case 3:
                    outputLabel.Text = "You falling in a pit and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "The water stagment. You die of Cholera. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "A horse swims by. Do you try and ride it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "You tame the horse and ride to safety. Yay!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "The horse walks away, you die of lonliness. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
    
