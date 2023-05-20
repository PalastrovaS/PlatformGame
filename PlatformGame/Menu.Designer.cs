namespace PlatformGame
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startBotton = new PictureBox();
            exitBotton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)startBotton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBotton).BeginInit();
            SuspendLayout();
            // 
            // startBotton
            // 
            startBotton.Image = Properties.Resources.start_green;
            startBotton.Location = new Point(153, 127);
            startBotton.Name = "startBotton";
            startBotton.Size = new Size(264, 128);
            startBotton.SizeMode = PictureBoxSizeMode.StretchImage;
            startBotton.TabIndex = 0;
            startBotton.TabStop = false;
            startBotton.Click += startBotton_Click;
            startBotton.MouseLeave += startBotton_MouseLeave;
            startBotton.MouseHover += startBotton_MouseHover;
            // 
            // exitBotton
            // 
            exitBotton.Image = Properties.Resources.exit_green;
            exitBotton.Location = new Point(530, 127);
            exitBotton.Name = "exitBotton";
            exitBotton.Size = new Size(264, 128);
            exitBotton.SizeMode = PictureBoxSizeMode.StretchImage;
            exitBotton.TabIndex = 1;
            exitBotton.TabStop = false;
            exitBotton.Click += exitBotton_Click;
            exitBotton.MouseLeave += exitBotton_MouseLeave;
            exitBotton.MouseHover += exitBotton_MouseHover;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Заставка;
            ClientSize = new Size(938, 577);
            Controls.Add(exitBotton);
            Controls.Add(startBotton);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)startBotton).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBotton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox startBotton;
        private PictureBox exitBotton;
    }
}