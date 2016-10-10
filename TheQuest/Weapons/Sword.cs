using System;
using System.Drawing;
namespace TheQuest.Weapons
{
    public class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location){}
        public override string Name => "Sword";
        public override void Attack(Direction direction, Random random)
        {
            var firstAttackAttemptDirection = Direction.Up;
            var secondAttackAttemptDirection =  Direction.Down;
            //TODO: implement a better way.
            switch (direction)
            {
                case Direction.Up:
                    firstAttackAttemptDirection = Direction.Right;
                    secondAttackAttemptDirection = Direction.Left;
                    break;
                case Direction.Right:
                    firstAttackAttemptDirection = Direction.Down;
                    secondAttackAttemptDirection = Direction.Up;
                    break;
                case Direction.Down:
                    firstAttackAttemptDirection = Direction.Left;
                    secondAttackAttemptDirection = Direction.Right;
                    break;
                case Direction.Left:
                    firstAttackAttemptDirection = Direction.Up;
                    secondAttackAttemptDirection = Direction.Down;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
            //TODO: change the 20 to 10;
            if (DamageEnemy(direction, 20, 3, random)) return;
            if (DamageEnemy(firstAttackAttemptDirection, 20, 3, random)) return;
            if (DamageEnemy(secondAttackAttemptDirection, 20, 3, random))
            {}
        }
    }
}
