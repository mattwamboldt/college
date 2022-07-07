//Title:  Character
//Date:   February 14th, 2007
//Author: Matthew Wamboldt
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MarchODoom
{
    //used to determine which animation to play
    public enum Direction
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    };

    public class Character
    {
        private Sprite mySprite;
        private Direction myDirection;
        private Point myLocation;
        private int mySpeed = 4;
        private bool isMoving;
        private int myWidth;
        private int myHeight;

        //Properties
        public int Width
        {
            get
            {
                return myWidth;
            }
        }

        public int Height
        {
            get
            {
                return myHeight;
            }
        }

        public Point Location
        {
            get
            {
                return myLocation;
            }
            set
            {
                myLocation = value;
            }
        }

        public bool Moving
        {
            get
            {
                return isMoving;
            }
            set
            {
                isMoving = value;
            }
        }

        //creates a new chatracter from a sprite sheet file.
        public Character(Bitmap bitmap, Direction direction, Point location)
        {
            mySprite = new Sprite();
            mySprite.Parse(bitmap);
            myDirection = direction;
            myLocation = location;
            mySprite.CurrentAnimation = (int)myDirection;
            myWidth = bitmap.Width / 4;
            myHeight = bitmap.Height / 4;
        }

        //draws the current animation
        public void Draw(Graphics graph)
        {
            mySprite.CurrentAnimation = (int)myDirection;
            mySprite.Animations[(int)myDirection].Animated = isMoving;
            mySprite.Draw(graph, myLocation);
        }

        //moves the sprite by its speed based on its currect direction
        //performs bounds checking after the move.
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    myLocation.Y -= mySpeed;
                    if (myLocation.Y < 0)
                    {
                        myLocation.Y = 0;
                    }
                    break;

                case Direction.Right:
                    myLocation.X += mySpeed;
                    if (myLocation.X + myWidth > 640)
                    {
                        myLocation.X = 640 - myWidth;
                    }
                    break;

                case Direction.Down:
                    myLocation.Y += mySpeed;
                    if (myLocation.Y + myHeight > 640)
                    {
                        myLocation.Y = 640 - myHeight;
                    }
                    break;

                case Direction.Left:
                    myLocation.X -= mySpeed;
                    if (myLocation.X < 0)
                    {
                        myLocation.X = 0;
                    }
                    break;
            }
            myDirection = direction;
        }
    }
}
