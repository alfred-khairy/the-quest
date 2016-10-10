using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TheQuest.Enemies;
using TheQuest.Weapons;
namespace TheQuest
{
    public class Game
    {
        public List<Enemey> Enemies;
        public Weapon WeaponInRoom;
        private readonly Player _player;
        public Point PlayerLocation => _player.Location;
        public int PlayerHitPoints => _player.HitPoints;
        public List<string> PlayerWeapons => _player.Weapons;
        public int Level { get; private set; } = 0;
        private Rectangle _boundaries;
        // Make the boundaries property read only for any code outside the class
        public Rectangle Boundaries => _boundaries;

        // Game constructor 
        public Game(Rectangle boundaries)
        {
            _boundaries = boundaries;
            // initialize player position once game start
            _player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        /// <summary>
        /// when a player move, all the enemas get a turn to move as well
        /// </summary>
        /// <param name="direction"></param>
        /// <param name=""></param>
        public void Move(Direction direction, Random random)
        {
            _player.Move(direction);
            foreach (var enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            _player.Equip(weaponName);
        }

        /// <summary>
        /// Method use to figure out if player has this weapons in his inventory.
        /// </summary>
        /// <param name="weaponName"></param>
        /// <returns></returns>
        public bool CheckPlayerInvenotry(string weaponName)
        {
            return _player.Weapons.Contains(weaponName);
        }
        /// <summary>
        /// method is used to attach player and cause damage to it's health 
        /// </summary>
        /// <param name="maxDamage"></param>
        /// <param name="random"></param>
        public void HitPlayer(int maxDamage, Random random)
        {
            _player.Hit(maxDamage, random);
        }

        /// <summary>
        /// Method is used to increase player health.
        /// </summary>
        /// <param name="health"></param>
        /// <param name="random"></param>
        public void IncreasePlayerHealth(int health, Random random)
        {
            _player.IncreaseHealth(health, random);
        }
        /// <summary>
        /// when player attack, its attach and all the enemies get a turn to move
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public void Attact(Direction direction, Random random)
        {
            _player.Attack(direction, random);
            foreach (var enemy in Enemies)
            {
                enemy.Move(random);
            }
        }


        /// <summary>
        /// Method use to get a random location inside the dungeon
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        private Point GetRandomLocation(Random random)
        {
            return new Point(_boundaries.Left + random.Next(_boundaries.Right / 10 - _boundaries.Left / 10) * 10, _boundaries.Top + random.Next(_boundaries.Bottom / 10 - Boundaries.Top / 10) * 10);
        }
        public void NewLevel(Random random)
        {
            Level++;
            switch (Level)
            {
                case 1:
                    Enemies = new List<Enemey> { new Bat(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemey> { new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemey> { new Ghoul(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemey>
                    {
                        new Ghost(this, GetRandomLocation(random)),
                        new Bat(this, GetRandomLocation(random))
                    };
                    // if player does not have blue potion as weapon
                    if (!CheckPlayerInvenotry("BluePotion"))
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    // if player does not have blue potion as weapon
                    else if (!CheckPlayerInvenotry("Bow"))
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies = new List<Enemey>
                    {
                        new Ghoul(this, GetRandomLocation(random)),
                        new Bat(this, GetRandomLocation(random))
                    };
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemey>
                    {
                        new Ghoul(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random))
                    };
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemey>
                    {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random))
                    };
                    if (!CheckPlayerInvenotry("Mace"))
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    else if(!CheckPlayerInvenotry("RedPotion"))
                         WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 8:
                    Application.Exit();
                    break;
            }
        }
    }
}
