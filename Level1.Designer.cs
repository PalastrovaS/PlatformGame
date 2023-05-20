namespace PlatformGame
{
    partial class Level1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.hammer = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.horizontalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox17.Location = new System.Drawing.Point(437, 307);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(188, 40);
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "platform";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.enemy.Image = ((System.Drawing.Image)(resources.GetObject("enemy.Image")));
            this.enemy.Location = new System.Drawing.Point(538, 269);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(50, 50);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy.TabIndex = 27;
            this.enemy.TabStop = false;
            this.enemy.Tag = "enemy";
            this.enemy.Click += new System.EventHandler(this.enemy_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox14.Location = new System.Drawing.Point(1856, 236);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(102, 40);
            this.pictureBox14.TabIndex = 26;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "platform";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox13.Location = new System.Drawing.Point(1507, 195);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(102, 40);
            this.pictureBox13.TabIndex = 25;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox10.Location = new System.Drawing.Point(1129, 348);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(102, 40);
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox5.Location = new System.Drawing.Point(1684, 315);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(102, 40);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.Enabled = false;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1, -3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(60, 100);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit.TabIndex = 22;
            this.exit.TabStop = false;
            this.exit.Tag = "exit";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Lime;
            this.pictureBox3.Location = new System.Drawing.Point(216, 658);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19002, 15);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "swamp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(929, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 40);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(91, 402);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 60);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 19;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.platform.Location = new System.Drawing.Point(1280, 109);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(102, 40);
            this.platform.TabIndex = 15;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // hammer
            // 
            this.hammer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hammer.BackgroundImage")));
            this.hammer.Image = ((System.Drawing.Image)(resources.GetObject("hammer.Image")));
            this.hammer.Location = new System.Drawing.Point(817, 29);
            this.hammer.Name = "hammer";
            this.hammer.Size = new System.Drawing.Size(40, 52);
            this.hammer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hammer.TabIndex = 14;
            this.hammer.TabStop = false;
            this.hammer.Tag = "hammer";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox12.Location = new System.Drawing.Point(787, 109);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(102, 40);
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "platform";
            // 
            // horizontalPlatform
            // 
            this.horizontalPlatform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.horizontalPlatform.Location = new System.Drawing.Point(929, 224);
            this.horizontalPlatform.Name = "horizontalPlatform";
            this.horizontalPlatform.Size = new System.Drawing.Size(102, 40);
            this.horizontalPlatform.TabIndex = 11;
            this.horizontalPlatform.TabStop = false;
            this.horizontalPlatform.Tag = "horizontalPlatform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox9.Location = new System.Drawing.Point(717, 430);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(102, 40);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox7.Location = new System.Drawing.Point(1, 131);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 40);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.platform1.Location = new System.Drawing.Point(179, 294);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(102, 40);
            this.platform1.TabIndex = 6;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox4.Location = new System.Drawing.Point(325, 462);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 40);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(1, 633);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ControlDark;
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Location = new System.Drawing.Point(1, -3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1638, 606);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1154, 310);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "enemy";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 671);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.hammer);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.horizontalPlatform);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.background);
            this.KeyPreview = true;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox horizontalPlatform;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox hammer;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer gameTimer;
    }
}

