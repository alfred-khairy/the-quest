using System;
using System.Drawing;

namespace TheQuest
{
    public abstract class Mover
    {
        //TODO: it out of scope but it should be move to configuration file. no magic value
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location {
            get { return location; }
        }
        protected Game game;

        // constructor
        protected Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }


        /// <summary>
        /// Method checks a point against this object's current location
        /// if they are within distance of each other then it returns true;otherwise , it returns false.
        /// </summary>
        /// <param name="locationToCheck"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool NearBy(Point locationToCheck, int distance)
        {
            return Math.Abs(location.X - locationToCheck.X) < distance && (Math.Abs(location.Y - locationToCheck.Y) < distance);
        }

        public bool NearBy(Point locationToCheck, Point playerLocation, int distance)
        {

            return Math.Abs(playerLocation.X - locationToCheck.X) < distance && (Math.Abs(playerLocation.Y - locationToCheck.Y) < distance);
        }

        /// <summary>
        /// Method tries to move one step in a direction. if it can, it returns the new point.
        /// if it hits a boundary, it returns the original point.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="boundaries"></param>
        /// <returns></returns>
        public Point Move(Direction direction, Rectangle boundaries)
        {
            // if the end location is outside the boundaries, the new location stays the same as the starting location (point)
            var newLocation = location;

            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
            return newLocation;
        }


        public Point Move(Direction direction, Point playerLocation, Rectangle boundaries)
        {
            var newLocation = playerLocation;

            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X - MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
            return newLocation;

        }


    }
}
