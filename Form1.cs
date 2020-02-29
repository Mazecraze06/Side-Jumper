using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
        bool go = false;
        bool canJump = false;
        int up;
        bool right = false;
        bool left = false;
        int x = 0;
        float time = 0f;
        Random rnd = new Random();
        int platX = 2;
        int badPlatX = 7;
        int count = 2 ;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TmrGrav_Tick(object sender, EventArgs e)
        {
            if (go == true)
            {
                if (!player.Bounds.IntersectsWith(ground.Bounds)) { up -= 1; }
                else { up = 0; player.Top = ground.Top - player.Height; }
                if (player.Top == ground.Top - player.Height) { canJump = true; }
                player.Top -= up;
                player.Left += x;
                if (player.Bounds.IntersectsWith(rightBound.Bounds))
                {
                    x = 0;
                    player.Left = 650;
                    right = false;
                    x = -20;
                }
                time += 0.02f;
                lblScore.Visible = true;
                lblScore.BringToFront();
                lblScore.Text = "Score: " + Math.Round(time, 1);
                if (player.Bounds.IntersectsWith(deadZone.Bounds)) { go = false; MessageBox.Show("You died!\nYou survived for " + Math.Round(time, 1) + " seconds.\nThanks for playing Side Jumper", "Game Over"); this.Close(); }
                if (player.Bounds.IntersectsWith(badBullet1.Bounds)) { go = false; MessageBox.Show("You died!\nYou survived for " + Math.Round(time, 1) + " seconds.\nThanks for playing Side Jumper", "Game Over"); this.Close(); }
                if (player.Bounds.IntersectsWith(badBullet2.Bounds)) { go = false; MessageBox.Show("You died!\nYou survived for " + Math.Round(time, 1) + " seconds.\nThanks for playing Side Jumper", "Game Over"); this.Close(); }
                if (player.Bounds.IntersectsWith(badWall1.Bounds)) { go = false; MessageBox.Show("You died!\nYou survived for " + Math.Round(time, 1) + " seconds.\nThanks for playing Side Jumper", "Game Over"); this.Close(); }
                if (player.Bounds.IntersectsWith(badWall2.Bounds)) { go = false; MessageBox.Show("You died!\nYou survived for " + Math.Round(time, 1) + " seconds.\nThanks for playing Side Jumper", "Game Over"); this.Close(); }

                if (up < -1 ) { canJump = false; }
                platX = (count / (count / 2)) * 3;
                badPlatX = platX / 3;
                //platX = Math.Round(count / 40, 0);

                //ground.BringToFront();

                if (player.Bounds.IntersectsWith(platform1.Bounds)) { up = 1; canJump = true; }            // Platform 1 collision detection
                if (player.Bounds.IntersectsWith(platform1.Bounds) && player.Top != platform1.Top - player.Height) { player.Top = platform1.Top - player.Height; }

                if (player.Bounds.IntersectsWith(platform2.Bounds)) { up = 1; canJump = true; }           //Platform 2 collision detection
                if (player.Bounds.IntersectsWith(platform2.Bounds) && player.Top != platform2.Top - player.Height) { player.Top = platform2.Top - player.Height; }

                if (player.Bounds.IntersectsWith(platform3.Bounds)) { up = 1; canJump = true; }           //Platform 3 collision detection
                if (player.Bounds.IntersectsWith(platform3.Bounds) && player.Top != platform3.Top - player.Height) { player.Top = platform3.Top - player.Height; }

                if (player.Bounds.IntersectsWith(platform4.Bounds)) { up = 1; canJump = true; }          //Platform 4 collision detection
                if (player.Bounds.IntersectsWith(platform4.Bounds) && player.Top != platform4.Top - player.Height) { player.Top = platform4.Top - player.Height; }

                if (player.Bounds.IntersectsWith(platform5.Bounds)) { up = 1; canJump = true; }            //Platform 5 collision detection
                if (player.Bounds.IntersectsWith(platform5.Bounds) && player.Top != platform5.Top - player.Height) { player.Top = platform5.Top - player.Height; }

                if (player.Bounds.IntersectsWith(platform6.Bounds)) { up = 1; canJump = true; }            //Platform 6
                if (player.Bounds.IntersectsWith(platform6.Bounds) && player.Top != platform6.Top - player.Height) { player.Top = platform6.Top - player.Height; }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { go = true; start.Visible = false; }
            if (e.KeyCode == Keys.Up) { if (canJump == true) { up += 20; player.Top -= 5; canJump = false; } }
            if (e.KeyCode == Keys.Right){ right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void TmrX_Tick(object sender, EventArgs e)
        {   if (go == true)
            {
                if (right == true)
                {
                    if (x < 5) { x = 5; }
                    else { x += 1; }
                }
                if (left == true)
                {
                    if (x > -5) { x = -5; }
                    else { x -= 1; }
                }
                if (right == false && left == false)
                {
                    if (x > 0) { x -= 1; }
                    else if (x < 0) { x += 1; }
                    else { x = 0; }
                }
            }
        }

        private void TmrPlatform_Tick(object sender, EventArgs e)  // Good Platforms
        {
            if (go == true)
            {
                if (count < 1000)
                {
                    platform1.Visible = true;
                    platform2.Visible = false;
                    platform3.Visible = false;
                    platform4.Visible = false;
                    platform5.Visible = false;
                    platform6.Visible = false;
                    platform1.Left -= platX;
                }
                else if (count < 2000)
                {
                    platform1.Visible = true;
                    platform2.Visible = true;
                    platform3.Visible = false;
                    platform4.Visible = false;
                    platform5.Visible = false;
                    platform6.Visible = false;
                    platform1.Left -= platX;
                    platform2.Left -= platX;
                }
                else if (count < 2500)
                {
                    platform1.Visible = true;
                    platform2.Visible = true;
                    platform3.Visible = true;
                    platform4.Visible = false;
                    platform5.Visible = false;
                    platform6.Visible = false;
                    platform1.Left -= platX;
                    platform2.Left -= platX;
                    platform3.Left -= platX;
                }
                else if (count < 3000)
                {
                    platform1.Visible = true;
                    platform2.Visible = true;
                    platform3.Visible = true;
                    platform4.Visible = true;
                    platform5.Visible = false;
                    platform6.Visible = false;
                    platform1.Left -= platX;
                    platform2.Left -= platX;
                    platform3.Left -= platX;
                    platform4.Left -= platX;
                }
                else if (count < 3500)
                {
                    platform1.Visible = true;
                    platform2.Visible = true;
                    platform3.Visible = true;
                    platform4.Visible = true;
                    platform5.Visible = true;
                    platform6.Visible = false;
                    platform1.Left -= platX;
                    platform2.Left -= platX;
                    platform3.Left -= platX;
                    platform4.Left -= platX;
                    platform5.Left -= platX;
                }
                else if (count > 3499)
                {
                    platform1.Visible = true;
                    platform2.Visible = true;
                    platform3.Visible = true;
                    platform4.Visible = true;
                    platform5.Visible = true;
                    platform6.Visible = true;
                    platform1.Left -= platX;
                    platform2.Left -= platX;
                    platform3.Left -= platX;
                    platform4.Left -= platX;
                    platform5.Left -= platX;
                    platform6.Left -= platX;
                }
                count += 2;
                if (platform1.Bounds.IntersectsWith(deadZone.Bounds)) { platform1.Size = new Size(rnd.Next(100, 500), 25); platform1.Left = this.Width + platform1.Width; platform1.Top = rnd.Next(0, this.Height - ground.Height - platform1.Height); }
                if (platform2.Bounds.IntersectsWith(deadZone.Bounds)) { platform2.Size = new Size(rnd.Next(100, 500), 25); platform2.Left = this.Width + platform2.Width; platform2.Top = rnd.Next(0, this.Height - ground.Height - platform2.Height); }
                if (platform3.Bounds.IntersectsWith(deadZone.Bounds)) { platform3.Size = new Size(rnd.Next(100, 500), 25); platform3.Left = this.Width + platform3.Width; platform3.Top = rnd.Next(0, this.Height - ground.Height - platform3.Height); }
                if (platform4.Bounds.IntersectsWith(deadZone.Bounds)) { platform4.Size = new Size(rnd.Next(100, 500), 25); platform4.Left = this.Width + platform4.Width; platform4.Top = rnd.Next(0, this.Height - ground.Height - platform4.Height); }
                if (platform5.Bounds.IntersectsWith(deadZone.Bounds)) { platform5.Size = new Size(rnd.Next(100, 500), 25); platform5.Left = this.Width + platform5.Width; platform5.Top = rnd.Next(0, this.Height - ground.Height - platform5.Height); }
                if (platform6.Bounds.IntersectsWith(deadZone.Bounds)) { platform6.Size = new Size(rnd.Next(100, 500), 25); platform6.Left = this.Width + platform6.Width; platform6.Top = rnd.Next(0, this.Height - ground.Height - platform6.Height); }
                platX = rnd.Next(2,7);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            platform1.Visible = false;
            platform2.Visible = false;
            platform3.Visible = false;
            platform4.Visible = false;
            platform5.Visible = false;
            platform6.Visible = false;

            platform1.BringToFront();
            platform2.BringToFront();
            platform3.BringToFront();
            platform4.BringToFront();
            platform5.BringToFront();
            platform6.BringToFront();

            platform1.Left = this.Width;
            platform2.Left = this.Width;
            platform3.Left = this.Width;
            platform4.Left = this.Width;
            platform5.Left = this.Width;
            platform6.Left = this.Width;


            badBullet1.Visible = false;
            badBullet2.Visible = false;
            badWall1.Visible = false;
            badWall2.Visible = false;
            //platform5.Visible = false;
            //platform6.Visible = false;

            badBullet1.BringToFront();
            badBullet2.BringToFront();
            badWall1.BringToFront();
            badWall2.BringToFront();
            //platform5.BringToFront();
            //platform6.BringToFront();

            badBullet1.Left = this.Width;
            badBullet2.Left = this.Width;
            badWall1.Left = this.Width;
            badWall2.Left = this.Width;
            //platform5.Left = this.Width;
            //platform6.Left = this.Width;
        }

        private void TmrBadPlatform_Tick(object sender, EventArgs e)
        {   if (go == true)
            {
                if (badBullet1.Bounds.IntersectsWith(deadZone.Bounds)) { badBullet1.Left = this.Width + badBullet1.Width; badBullet1.Top = rnd.Next(0, this.Height - ground.Height - badBullet1.Height); }
                if (badBullet2.Bounds.IntersectsWith(deadZone.Bounds)) { badBullet2.Left = this.Width + badBullet2.Width; badBullet2.Top = rnd.Next(0, this.Height - ground.Height - badBullet2.Height); }
                if (badWall1.Bounds.IntersectsWith(deadZone.Bounds)) { badWall1.Left = this.Width + badWall1.Width; badWall1.Size = new Size(25, rnd.Next(50, 200)); badWall1.Top = rnd.Next(0, this.Height - ground.Height); }// - badWall1.Height); }
                if (badWall2.Bounds.IntersectsWith(deadZone.Bounds)) { badWall2.Left = this.Width + badWall2.Width;  badWall2.Size = new Size(25, rnd.Next(50, 500)); badWall2.Top = rnd.Next(0, this.Height - ground.Height); } // - badWall2.Height); }


                if (count < 1000)
                {
                    badBullet1.Visible = true;
                    badBullet2.Visible = false;
                    badWall1.Visible = false;
                    badWall2.Visible = false;
                    badBullet1.Left -= badPlatX;

                }
                else if (count < 2000)
                {
                    badBullet1.Visible = true;
                    badBullet2.Visible = true;
                    badWall1.Visible = false;
                    badWall2.Visible = false;
                    badBullet1.Left -= badPlatX;
                    badBullet2.Left -= badPlatX;


                }

                else if (count < 2000)
                {
                    badBullet1.Visible = true;
                    badBullet2.Visible = true;
                    badWall1.Visible = false;
                    badWall2.Visible = false;
                    badBullet1.Left -= badPlatX;
                    badBullet2.Left -= badPlatX;


                }
                else if (count < 2500)
                {
                    badBullet1.Visible = true;
                    badBullet2.Visible = true;
                    badWall1.Visible = true;
                    badWall2.Visible = false;
                    badBullet1.Left -= badPlatX;
                    badBullet2.Left -= badPlatX;
                    badWall1.Left -= badPlatX;

                }
                else
                {
                    badBullet1.Visible = true;
                    badBullet2.Visible = true;
                    badWall1.Visible = true;
                    badWall2.Visible = true;
                    badBullet1.Left -= badPlatX;
                    badBullet2.Left -= badPlatX;
                    badWall1.Left -= badPlatX;
                    badWall2.Left -= badPlatX;

                }
            }
        }
    }
}
