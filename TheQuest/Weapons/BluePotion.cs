using System;
using System.Drawing;

namespace TheQuest.Weapons
{
    public class BluePotion : Weapon, IPotion
    {
        public bool Used { get; set; }
        public BluePotion(Game game, Point location) : base(game, location) { }
        public override string Name => "BluePotion";
        public override void Attack(Direction direction, Random random)
        {
            if(Used) return;
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }

        
    }
}
