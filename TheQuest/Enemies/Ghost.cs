using System;
using System.Drawing;

namespace TheQuest.Enemies
{
    public class Ghost : Enemey
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        /// <summary>
        /// if Ghost object is not dead, there's a 1 in 3 chance that it will move toward the player
        /// and 2 in 3 that it will stand still.
        /// if there is a near by player it attach with up to 2 hit points
        /// </summary>
        /// <param name="random"></param>
        public override void Move(Random random)
        {
            if (Dead) return;
            var playerDirection = FindPlayerDirection(game.PlayerLocation);
            if (random.Next(0, 100) < 33)
            {
                var newLocation = Move(playerDirection, game.Boundaries);
                location.X = newLocation.X;
                location.Y = newLocation.Y;
            }

            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }

    }
}
