//Title:  Animation
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HerolessWar
{
    public class Animation
    {
        private Frame[] myFrames;
        private int myCurrentFrame;
        private int myRemainingDuration;
        private bool isAnimated;

        //properties
        public bool Animated
        {
            get
            {
                return isAnimated;
            }
            set
            {
                isAnimated = value;
            }
        }

        //constructors
        public Animation()
        {
            myCurrentFrame = -1;
        }

        public Animation(params Frame[] frames)
        {
            myFrames = frames;
            myCurrentFrame = 0;
        }

        public Animation(int currentFrame, params Frame[] frames)
        {
            myFrames = frames;
            myCurrentFrame = currentFrame;
        }

        //splits a bitmap into an array of frames
        public void Parse(Bitmap sourceImage, int numFrames)
        {
            myFrames = new Frame[numFrames];
            int frameWidth = sourceImage.Width / numFrames;
            for (int i = 0; i < numFrames; i++)
            {
                myFrames[i] = new Frame(sourceImage.Clone(new Rectangle(i * frameWidth, 0, frameWidth, sourceImage.Height), sourceImage.PixelFormat), 5);
            }
            myCurrentFrame = myFrames.Length;
        }

        //creates a bitmap from the file and calls the other constructor
        public void Parse(string fileName, int numFrames)
        {
            Bitmap bitmap = new Bitmap(fileName);
            Parse(bitmap, numFrames);
        }

        //draws the current frame until the duration has been reached
        //then advances the frame
        public void Draw(Graphics graph, Point location)
        {
            if (isAnimated)
            {
                //draw the animation animatedly 
                if (myRemainingDuration <= 0)
                {
                    ++myCurrentFrame;
                    if (myCurrentFrame >= myFrames.Length)
                    {
                        myCurrentFrame = 0;
                    }
                    myRemainingDuration = myFrames[myCurrentFrame].Duration;
                }

                graph.DrawImage(myFrames[myCurrentFrame].Image, location);
                --myRemainingDuration;
            }
            else
            {
                graph.DrawImage(myFrames[0].Image, location);
            }
        }
    }
}
