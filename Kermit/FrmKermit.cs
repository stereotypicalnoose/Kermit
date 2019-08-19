using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kermit
{
    public partial class FrmKermit : Form
    {
        Graphics g; // declare the graphics object
        int x = 20, y = 20;// starting position of planet
        Random speed = new Random();
        int[] piggySpeed = new int[7];
        // declare a rectangle to contain the spaceship and an area array to contain the planets
        Rectangle areakermit;
        Rectangle[] area = new Rectangle[7];//area[0] to area[6]
    

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                area[i].Y += piggySpeed[i];
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (area[i].IntersectsWith(areakermit))
                {
                    area[i].Y = 20;
                    lives -= 1; // reduce lives by 1
                                //display the number of lives on the form
                    LblLives.Text = lives.ToString();

                    CheckLives();
                }
                if (area[i].Y > PnlGame.Height)
                {
                    score += 1; // add 1 to score
                    LblScore.Text = score.ToString();//display score on the form 
                    area[i].Y = 20;
                }
            }
            PnlGame.Invalidate();
        }

        int x2 = 50, y2 = 290; //starting position of spaceship
        //Load our two images from the bin\debug folder
        Image spaceship = Image.FromFile(Application.StartupPath + @"\alien1.png");
        Image planet1 = Image.FromFile(Application.StartupPath + @"\planet1.png");
        Image kermit1 = Image.FromFile(Application.StartupPath + @"\kermit.png");
        Image piggy1 = Image.FromFile(Application.StartupPath + @"\piggy.png");

        int score = 0;
        int lives = 5;

      
            bool Left, Right;
     

        private void FrmKermit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { Left = true; }
            if (e.KeyData == Keys.Right) { Right = true; }
        }

        private void FrmKermit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { Left = false; }
            if (e.KeyData == Keys.Right) { Right = false; }
        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (Left) // if left arrow pressed
            {
                if (areakermit.X < 10) //check to see if spaceship within 10 of left side
                {
                    areakermit.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    areakermit.X -= 5; //else move 5 to the left
                }
            }
            if (Right) // if right arrow key pressed
            {
                if (areakermit.X > PnlGame.Width - 40)// is spaceship within 40 of right side
                {
                    areakermit.X = PnlGame.Width - 40;
                }
                else
                {
                    areakermit.X += 5;
                }
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }

            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
                TxtName.Focus();
            }
            else
            {
                mnuStart.Enabled = true;
            }
            
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            
            //use the DrawImage method to draw the spaceship on the panel
            for (int i = 0; i <= 6; i++)
            {
                g.DrawImage(piggy1, area[i]);
               
            }
            g.DrawImage(kermit1, areakermit);
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            score = 0; //when game starts set the score to 0
            LblScore.Text = score.ToString(); //display the score on the form
            TmrPlanet.Enabled = true; //start the timer to move the planets
            TmrShip.Enabled = true; //start the timer to move the spaceship
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrShip.Enabled = false;
            TmrPlanet.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmKermit_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to move kermit. \n Don't let miss piggy catch you! \n Every miss piggy that goes past scores a point. \n If a miss piggy hits kermit a life is lost!", "Game Instructions");
            TxtName.Focus();
            mnuStart.Enabled = true;
        }

        public FrmKermit()
        {
            InitializeComponent();
            areakermit = new Rectangle(x2, y2, 60, 60);//spaceship's rectangle
                                                          //position the planets
            for (int i = 0; i < 7; i++)
            {
                area[i] = new Rectangle(x + 70 * i, y, 40, 40);
                piggySpeed[i] = speed.Next(5, 10); //each planet has a random speed
            }
          
            
        }
        //the CheckLives method will stop the planets and spaceship moving if there are no lives left
        // and a game over message will be displayed  
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("you lose! \n she caught you");

            }
        }

    }
}
