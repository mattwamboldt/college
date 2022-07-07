//Title:  Frame
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace MarchODoom
{
    public class Frame
    {
        private Bitmap myImage;
        private int myDuration;

        //constructors
        public Frame(Bitmap image, int duration)
        {
            myImage = image;
            myDuration = duration;
        }

        public Frame(Bitmap image)
        {
            myImage = image;
            myDuration = 1;
        }

        public Frame()
        {
            myDuration = 0;
        }

        //properties
        public Bitmap Image
        {
            get
            {
                return myImage;
            }
            set
            {
                myImage = value;
            }
        }

        public int Duration
        {
            get
            {
                return myDuration;
            }
            set
            {
                myDuration = value;
            }
        }
    }
}
