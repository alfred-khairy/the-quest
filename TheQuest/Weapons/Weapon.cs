using System;
using System.Drawing;
using TheQuest.Enemies;

namespace TheQuest.Weapons
{
    public abstract class Weapon: Mover
    {
        public bool PickedUp { get; private set; }
        protected Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }
        public void PickUpWeapon()
        {
            PickedUp = true;
        }
        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        /// <summary>
        ///  Method is attempt to find an enemy in a certain direction and radius,
        /// if its does, it calls the enemy hit() method and return true.
        /// other wise it return false
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="radius"></param>
        /// <param name="damage"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            var gamePlayerLocation = game.PlayerLocation;
            for (var distance = 0; distance < radius; distance++)
            {
                foreach (var enemy in game.Enemies)
                {
                    if (!NearBy(enemy.Location, gamePlayerLocation, radius)) continue;
                    enemy.Hit(damage, random);
                    return true;
                }
                gamePlayerLocation = Move(direction, gamePlayerLocation, game.Boundaries);
            }
            return false;
        }
    }
}
