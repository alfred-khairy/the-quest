using System.Windows.Forms;

namespace TheQuest
{
    partial class QuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Mace = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.BluePotion = new System.Windows.Forms.PictureBox();
            this.RedPotion = new System.Windows.Forms.PictureBox();
            this.Sword = new System.Windows.Forms.PictureBox();
            this.Bow = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GhoulHitsPoint = new System.Windows.Forms.Label();
            this.GhostHitPoints = new System.Windows.Forms.Label();
            this.BatHitsPoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ghost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AttachUp = new System.Windows.Forms.Button();
            this.AttachLeft = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ghoul = new System.Windows.Forms.PictureBox();
            this.Ghostt = new System.Windows.Forms.PictureBox();
            this.SwordButton = new System.Windows.Forms.PictureBox();
            this.BowButton = new System.Windows.Forms.PictureBox();
            this.MaceButton = new System.Windows.Forms.PictureBox();
            this.RedPotionButton = new System.Windows.Forms.PictureBox();
            this.BluePotionButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghostt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Move";
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bat.BackgroundImage")));
            this.Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bat.Location = new System.Drawing.Point(244, 86);
            this.Bat.Margin = new System.Windows.Forms.Padding(2);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(30, 30);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bat.TabIndex = 1;
            this.Bat.TabStop = false;
            // 
            // Mace
            // 
            this.Mace.BackColor = System.Drawing.Color.Transparent;
            this.Mace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mace.BackgroundImage")));
            this.Mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mace.Location = new System.Drawing.Point(360, 165);
            this.Mace.Margin = new System.Windows.Forms.Padding(2);
            this.Mace.Name = "Mace";
            this.Mace.Size = new System.Drawing.Size(30, 30);
            this.Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mace.TabIndex = 4;
            this.Mace.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(143, 130);
            this.Player.Margin = new System.Windows.Forms.Padding(2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 30);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // BluePotion
            // 
            this.BluePotion.BackColor = System.Drawing.Color.Transparent;
            this.BluePotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BluePotion.BackgroundImage")));
            this.BluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BluePotion.Location = new System.Drawing.Point(307, 168);
            this.BluePotion.Margin = new System.Windows.Forms.Padding(2);
            this.BluePotion.Name = "BluePotion";
            this.BluePotion.Size = new System.Drawing.Size(30, 30);
            this.BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BluePotion.TabIndex = 6;
            this.BluePotion.TabStop = false;
            // 
            // RedPotion
            // 
            this.RedPotion.BackColor = System.Drawing.Color.Transparent;
            this.RedPotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RedPotion.BackgroundImage")));
            this.RedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedPotion.Location = new System.Drawing.Point(191, 118);
            this.RedPotion.Margin = new System.Windows.Forms.Padding(2);
            this.RedPotion.Name = "RedPotion";
            this.RedPotion.Size = new System.Drawing.Size(30, 30);
            this.RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RedPotion.TabIndex = 7;
            this.RedPotion.TabStop = false;
            // 
            // Sword
            // 
            this.Sword.BackColor = System.Drawing.Color.Transparent;
            this.Sword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sword.BackgroundImage")));
            this.Sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sword.Location = new System.Drawing.Point(82, 90);
            this.Sword.Margin = new System.Windows.Forms.Padding(2);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(30, 30);
            this.Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Sword.TabIndex = 8;
            this.Sword.TabStop = false;
            // 
            // Bow
            // 
            this.Bow.BackColor = System.Drawing.Color.Transparent;
            this.Bow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bow.BackgroundImage")));
            this.Bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bow.Location = new System.Drawing.Point(257, 130);
            this.Bow.Margin = new System.Windows.Forms.Padding(2);
            this.Bow.Name = "Bow";
            this.Bow.Size = new System.Drawing.Size(30, 30);
            this.Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bow.TabIndex = 9;
            this.Bow.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel1.Controls.Add(this.GhoulHitsPoint, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.GhostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BatHitsPoint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Ghost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlayerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(607, 260);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 139);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // GhoulHitsPoint
            // 
            this.GhoulHitsPoint.AutoSize = true;
            this.GhoulHitsPoint.Location = new System.Drawing.Point(66, 102);
            this.GhoulHitsPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GhoulHitsPoint.Name = "GhoulHitsPoint";
            this.GhoulHitsPoint.Size = new System.Drawing.Size(0, 13);
            this.GhoulHitsPoint.TabIndex = 7;
            // 
            // GhostHitPoints
            // 
            this.GhostHitPoints.AutoSize = true;
            this.GhostHitPoints.Location = new System.Drawing.Point(66, 68);
            this.GhostHitPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GhostHitPoints.Name = "GhostHitPoints";
            this.GhostHitPoints.Size = new System.Drawing.Size(0, 13);
            this.GhostHitPoints.TabIndex = 6;
            // 
            // BatHitsPoint
            // 
            this.BatHitsPoint.AutoSize = true;
            this.BatHitsPoint.Location = new System.Drawing.Point(66, 34);
            this.BatHitsPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BatHitsPoint.Name = "BatHitsPoint";
            this.BatHitsPoint.Size = new System.Drawing.Size(0, 13);
            this.BatHitsPoint.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bat";
            // 
            // Ghost
            // 
            this.Ghost.AutoSize = true;
            this.Ghost.Location = new System.Drawing.Point(2, 68);
            this.Ghost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(35, 13);
            this.Ghost.TabIndex = 2;
            this.Ghost.Text = "Ghost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghoul";
            // 
            // PlayerHitPoints
            // 
            this.PlayerHitPoints.AutoSize = true;
            this.PlayerHitPoints.Location = new System.Drawing.Point(66, 0);
            this.PlayerHitPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerHitPoints.Name = "PlayerHitPoints";
            this.PlayerHitPoints.Size = new System.Drawing.Size(0, 13);
            this.PlayerHitPoints.TabIndex = 4;
            this.PlayerHitPoints.Click += new System.EventHandler(this.PlayerHitPoints_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player";
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(53, 9);
            this.MoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(84, 28);
            this.MoveUp.TabIndex = 16;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(10, 46);
            this.MoveLeft.Margin = new System.Windows.Forms.Padding(2);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(84, 28);
            this.MoveLeft.TabIndex = 17;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(109, 44);
            this.MoveRight.Margin = new System.Windows.Forms.Padding(2);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(84, 28);
            this.MoveRight.TabIndex = 18;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(53, 78);
            this.MoveDown.Margin = new System.Windows.Forms.Padding(2);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(84, 28);
            this.MoveDown.TabIndex = 19;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Attack";
            // 
            // AttachUp
            // 
            this.AttachUp.Location = new System.Drawing.Point(50, 15);
            this.AttachUp.Margin = new System.Windows.Forms.Padding(2);
            this.AttachUp.Name = "AttachUp";
            this.AttachUp.Size = new System.Drawing.Size(84, 28);
            this.AttachUp.TabIndex = 21;
            this.AttachUp.Text = "Up";
            this.AttachUp.UseVisualStyleBackColor = true;
            this.AttachUp.Click += new System.EventHandler(this.AttachUp_Click);
            // 
            // AttachLeft
            // 
            this.AttachLeft.Location = new System.Drawing.Point(7, 51);
            this.AttachLeft.Margin = new System.Windows.Forms.Padding(2);
            this.AttachLeft.Name = "AttachLeft";
            this.AttachLeft.Size = new System.Drawing.Size(84, 28);
            this.AttachLeft.TabIndex = 22;
            this.AttachLeft.Text = "Left";
            this.AttachLeft.UseVisualStyleBackColor = true;
            this.AttachLeft.Click += new System.EventHandler(this.AttachLeft_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Location = new System.Drawing.Point(106, 47);
            this.AttackRight.Margin = new System.Windows.Forms.Padding(2);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(84, 28);
            this.AttackRight.TabIndex = 23;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Location = new System.Drawing.Point(50, 83);
            this.AttackDown.Margin = new System.Windows.Forms.Padding(2);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(84, 28);
            this.AttackDown.TabIndex = 24;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MoveUp);
            this.panel1.Controls.Add(this.MoveLeft);
            this.panel1.Controls.Add(this.MoveRight);
            this.panel1.Controls.Add(this.MoveDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(602, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 116);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AttachUp);
            this.panel2.Controls.Add(this.AttackRight);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AttackDown);
            this.panel2.Controls.Add(this.AttachLeft);
            this.panel2.Location = new System.Drawing.Point(605, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 121);
            this.panel2.TabIndex = 26;
            // 
            // Ghoul
            // 
            this.Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.Ghoul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ghoul.BackgroundImage")));
            this.Ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ghoul.Location = new System.Drawing.Point(351, 130);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(30, 30);
            this.Ghoul.TabIndex = 27;
            this.Ghoul.TabStop = false;
            // 
            // Ghostt
            // 
            this.Ghostt.BackColor = System.Drawing.Color.Transparent;
            this.Ghostt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ghostt.BackgroundImage")));
            this.Ghostt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ghostt.Location = new System.Drawing.Point(447, 185);
            this.Ghostt.Name = "Ghostt";
            this.Ghostt.Size = new System.Drawing.Size(30, 30);
            this.Ghostt.TabIndex = 28;
            this.Ghostt.TabStop = false;
            // 
            // SwordButton
            // 
            this.SwordButton.BackColor = System.Drawing.Color.Transparent;
            this.SwordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwordButton.BackgroundImage")));
            this.SwordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwordButton.Location = new System.Drawing.Point(82, 325);
            this.SwordButton.Name = "SwordButton";
            this.SwordButton.Size = new System.Drawing.Size(50, 50);
            this.SwordButton.TabIndex = 29;
            this.SwordButton.TabStop = false;
            this.SwordButton.Click += new System.EventHandler(this.SwordButton_Click);
            // 
            // BowButton
            // 
            this.BowButton.BackColor = System.Drawing.Color.Transparent;
            this.BowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BowButton.BackgroundImage")));
            this.BowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BowButton.Location = new System.Drawing.Point(160, 325);
            this.BowButton.Name = "BowButton";
            this.BowButton.Size = new System.Drawing.Size(50, 50);
            this.BowButton.TabIndex = 30;
            this.BowButton.TabStop = false;
            this.BowButton.Click += new System.EventHandler(this.BowButton_Click);
            // 
            // MaceButton
            // 
            this.MaceButton.BackColor = System.Drawing.Color.Transparent;
            this.MaceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaceButton.BackgroundImage")));
            this.MaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaceButton.Location = new System.Drawing.Point(244, 325);
            this.MaceButton.Name = "MaceButton";
            this.MaceButton.Size = new System.Drawing.Size(50, 50);
            this.MaceButton.TabIndex = 31;
            this.MaceButton.TabStop = false;
            this.MaceButton.Click += new System.EventHandler(this.MaceButton_Click);
            // 
            // RedPotionButton
            // 
            this.RedPotionButton.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RedPotionButton.BackgroundImage")));
            this.RedPotionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedPotionButton.Location = new System.Drawing.Point(331, 325);
            this.RedPotionButton.Name = "RedPotionButton";
            this.RedPotionButton.Size = new System.Drawing.Size(50, 50);
            this.RedPotionButton.TabIndex = 32;
            this.RedPotionButton.TabStop = false;
            this.RedPotionButton.Click += new System.EventHandler(this.PotionRedButton_Click);
            // 
            // BluePotionButton
            // 
            this.BluePotionButton.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BluePotionButton.BackgroundImage")));
            this.BluePotionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BluePotionButton.Location = new System.Drawing.Point(427, 325);
            this.BluePotionButton.Name = "BluePotionButton";
            this.BluePotionButton.Size = new System.Drawing.Size(50, 50);
            this.BluePotionButton.TabIndex = 33;
            this.BluePotionButton.TabStop = false;
            this.BluePotionButton.Click += new System.EventHandler(this.BluePotionButton_Click);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(813, 396);
            this.Controls.Add(this.BluePotionButton);
            this.Controls.Add(this.RedPotionButton);
            this.Controls.Add(this.MaceButton);
            this.Controls.Add(this.BowButton);
            this.Controls.Add(this.SwordButton);
            this.Controls.Add(this.Ghostt);
            this.Controls.Add(this.Ghoul);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Bow);
            this.Controls.Add(this.Sword);
            this.Controls.Add(this.RedPotion);
            this.Controls.Add(this.BluePotion);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Mace);
            this.Controls.Add(this.Bat);
            this.Name = "QuestForm";
            this.Text = "QuestForm";
            this.Load += new System.EventHandler(this.QuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghostt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bat;
        private PictureBox Mace;
        private PictureBox Player;
        private PictureBox BluePotion;
        private PictureBox RedPotion;
        private PictureBox Sword;
        private PictureBox Bow;
        private TableLayoutPanel tableLayoutPanel1;
        private Button MoveUp;
        private Button MoveLeft;
        private Button MoveRight;
        private Button MoveDown;
        private Label label2;
        private Button AttachUp;
        private Button AttachLeft;
        private Button AttackRight;
        private Button AttackDown;
        private Label label3;
        private Label label4;
        private Label Ghost;
        private Label label5;
        private Label GhoulHitsPoint;
        private Label GhostHitPoints;
        private Label BatHitsPoint;
        private Label PlayerHitPoints;
        private Panel panel1;
        private Panel panel2;
        private PictureBox Ghoul;
        private PictureBox Ghostt;
        private PictureBox SwordButton;
        private PictureBox BowButton;
        private PictureBox MaceButton;
        private PictureBox RedPotionButton;
        private PictureBox BluePotionButton;
    }
}

