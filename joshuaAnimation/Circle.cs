﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuaAnimation
{
    class Circle
    {
        int x;// = 0
        int y; // = 0
        int width;
        int height;
        int xSpeed;
        int ySpeed;
        Color color;
        //width, height, xSpeed, ySpeed
        public Circle(int x, int y, int width, int height, int xSpeed, int ySpeed, Color color)//<- constructor
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
            this.color = color;
        }

         public void move(Size ClientSize)
        {
            x += xSpeed;
            y += ySpeed;

            if (x + width > ClientSize.Width)
            {
                xSpeed *= -1;
            }

            if (x < 0)
            {
                xSpeed *= -1;
            }

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
            gfx.FillEllipse(new SolidBrush(color), x, y, width, height);
        }
    }
}
