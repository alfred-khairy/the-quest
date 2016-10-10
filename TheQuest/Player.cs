using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TheQuest.Weapons;

namespace TheQuest
{
    public class Player : Mover
    {
        private Weapon _equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> _inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                return _inventory.Select(weapon => weapon.Name).ToList();
            }
        }

        // player construction method.
        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        /// <summary>
        /// when an enemy hit a player it case a random amount of damage
        /// </summary>
        /// <param name="maxDamage"></param>
        /// <param name="random"></param>
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        /// <summary>
        /// when a player pick up a potion , it increase it's health by random amount of number
        /// </summary>
        /// <param name="health"></param>
        /// <param name="random"></param>
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        /// <summary>
        ///  it tells the player to equip one of his weapons.
        /// the game object call this method when one of inventory icons is clicked
        /// </summary>
        /// <param name="weaponName"></param>
        public void Equip(string weaponName)
        {
            foreach (var weapon in _inventory)
            {
                if (weapon.Name == weaponName)
                    _equippedWeapon = weapon;
            }
        }

        /// <summary>
        ///  it moves to word a direction and if the player have a weapon close to it
        ///  it will pick it up
        /// </summary>
        /// <param name="direction"></param>
        public void Move(Direction direction)
        {
            location = Move(direction, game.Boundaries);
            if (game.WeaponInRoom.PickedUp) return;
            if (!NearBy(game.WeaponInRoom.Location, 25)) return;
            _inventory.Add(game.WeaponInRoom);
            game.WeaponInRoom.PickUpWeapon();
            // if this the only weapon in the inventory so euip immediately 
            if(_inventory.Count == 1)
                Equip(_inventory.First().Name);
        }

        public void Attack(Direction direction, Random random)
        {
            _equippedWeapon?.Attack(direction,random);
        }


    }
}
