//Title:  Tile
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace MarchODoom
{
    public class Tile
    {
        private Bitmap myImage;

        //constants for the size of the image
        public static readonly int WIDTH = 32;
        public static readonly int HEIGHT = 32;

        public Tile(Bitmap image)
        {
            myImage = image;
        }

        public Bitmap Image
        {
            get { return myImage; }
        }
    }
}
