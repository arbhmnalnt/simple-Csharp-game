using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace space_shooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer crashMedia;
        PictureBox[] stars, bullets, enemies, enemiesBullets;
        int backgroundSpeed, playerSpeed, bulletSpeed, enemySpeed, enemiesBulletSpeed;
        Random rnd;
        Random num = new Random();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create WMP
            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            crashMedia = new WindowsMediaPlayer();
            //Load All songs
            gameMedia.URL = @"sounds\GameSong.mp3";
            shootMedia.URL = @"sounds\shoot.mp3";
            crashMedia.URL = @"sounds\boom.mp3";
            //Songs Setup
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootMedia.settings.volume = 1;
            crashMedia.settings.volume = 6;
            // Play main game sound
            gameMedia.controls.play();
            // game settings
            backgroundSpeed = 4;
            playerSpeed = 4;
            enemySpeed = 4;
            enemiesBulletSpeed = 4;
            bulletSpeed = 20;
            stars = new PictureBox[15];
            bullets = new PictureBox[2];
            enemies = new PictureBox[10];
            enemiesBullets = new PictureBox[10];
            // load the bullet image
            Image bullet = Image.FromFile(@"assests\all_assests\asserts\munition.png");
            // bullet settings
            for (int i=0; i < bullets.Length; i++) {
                bullets[i] = new PictureBox
                {
                    Size = new Size(8, 8),
                    Image = bullet,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None
                };
                // add bullets to the game form
                this.Controls.Add(bullets[i]);
            }

            

            // Load enemies  images
            Image enemy1 = Image.FromFile(@"assests\all_assests\asserts\E1.png");
            Image enemy2 = Image.FromFile(@"assests\all_assests\asserts\E2.png");
            Image enemy3 = Image.FromFile(@"assests\all_assests\asserts\E3.png");
            Image bos1 = Image.FromFile(@"assests\all_assests\asserts\Boss1.png");
            Image bos2 = Image.FromFile(@"assests\all_assests\asserts\Boss2.png");

            // enemy setting
            for (int i = 0; i<enemies.Length; i++) {
                enemies[i] = new PictureBox
                {
                    Size = new Size(40, 40),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None,
                    Visible = false,
                    Location = new Point((i + 1) * 50, -50)
                };
                this.Controls.Add(enemies[i]);
            }

            // every enemy image
            enemies[0].Image = bos1;
            enemies[1].Image = enemy1;
            enemies[2].Image = enemy2;
            enemies[3].Image = enemy3;
            enemies[4].Image = enemy2;
            enemies[5].Image = enemy1;
            enemies[6].Image = enemy3;
            enemies[7].Image = enemy2; 
            enemies[8].Image = enemy1;
            enemies[9].Image = bos2;

            //enemy bullets setting

            for (int i = 0; i < enemiesBullets.Length; i++)
            {
                enemiesBullets[i] = new PictureBox();
                enemiesBullets[i].Size = new Size(2, 15);
                enemiesBullets[i].Visible = false;
                enemiesBullets[i].BackColor = Color.Red;
                int x = num.Next(0, 10);
                Console.WriteLine(x);
                enemiesBullets[i].Location = new Point(enemies[x].Location.X+20, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesBullets[i]);
            }

            rnd = new Random();
            for (int i = 0; i < stars.Length; i++) {
                stars[i] = new PictureBox
                {
                    BorderStyle = BorderStyle.None,
                    Location = new Point(rnd.Next(20, 520), rnd.Next(-10, 500))
                };
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.White;
                }
                else {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {
                MoveUp.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft.Start();
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MoveUp.Stop();
            MoveDown.Stop();
            MoveRight.Stop();
            MoveLeft.Stop();
        }

        private void MoveRight_Tick(object sender, EventArgs e)
        {
            if (Player.Left >= 10)
            {
                Player.Left += playerSpeed;
            }
            else {
                Player.Left = 15;
            }
            
            
        }

        private void MoveLeft_Tick(object sender, EventArgs e)
        {
            if (Player.Left < 490)
            {
                Player.Left -= playerSpeed;
            }
            else {
                Player.Left = 485;
            }
        }

        private void EnemyMoveTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemy(enemies, enemySpeed);
        }

        private void MoveBulletTimer_Tick(object sender, EventArgs e)
        {
            shootMedia.controls.play();
            for (int i=0; i < bullets.Length; i++) {
                if (bullets[i].Top > 0)
                {
                    
                    bullets[i].Visible = true;
                    bullets[i].Top -= bulletSpeed;
                    Crash();
                }
                else {
                    bullets[i].Visible = false;
                    int x = num.Next(0, 10);
                    bullets[i].Location = new Point(Player.Location.X+20, Player.Location.Y - i*30);
                }
            }
        }

        private void MoveDown_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top += playerSpeed;
            }
            else {
                Player.Top = 11;
            }
        }

        private void EnemyBulletTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesBullets.Length; i++)
            {
                if (enemiesBullets[i].Top < this.Height)
                {
                    enemiesBullets[i].Visible = true;
                    enemiesBullets[i].Top += enemiesBulletSpeed;
                }
                else {
                    
                    enemiesBullets[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesBullets[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                }
            }
        }

        private void MoveUp_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 480)
            {
                Player.Top -= playerSpeed;
            }
            
        }

        private void MoveEnemy(PictureBox[] array, int speed) {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height) 
                {
                    array[i].Location = new Point((i + 1) * 50, -50);
                }
            }

        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < stars.Length/2; i++) {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top >= this.Height ) {
                    stars[i].Top = -stars[i].Height;

                } 
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed/2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void Crash()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if ((bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))  || (bullets[1].Bounds.IntersectsWith(enemies[i].Bounds))) {
                    crashMedia.controls.play();
                    enemies[i].Location = new Point((i + 1) * 50, -50);
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds)) {
                    crashMedia.settings.volume = 30;
                    crashMedia.controls.play();
                    Player.Visible = false;
                    GameOver("");
                }

                if (Player.Bounds.IntersectsWith(enemiesBullets[i].Bounds))
                {
                    enemiesBullets[i].Visible = false;
                    crashMedia.settings.volume = 30;
                    crashMedia.controls.play();
                    Player.Visible = false;
                    GameOver("");
                }
            }
        }

        private void GameOver(string msg) {
            gameMedia.controls.stop();
            StopTimers();
        }

        private void StopTimers() {
            MoveBgTimer.Stop();
            EnemyMoveTimer.Stop();
            MoveBulletTimer.Stop();
            EnemyBulletTimer.Stop();
        }

        private void StartTimers() {
            MoveBgTimer.Start();
            EnemyMoveTimer.Start();
            MoveBulletTimer.Start();
            EnemyBulletTimer.Stop();
        }
    }
}
