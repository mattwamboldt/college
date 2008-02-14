//Title:  Sprite
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HerolessWar
{
    public class Sprite
    {
        private Animation[] myAnimations;
        private int myCurrentAnimation;

        //properties
        public int CurrentAnimation
        {
            get
            {
                return myCurrentAnimation;
            }
            set
            {
                myCurrentAnimation = value;
            }
        }

        public Animation[] Animations
        {
            get
            {
                return myAnimations;
            }
        }

        //draws the current frame at the given location
        public void Draw(Graphics graph, Point location)
        {
            myAnimations[myCurrentAnimation].Draw(graph, location);
        }

        //splits up a bitmap into frames and creates the movement animations from it
        public void Parse(Bitmap spritesheet)
        {
            int frameHeight = spritesheet.Height/4;
            int frameWidth = spritesheet.Width / 4;

            Frame[,] frames = new Frame[4, 4];
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    frames[j, i] = new Frame(spritesheet.Clone(new Rectangle(j * frameWidth,
                        i * frameHeight, frameWidth, frameHeight), spritesheet.PixelFormat), 10);
                }
            }
            myAnimations = new Animation[4];
            myAnimations[0] = new Animation(1, frames[0, 3], frames[1, 3], frames[2, 3], frames[3, 3]);
            myAnimations[1] = new Animation(1, frames[0, 2], frames[1, 2], frames[2, 2], frames[3, 2]);
            myAnimations[2] = new Animation(1, frames[0, 0], frames[1, 0], frames[2, 0], frames[3, 0]);
            myAnimations[3] = new Animation(1, frames[0, 1], frames[1, 1], frames[2, 1], frames[3, 1]);
        }
    }
}
