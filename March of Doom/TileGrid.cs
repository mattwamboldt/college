//Title:  Tile Grid
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MarchODoom
{
    public class TileGrid
    {
        private Tile[,] myTiles;
        private int myHorizontalCount;
        private int myVerticalCount;

        //properties
        public Tile[,] Tiles
        {
            get{return myTiles;}
        }

        //use only for testing
        public void Draw(Graphics graph, Point Location)
        {
            for (int i = 0; i < myVerticalCount; i++)
            {
                for (int j = 0; j < myHorizontalCount; j++)
                {
                    graph.DrawImage(myTiles[j, i].Image, Location.X + j * Tile.WIDTH, Location.Y + i * Tile.HEIGHT);
                }
            }
        }

        //splits a bitmap into tiles
        public void Parse(Bitmap bitmap)
        {
            myHorizontalCount = bitmap.Width / Tile.WIDTH;
            myVerticalCount = bitmap.Height / Tile.HEIGHT;
            myTiles = new Tile[myHorizontalCount, myVerticalCount];

            for (int i = 0; i < myVerticalCount; i++)
            {
                for (int j = 0; j < myHorizontalCount; j++)
                {
                    myTiles[j, i] = new Tile(bitmap.Clone(new Rectangle(j * Tile.WIDTH, i * Tile.HEIGHT, Tile.WIDTH, Tile.HEIGHT), bitmap.PixelFormat));
                }
            }
        }
    }
}
