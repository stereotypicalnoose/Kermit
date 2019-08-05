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
        int[] planetSpeed = new int[7];
        // declare a rectangle to contain the spaceship and an area array to contain the planets
        Rectangle areaSpaceship;
        Rectangle[] area = new Rectangle[7];//area[0] to area[6]
    

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                area[i].Y += planetSpeed[i];
                if (area[i].Y > PnlGame.Height)
                {
                    area[i].Y = 20;
                }
            }
            PnlGame.Invalidate();
        }

        int x2 = 50, y2 = 290; //starting position of spaceship
        //Load our two images from the bin\debug folder
        Image spaceship = Image.FromFile(Application.StartupPath + @"\alien1.png");
        Image planet1 = Image.FromFile(Application.StartupPath + @"\planet1.png");

        private void True(object sender, PreviewKeyDownEventArgs e)
        {
            bool Left, Right;
        }

        private void FrmKermit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { Left = true; }
            if (e.KeyData == Keys.Right) { Right = true; }
        }

        private void FrmKermit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (left) // if left arrow pressed
            {
                if (areaSpaceship.X < 10) //check to see if spaceship within 10 of left side
                {
                    areaSpaceship.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    areaSpaceship.X -= 5; //else move 5 to the left
                }
            }
            if (right) // if right arrow key pressed
            {
                if (areaSpaceship.X > PnlGame.Width - 40)// is spaceship within 40 of right side
                {
                    areaSpaceship.X = PnlGame.Width - 40;
                }
                else
                {
                    areaSpaceship.X += 5;
                }
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            g.DrawImage(spaceship, area);
            //use the DrawImage method to draw the planet on the panel
            g.DrawImage(planet1, area1);
            g.DrawImage(planet1, area2);
            g.DrawImage(planet1, area3);
            g.DrawImage(planet1, area4);
            g.DrawImage(planet1, area5);
            g.DrawImage(planet1, area6);
            g.DrawImage(planet1, area7);

        }

        public FrmKermit()
        {
            InitializeComponent();
            areaSpaceship = new Rectangle(x2, y2, 30, 30);//spaceship's rectangle
                                                          //position the planets
            for (int i = 0; i < 7; i++)
            {
                area[i] = new Rectangle(x + 70 * i, y, 40, 40);
                planetSpeed[i] = speed.Next(5, 10); //each planet has a random speed
            }
            speed1 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed2 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed3 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed4 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed5 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed6 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed7 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            
        }
    }
}
