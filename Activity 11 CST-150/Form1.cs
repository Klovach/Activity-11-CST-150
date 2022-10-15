using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11_CST_150
{

    // Note: "https://game-icons.net/tags/dice.html" Images by Delapouite under CC BY 3.0 on Game-Icons.net
    public partial class Form1 : Form
    {
        // Create two new die objects from our Dice class.
        Dice die1 = new Dice(6);
        Dice die2 = new Dice(6);

        // Declare and initialize our variables. 
        int die1Roll, die2Roll;
        int numberOfRolls = 0;

        public Form1()
        {
            InitializeComponent();
        }

    private void btnRollDice_Click(object sender, EventArgs e)
        {

            /* Set the number of faces equal to the number we roll when we roll the die. 
             The random faces are seperate from the faces we roll when we roll the die. The
             random faces are for the display that is presented to the user after they roll the die.
             These faces are only changed once rather than for every automated roll of the dice.*/
            int randomFace1 = die1.rollDie();
            int randomFace2 = die2.rollDie();


            // Dice 1 (Decorative) - 
            switch (randomFace1)
            {
                case 1:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_one;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
       
                    break;
                case 2:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_two;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_three;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_four;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_five;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_six;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    picDie1.Image = Properties.Resources.perspective_dice_six_faces_random;
                    picDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            // Dice 2 (Decorative)-
            switch (randomFace2)
            {
                case 1:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_one;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
                case 2:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_two;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_three;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_four;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_five;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_six;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    picDie2.Image = Properties.Resources.perspective_dice_six_faces_random;
                    picDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }


            /*Until the users roll snake eyes(while (die1Roll != 1 || die2Roll != 1);),
             we increase the recorded number of rolls and display the value of each roll
            to the user via  rtxStatistics.Text.*/
            do
            {

                die1Roll = die1.rollDie();
                die2Roll = die2.rollDie();
                ++numberOfRolls;

                rtxStatistics.Text += ("You rolled [Dice 1: " + die1Roll + ", Dice 2: " + die2Roll + "]\n");

            } while (die1Roll != 1 || die2Roll != 1);

            // When the user hits snake eyes and the do-while loop ends, this message is displayed. 
            rtxStatistics.Text += "It took " + numberOfRolls + " rolls to get snake eyes!\n";
        }
    }
}
    
