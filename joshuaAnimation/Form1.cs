using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joshuaAnimation
{
    //change the ints for "Circle circle" so that it can be used as the ball in pong
    //then create the square paddle and write the ints
    public partial class Form1 : Form
    {
        Graphics gfx;

        //green circle 
        Circle circle = new Circle(50, 100, 50, 50, 10, 10, Color.Gold);
        Square square = new Square(10, 50, 50, 180, 10, Color.CadetBlue);
        Square square2 = new Square(600, 50, 50, 180, 0, Color.CadetBlue);

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            
        }

        int count = 0;

        int x = 0;
        int y = 100;
        int ySpeed = 6;
        int xSpeed = 6;

//        int x2 = 100;
//        int y2 = 100;
//        int ySpeed2 = 8;
//        int xSpeed2 = 9;


        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            this.Text = count.ToString();
            gfx.Clear(BackColor);

            circle.move(ClientSize);
            square.move(ClientSize);
            square2.move(ClientSize);

            circle.Draw(gfx);
            square.Draw(gfx);
            square2.Draw(gfx);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                square2.MoveUp();
            }
            if (e.KeyCode == Keys.S)
            {
                square2.MoveDown();
            }
        }
    }
}