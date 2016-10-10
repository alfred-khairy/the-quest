using System;
using System.Drawing;

namespace TheQuest.Weapons
{
    public class RedPotion : Weapon, IPotion
    {
        public bool Used { get; set; }
        public RedPotion(Game game, Point location) : base(game, location) { }
        public override string Name => "RedPotion";
        public override void Attack(Direction direction, Random random)
        {
            if(Used) return;
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }


    }


}
