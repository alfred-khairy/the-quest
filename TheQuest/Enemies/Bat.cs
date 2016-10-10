using System;
using System.Drawing;

namespace TheQuest.Enemies
{
    public class Bat : Enemey
    {
        public Bat(Game game, Point location) : base(game, location, 6){}
        /// <summary>
        /// if Bat object is not dead, it will move the bat toward to player or random direction which is 50% chance
        /// if there is a near by player it attach with up to 2 hit points
        /// </summary>
        /// <param name="random"></param>
        public override void Move(Random random)
        {
            if (Dead) return;
            var playerDirection = FindPlayerDirection(game.PlayerLocation);
            var randomDirection = GetRandomDirection(random);
            var newLocation = Move(random.Next(0, 100) < 50 ? playerDirection : randomDirection, game.Boundaries);
            location.X = newLocation.X;
            location.Y = newLocation.Y;
            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
