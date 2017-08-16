using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuaAnimation
{
    class Square
    {
        int x;
        int y; 
        int width;
        int height;
        int ySpeed;
        Color color;

        public Square(int x, int y, int width, int height, int ySpeed, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.ySpeed = ySpeed;
            this.color = color;
        }
        public void move(Size ClientSize)
        {
            y += ySpeed;
            if (y + height > ClientSize.Height)
            {
                ySpeed *= -1;
            }

            if (y < 0)
            {
                ySpeed *= -1;
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(color), x, y, width, height);
        }

        public void MoveUp()
        {
            y -= 10;
        }
        public void MoveDown()
        {
            y += 10;
        }
    }
}
