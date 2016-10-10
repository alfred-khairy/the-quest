using System;
using System.Drawing;
using System.Windows.Forms;
using TheQuest.Enemies;

namespace TheQuest
{
    public partial class QuestForm : Form
    {
        private Game _game;
        private Random _random = new Random();


        public QuestForm()
        {
            InitializeComponent();

            SwordButton.Visible = false;
            BowButton.Visible = false;
            MaceButton.Visible = false;
            RedPotionButton.Visible = false;
            BluePotionButton.Visible = false;
            Sword.Visible = false;
            Bow.Visible = false;
            RedPotion.Visible = false;
            BluePotion.Visible = false;
            Mace.Visible = false;
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            _game = new Game(new Rectangle(78, 57, 420, 155));
            _game.NewLevel(_random);
            UpdateCharacters();
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Up, _random);
            UpdateCharacters();
        }
        //TODO: need a little bit refactor
        public void UpdateCharacters()
        {
            Player.Location = _game.PlayerLocation;
            PlayerHitPoints.Text = _game.PlayerHitPoints.ToString();
            //Hide enemy
            Bat.Visible = false;
            Ghoul.Visible = false;
            Ghostt.Visible = false;
            //Assure that there label is empty
            BatHitsPoint.Text = "";
            GhostHitPoints.Text = "";
            GhoulHitsPoint.Text = "";

            bool showBat = false, showGhost = false, showGhoul = false;
            var enemiesShown = 0;

            foreach (var enemy in _game.Enemies)
            {
                if (enemy is Bat)
                {
                    Bat.Location = enemy.Location;
                    BatHitsPoint.Text = enemy.HitPoints.ToString();
                    if (enemy.Dead)
                    {
                        BatHitsPoint.Text = "";
                        continue;
                    }
                    showBat = true;
                    enemiesShown++;
                }
                else if (enemy is Ghost)
                {
                    Ghostt.Location = enemy.Location;
                    GhostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.Dead)
                    {
                        GhostHitPoints.Text = "";
                        continue;
                    }
                    showGhost = true;
                    enemiesShown++;
                }
                else if (enemy is Ghoul)
                {
                    Ghoul.Location = enemy.Location;
                    GhoulHitsPoint.Text = enemy.HitPoints.ToString();
                    if (enemy.Dead)
                    {
                        GhoulHitsPoint.Text = "";
                        continue;
                    }
                    showGhoul = true;
                    enemiesShown++;
                }
            }
            // show enemies if they are visible
            if (showBat) Bat.Visible = true;
            if (showGhoul) Ghoul.Visible = true;
            if (showGhost) Ghostt.Visible = true;

            Control weaponControl = null;
            switch (_game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = Sword;
                    break;
                case "BluePotion":
                    weaponControl = BluePotion;
                    break;
                case "RedPotion":
                    weaponControl = RedPotion;
                    break;
                case "Mace":
                    weaponControl = Mace;
                    break;
                case "Bow":
                    weaponControl = Bow;
                    break;

            }
            if (weaponControl != null)
            {
                weaponControl.Visible = true;
                weaponControl.Visible = !_game.WeaponInRoom.PickedUp;
                weaponControl.Location = _game.WeaponInRoom.Location;
            }

            //TODO: Might be a better way to hight light sword 
            if(_game.PlayerWeapons.Count == 1)
                Sword.BorderStyle = BorderStyle.FixedSingle;

            if (_game.WeaponInRoom.PickedUp)
            {
                ShowWeaponButton(_game.WeaponInRoom.Name);
            }

            if (_game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if (enemiesShown >= 1) return;
            MessageBox.Show($"You have defeated the enemies on this level {_game.Level}");
            _game.NewLevel(_random);
            UpdateCharacters();
        }



        public void ShowWeaponButton(string weapanName)
        {
            switch (_game.WeaponInRoom.Name)
            {
                case "Sword":
                    SwordButton.Visible = true;
                    break;
                case "BluePotion":
                    BluePotionButton.Visible = true;
                    break;
                case "RedPotion":
                    RedPotionButton.Visible = true;
                    break;
                case "Mace":
                    MaceButton.Visible = true;
                    break;
                case "Bow":
                    BowButton.Visible = true;
                    break;
            }

        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Left, _random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Right, _random);
            UpdateCharacters();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Down, _random);
            UpdateCharacters();
        }

        private void AttachUp_Click(object sender, EventArgs e)
        {
            _game.Attact(Direction.Up, _random);
            UpdateCharacters();
        }

        private void AttachLeft_Click(object sender, EventArgs e)
        {
            _game.Attact(Direction.Left, _random);
            UpdateCharacters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            _game.Attact(Direction.Right, _random);
            UpdateCharacters();
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            _game.Attact(Direction.Down, _random);
            UpdateCharacters();
        }


        private void SwordButton_Click(object sender, EventArgs e)
        {

            var weaponName = "Sword";
            if (!_game.CheckPlayerInvenotry(weaponName)) return;
            _game.Equip(weaponName);
            BluePotionButton.BorderStyle = BorderStyle.None;
            RedPotionButton.BorderStyle = BorderStyle.None;
            SwordButton.BorderStyle = BorderStyle.FixedSingle;
            BowButton.BorderStyle = BorderStyle.None;
            MaceButton.BorderStyle = BorderStyle.None;
            DrinkPotion();

        }

        private void BowButton_Click(object sender, EventArgs e)
        {
            var weaponName = "Bow";
            if (!_game.CheckPlayerInvenotry(weaponName)) return;
            _game.Equip(weaponName);
            BluePotionButton.BorderStyle = BorderStyle.None;
            RedPotionButton.BorderStyle = BorderStyle.None;
            SwordButton.BorderStyle = BorderStyle.None;
            BowButton.BorderStyle = BorderStyle.FixedSingle;
            MaceButton.BorderStyle = BorderStyle.None;
            DrinkPotion();

        }

        private void MaceButton_Click(object sender, EventArgs e)
        {
            var weaponName = "Mace";
            if (!_game.CheckPlayerInvenotry(weaponName)) return;
            _game.Equip(weaponName);
            BluePotionButton.BorderStyle = BorderStyle.None;
            RedPotionButton.BorderStyle = BorderStyle.None;
            SwordButton.BorderStyle = BorderStyle.None;
            BowButton.BorderStyle = BorderStyle.None;
            MaceButton.BorderStyle = BorderStyle.FixedSingle;
            DrinkPotion();
        }

        private void PotionRedButton_Click(object sender, EventArgs e)
        {
            var weaponName = "RedPotion";
            if (!_game.CheckPlayerInvenotry(weaponName)) return;
            _game.Equip(weaponName);
            BluePotionButton.BorderStyle = BorderStyle.None;
            RedPotionButton.BorderStyle = BorderStyle.FixedSingle;
            SwordButton.BorderStyle = BorderStyle.None;
            BowButton.BorderStyle = BorderStyle.None;
            MaceButton.BorderStyle = BorderStyle.None;
            DrinkPotion(true);
        }

        private void BluePotionButton_Click(object sender, EventArgs e)
        {
            var weaponName = "BluePotion";
            if (!_game.CheckPlayerInvenotry(weaponName)) return;
            _game.Equip(weaponName);
            BluePotionButton.BorderStyle = BorderStyle.FixedSingle;
            RedPotionButton.BorderStyle = BorderStyle.None;
            SwordButton.BorderStyle = BorderStyle.None;
            BowButton.BorderStyle = BorderStyle.None;
            MaceButton.BorderStyle = BorderStyle.None;
            DrinkPotion(true);
        }

        private void DrinkPotion(bool option = false)
        {
            if (option)
            {
                AttachLeft.Visible = false;
                AttackRight.Visible = false;
                AttackDown.Visible = false;
                AttachUp.Text = "Drink";
            }
            else
            {
                AttachLeft.Visible = true;
                AttackRight.Visible = true;
                AttackDown.Visible = true;
                AttachUp.Text = "UP";
            }

        }

        private void PlayerHitPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
