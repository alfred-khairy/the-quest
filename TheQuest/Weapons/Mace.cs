using System;
using System.Drawing;

namespace TheQuest.Weapons
{
    public class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location){ }
        public override string Name => "Mace";
        /// <summary>
        /// Attack in every direction till you damage 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public override void Attack(Direction direction, Random random)
        {
            foreach (var direct in Enum.GetValues(typeof(Direction)))
            {
                if(DamageEnemy((Direction)direct, 20, 6, random))
                    return;
            }
            
        }
    }
}
