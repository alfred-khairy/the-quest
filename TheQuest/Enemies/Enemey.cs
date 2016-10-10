using System;
using System.Drawing;

namespace TheQuest.Enemies
{
    public abstract class Enemey : Mover
    {

        private const int NearPlayerDistance = 25;
        private int _hitPoints;
        public int HitPoints => _hitPoints;


        /// <summary>
        ///  Properties return true if enemy object has hit points less than or equal 0
        /// </summary>
        public bool Dead => _hitPoints <= 0;


        protected Enemey(Game game, Point location, int hitPoints): base(game, location)
        {
            _hitPoints = hitPoints;
        }


        /// <summary>
        /// Abstract method will be implemented on subClasses.
        /// </summary>
        public abstract void Move(Random random);


        public void Hit(int maxDamage , Random random)
        {
            _hitPoints -=random.Next(1, maxDamage);
        }


        /// <summary>
        /// Method return true if theres is a player near by 
        /// </summary>
        /// <returns></returns>
        protected bool NearPlayer()
        {
            return NearBy(game.PlayerLocation, NearPlayerDistance);
        }


        /// <summary>
        ///  Get a random direction of direction enum 
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        protected Direction GetRandomDirection(Random random)
        {
            //get array of enum values which it will be from 0-4
            var directionEnumValues = Enum.GetValues(typeof(Direction));
            return (Direction) directionEnumValues.GetValue(random.Next(directionEnumValues.Length));
        }



        /// <summary>
        /// Method take point of player location and return in which direction is the player.
        /// </summary>
        /// <param name="playerLocation"></param>
        /// <returns></returns>
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                 directionToMove = Direction.Right;
            else  if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                 directionToMove = Direction.Down;
            return directionToMove;
        }

    }
}
