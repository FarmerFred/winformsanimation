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
    public partial class Form1 : Form
    {
        Graphics gfx;

        //green circle 
        Circle circle = new Circle(50, 100, 50, 50, 90, 90, Color.Gold);
        Circle other = new Circle(200, 500, 400, 40, 20, 10, Color.DarkRed);
        Circle another = new Circle(50, 40, 450, 100, 90, 20, Color.DarkBlue);
        Circle more = new Circle(50, 5000, 440, 20, 150, 190, Color.Green);

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

        int x2 = 100;
        int y2 = 100;
        int ySpeed2 = 8;
        int xSpeed2 = 9;

        



        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            this.Text = count.ToString();
            gfx.Clear(BackColor);

            circle.move(ClientSize);
            other.move(ClientSize);
            another.move(ClientSize);

            other.Draw(gfx);
            circle.Draw(gfx);
            another.Draw(gfx);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}