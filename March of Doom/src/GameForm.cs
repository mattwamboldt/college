using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HerolessWar.Properties;

namespace HerolessWar
{
    public partial class GameForm : Form
    {
        TileGrid grid = new TileGrid();
        TileMap map;
        Character myWarrior;
        Paddle[] myPaddles = new Paddle[4];
        private bool isPlaying = true;
        private bool hasWon;

        public GameForm()
        {
            InitializeComponent();
            //breaks up the castle image into a grid of images
            grid.Parse(Resources.CastleTown);

            //maps the tiles to what appears on the screen
            map = new TileMap(grid);
            map.parse(Resources.Map);

            //creates the character from the spite sheet
            myWarrior = new Character(Resources.Warrior, Direction.Up, new Point(320, 550));

            //creates the paddles
            myPaddles[0] = new Paddle(new Rectangle(200, 200, 100, 20), 20);
            myPaddles[1] = new Paddle(new Rectangle(200, 300, 100, 20), 15);
            myPaddles[2] = new Paddle(new Rectangle(200, 400, 100, 20), 10);
            myPaddles[3] = new Paddle(new Rectangle(200, 500, 100, 20), 5);
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            if (isPlaying)
            {
                //draws the layer beneath the player
                map.Draw(graph, new Point(0, 0));
                graph.DrawString("GOAL", new Font(FontFamily.GenericSerif, 40), Brushes.White, new PointF(200, 100));
                //draw the player
                myWarrior.Draw(graph);

                //perform collision testing and draw the paddles
                for (int i = 0; i < 4; i++)
                {
                    if (myPaddles[i].Rectangle.IntersectsWith(new Rectangle(myWarrior.Location, new Size(myWarrior.Width, myWarrior.Height))))
                    {
                        //lose game
                        isPlaying = false;
                        hasWon = false;
                    }
                    myPaddles[i].Draw(graph);
                }

                //check if the player has reached the end
                if (isPlaying && new Rectangle(0, 64, 640, 100).IntersectsWith(new Rectangle(myWarrior.Location, new Size(myWarrior.Width, myWarrior.Height))))
                {
                    //win game
                    isPlaying = false;
                    hasWon = true;
                }
            }
            else
            {
                //display a message indicating victory or defeat
                if (hasWon)
                {
                    graph.DrawString("YOU WON!!!", new Font(FontFamily.GenericSerif, 40), Brushes.White, new PointF(200, 250));
                    graph.DrawString("Press n for a new game.", new Font(FontFamily.GenericSerif, 25), Brushes.White, new PointF(200, 300));
                }
                else
                {
                    graph.DrawString("YOU LOSE!!!", new Font(FontFamily.GenericSerif, 40), Brushes.White, new PointF(200, 250));
                    graph.DrawString("Press n for a new game.", new Font(FontFamily.GenericSerif, 25), Brushes.White, new PointF(200, 300));
                }
            }
        }

        //redraws at 60fps
        private void GameClock_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                //moves the character
                case Keys.Up:
                    myWarrior.Moving = true;
                    myWarrior.Move(Direction.Up);
                    break;

                case Keys.Right:
                    myWarrior.Moving = true;
                    myWarrior.Move(Direction.Right);
                    break;

                case Keys.Down:
                    myWarrior.Moving = true;
                    myWarrior.Move(Direction.Down);
                    break;

                case Keys.Left:
                    myWarrior.Moving = true;
                    myWarrior.Move(Direction.Left);
                    break;

                //start a new game
                case Keys.N:
                    if (!isPlaying)
                    {
                        isPlaying = true;
                        myWarrior.Location = new Point(320, 550);
                    }
                    break;
            }
        }

        //stop the character move animation
        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            myWarrior.Moving = false;
        }
    }
}