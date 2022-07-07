//Title:  Paddle
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MarchODoom
{
    class Paddle
    {
        private Rectangle myRectangle;
        private Brush myBrush = Brushes.DarkRed;
        private Pen myPen = Pens.Black;
        private int mySpeed;

        //properties
        public Rectangle Rectangle
        {
            get
            {
                return myRectangle;
            }
        }

        public Paddle(Rectangle rectangle, int speed)
        {
            myRectangle = rectangle;
            mySpeed = speed;
        }

        public void Draw(Graphics graph)
        {
            graph.FillRectangle(myBrush, myRectangle);
            graph.DrawRectangle(myPen, myRectangle);
            myRectangle.Location = new Point(myRectangle.Location.X + mySpeed, myRectangle.Location.Y);

            //causes it to bounce back and forth of the screen
            if (myRectangle.Location.X > 610 || myRectangle.Location.X < -40)
            {
                mySpeed = -mySpeed;
            }
        }
    }
}
