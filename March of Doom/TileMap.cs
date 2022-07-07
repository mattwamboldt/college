//Title:  Tile Map
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace MarchODoom
{
    public class TileMap
    {
        private Tile[,] myTileMappings;
        private TileGrid myTileGrid;

        //constructor
        public TileMap(TileGrid grid)
        {
            myTileGrid = grid;
            myTileMappings = new Tile[20, 20];
        }

        //draws the tiles on the screen.
        public void Draw(Graphics graph, Point Location)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    graph.DrawImage(myTileMappings[j, i].Image, Location.X + j * Tile.WIDTH, Location.Y + i * Tile.HEIGHT);
                }
            }
        }

        //attempts to assign tiles to the map based on a text file.
        public void parse(StreamReader reader)
        {
            string row;
            for (int i = 0; i < 20; i++)
            {
                row = reader.ReadLine();
                string[] mappings = row.Split(new char[] { ';' }, 20);
                for (int j = 0; j < 20; j++)
                {
                    string[] coords = mappings[j].Split(new char[] { ',' }, 2);
                    myTileMappings[j, i] = myTileGrid.Tiles[Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1])];
                }
            }
            reader.Close();
        }

        //attempts to assign tiles to the map based on a raw string of data.
        public void parse(string data)
        {
            StringReader reader = new StringReader(data);
            string row;
            for (int i = 0; i < 20; i++)
            {
                row = reader.ReadLine();
                string[] mappings = row.Split(new char[] { ';' }, 20);
                for (int j = 0; j < 20; j++)
                {
                    string[] coords = mappings[j].Split(new char[] { ',' }, 2);
                    myTileMappings[j, i] = myTileGrid.Tiles[Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1])];
                }
            }
            reader.Close();
        }
    }
}
