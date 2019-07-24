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
        int speed1, speed2, speed3, speed4, speed5, speed6, speed7;
        //Declare the rectangles to display the spaceship and planets in
        Rectangle area, area1, area2, area3, area4, area5, area6, area7;

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            area1.Y += speed1;// move the area(planet) down the panel
            if (area1.Y > PnlGame.Height)
            {
                area1.Y = 20;
            }
            area2.Y += speed2;// move the area(planet) down the panel
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
            if (area2.Y > PnlGame.Height)
            {
                area2.Y = 20;
            }
            area3.Y += speed3;// move the area(planet) down the panel
            if (area3.Y > PnlGame.Height)
            {
                area3.Y = 20;
            }
            area4.Y += speed4;// move the area(planet) down the panel
            if (area4.Y > PnlGame.Height)
            {
                area4.Y = 20;
            }
            area5.Y += speed5;// move the area(planet) down the panel
            if (area5.Y > PnlGame.Height)
            {
                area5.Y = 20;
            }
            area6.Y += speed6;// move the area(planet) down the panel
            if (area6.Y > PnlGame.Height)
            {
                area6.Y = 20;
            }
            area7.Y += speed7;// move the area(planet) down the panel
            if (area7.Y > PnlGame.Height)
            {
                area7.Y = 20;
            }

        }

        int x2 = 50, y2 = 290; //starting position of spaceship
        //Load our two images from the bin\debug folder
        Image spaceship = Image.FromFile(Application.StartupPath + @"\alien1.png");
        Image planet1 = Image.FromFile(Application.StartupPath + @"\planet1.png");


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
            area = new Rectangle(x2, y2, 30, 30);//spaceship's rectangle	
            area1 = new Rectangle(x, y, 40, 40); //planet1's rectangle
            area2 = new Rectangle(x + 70, y, 40, 40);// planet2's rectangle
            area3 = new Rectangle(x + 140, y, 40, 40);// planet3's rectangle
            area4 = new Rectangle(x + 210, y, 40, 40);// planet4's rectangle
            area5 = new Rectangle(x + 280, y, 40, 40);// planet5's rectangle
            area6 = new Rectangle(x + 350, y, 40, 40);// planet6's rectangle
            area7 = new Rectangle(x + 420, y, 40, 40);// planet7's rectangle
            speed2 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed3 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed4 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed5 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed6 = speed.Next(5, 10);//planet1's speed will be between 5 and 10
            speed7 = speed.Next(5, 10);//planet1's speed will be between 5 and 10


            speed1 = speed.Next(5, 10);//planet1's speed will be between 5 and 10

        }
    }
}
