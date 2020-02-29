namespace Platformer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.tmrGrav = new System.Windows.Forms.Timer(this.components);
            this.tmrX = new System.Windows.Forms.Timer(this.components);
            this.rightBound = new System.Windows.Forms.PictureBox();
            this.deadZone = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.tmrPlatform = new System.Windows.Forms.Timer(this.components);
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.platform6 = new System.Windows.Forms.PictureBox();
            this.tmrBadPlatform = new System.Windows.Forms.Timer(this.components);
            this.badWall1 = new System.Windows.Forms.PictureBox();
            this.badWall2 = new System.Windows.Forms.PictureBox();
            this.badBullet1 = new System.Windows.Forms.PictureBox();
            this.badBullet2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badBullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badBullet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Lime;
            this.ground.Location = new System.Drawing.Point(-32, 484);
            this.ground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1048, 100);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(215, 367);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(49, 50);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // tmrGrav
            // 
            this.tmrGrav.Enabled = true;
            this.tmrGrav.Interval = 10;
            this.tmrGrav.Tick += new System.EventHandler(this.TmrGrav_Tick);
            // 
            // tmrX
            // 
            this.tmrX.Enabled = true;
            this.tmrX.Interval = 10;
            this.tmrX.Tick += new System.EventHandler(this.TmrX_Tick);
            // 
            // rightBound
            // 
            this.rightBound.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBound.Location = new System.Drawing.Point(963, 0);
            this.rightBound.Margin = new System.Windows.Forms.Padding(4);
            this.rightBound.Name = "rightBound";
            this.rightBound.Size = new System.Drawing.Size(13, 558);
            this.rightBound.TabIndex = 2;
            this.rightBound.TabStop = false;
            // 
            // deadZone
            // 
            this.deadZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deadZone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deadZone.BackgroundImage")));
            this.deadZone.Dock = System.Windows.Forms.DockStyle.Left;
            this.deadZone.ErrorImage = global::Platformer.Properties.Resources.output_onlinepngtools;
            this.deadZone.Location = new System.Drawing.Point(0, 0);
            this.deadZone.Margin = new System.Windows.Forms.Padding(4);
            this.deadZone.Name = "deadZone";
            this.deadZone.Size = new System.Drawing.Size(132, 558);
            this.deadZone.TabIndex = 3;
            this.deadZone.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 510);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 28);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(139, 211);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(732, 69);
            this.start.TabIndex = 5;
            this.start.Text = "Press Space to start game";
            // 
            // tmrPlatform
            // 
            this.tmrPlatform.Enabled = true;
            this.tmrPlatform.Interval = 10;
            this.tmrPlatform.Tick += new System.EventHandler(this.TmrPlatform_Tick);
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.Lime;
            this.platform1.Location = new System.Drawing.Point(151, 68);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(100, 50);
            this.platform1.TabIndex = 6;
            this.platform1.TabStop = false;
            this.platform1.Visible = false;
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.Lime;
            this.platform2.Location = new System.Drawing.Point(151, 180);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(100, 50);
            this.platform2.TabIndex = 7;
            this.platform2.TabStop = false;
            this.platform2.Visible = false;
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.Lime;
            this.platform3.Location = new System.Drawing.Point(151, 124);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(100, 50);
            this.platform3.TabIndex = 8;
            this.platform3.TabStop = false;
            this.platform3.Visible = false;
            // 
            // platform4
            // 
            this.platform4.BackColor = System.Drawing.Color.Lime;
            this.platform4.Location = new System.Drawing.Point(283, 68);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(100, 50);
            this.platform4.TabIndex = 9;
            this.platform4.TabStop = false;
            this.platform4.Visible = false;
            // 
            // platform5
            // 
            this.platform5.BackColor = System.Drawing.Color.Lime;
            this.platform5.Location = new System.Drawing.Point(283, 124);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(100, 50);
            this.platform5.TabIndex = 10;
            this.platform5.TabStop = false;
            this.platform5.Visible = false;
            // 
            // platform6
            // 
            this.platform6.BackColor = System.Drawing.Color.Lime;
            this.platform6.Location = new System.Drawing.Point(283, 180);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(100, 50);
            this.platform6.TabIndex = 11;
            this.platform6.TabStop = false;
            this.platform6.Visible = false;
            // 
            // tmrBadPlatform
            // 
            this.tmrBadPlatform.Enabled = true;
            this.tmrBadPlatform.Interval = 10;
            this.tmrBadPlatform.Tick += new System.EventHandler(this.TmrBadPlatform_Tick);
            // 
            // badWall1
            // 
            this.badWall1.BackColor = System.Drawing.Color.Red;
            this.badWall1.Location = new System.Drawing.Point(151, 12);
            this.badWall1.Name = "badWall1";
            this.badWall1.Size = new System.Drawing.Size(100, 50);
            this.badWall1.TabIndex = 12;
            this.badWall1.TabStop = false;
            // 
            // badWall2
            // 
            this.badWall2.BackColor = System.Drawing.Color.Red;
            this.badWall2.Location = new System.Drawing.Point(283, 12);
            this.badWall2.Name = "badWall2";
            this.badWall2.Size = new System.Drawing.Size(100, 50);
            this.badWall2.TabIndex = 13;
            this.badWall2.TabStop = false;
            // 
            // badBullet1
            // 
            this.badBullet1.BackColor = System.Drawing.Color.Red;
            this.badBullet1.Location = new System.Drawing.Point(399, 12);
            this.badBullet1.Name = "badBullet1";
            this.badBullet1.Size = new System.Drawing.Size(36, 34);
            this.badBullet1.TabIndex = 14;
            this.badBullet1.TabStop = false;
            // 
            // badBullet2
            // 
            this.badBullet2.BackColor = System.Drawing.Color.Red;
            this.badBullet2.Location = new System.Drawing.Point(455, 12);
            this.badBullet2.Name = "badBullet2";
            this.badBullet2.Size = new System.Drawing.Size(36, 34);
            this.badBullet2.TabIndex = 15;
            this.badBullet2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(976, 558);
            this.Controls.Add(this.badBullet2);
            this.Controls.Add(this.badBullet1);
            this.Controls.Add(this.badWall2);
            this.Controls.Add(this.badWall1);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.start);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.deadZone);
            this.Controls.Add(this.rightBound);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(994, 605);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(994, 605);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Side Jumper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badBullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badBullet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer tmrGrav;
        private System.Windows.Forms.Timer tmrX;
        private System.Windows.Forms.PictureBox rightBound;
        private System.Windows.Forms.PictureBox deadZone;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Timer tmrPlatform;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox platform5;
        private System.Windows.Forms.PictureBox platform6;
        private System.Windows.Forms.Timer tmrBadPlatform;
        private System.Windows.Forms.PictureBox badWall1;
        private System.Windows.Forms.PictureBox badWall2;
        private System.Windows.Forms.PictureBox badBullet1;
        private System.Windows.Forms.PictureBox badBullet2;
    }
}

