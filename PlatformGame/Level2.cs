using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class Level2 : Form
    {
        bool goLeft, goRight, jump, haveScrewdriver;
        // Скорость прыжка
        int jumpSpeed = 8;
        // Сила прыжка
        int force = 8;
        // Скорость перемещения игрока (вперед-назад)
        int playerSpeed = 8;
        // Скорость движения фона
        int backgroundSpeed = 8;
        // Скорость перемещения движущегося врага
        int movingEnemySpeed = 3;
        // Скорость перемещения платформы, движущейся в вертикальном направлении
        int verticalSpeed = 2;

        public Level2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для перемещения всех игровых элементов в зависимости от хода игрока
        /// </summary>
        /// <param name="direction">Направление перемещения игрока</param>
        private void MoveGameElements(string direction)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "screwdriver" || x is PictureBox && (string)x.Tag == "exit"
                    || x is PictureBox && (string)x.Tag == "iceLake" || (x is PictureBox && (string)x.Tag == "enemy") || (x is PictureBox && (string)x.Tag == "verticalPlatform"))
                {
                    // Если направление "back", то перемещаем элемент влево
                    if (direction == "back")
                        x.Left -= backgroundSpeed;
                    // Если направление "forward", то перемещаем элемент вправо
                    if (direction == "forward")
                        x.Left += backgroundSpeed;
                }
            }
        }

        /// <summary>
        /// Метод - обработчик нажатий клавиш
        /// </summary>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space && jump == false)
                jump = true;
        }

        /// <summary>
        /// Метод - обработчик отпускания клавиш
        /// </summary>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (jump == true)
                jump = false;
        }

        /// <summary>
        /// Метод для обработки событий таймера
        /// </summary>
        private void MainTimerEvent(object sender, EventArgs e)
        {
            MovePlayer();
            DeadInConflict();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "verticalPlatform")
                {
                    // Если игрок дошел до платформы и не выполняет прыжок
                    if (player.Bounds.IntersectsWith(x.Bounds) && jump == false)
                    {
                        // Выполняется прыжок с заданным начальным ускорением
                        force = 8;
                        // Игрок перемещается на верхнюю границу платформы
                        player.Top = x.Top - player.Height;
                        // Скорость прыжка обнуляется
                        jumpSpeed = 0;
                    }
                    // Платформа перемещается на передний план, на переднюю часть формы
                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "verticalPlatform")
                {
                    //Платформа, движущаяся в вкертикальном направлении перемещается вниз
                    x.Top -= verticalSpeed;
                    // Если платформа выходит за указанные границы, то меняем направление движения на противоположное
                    if (x.Top < 100 || x.Top + x.Height > 500)
                    {
                        verticalSpeed = -verticalSpeed;
                    }
                }
            }
            movingEnemy.Left -= movingEnemySpeed;
            // Если движущийся враг выходит за границы платформы, то меняем направление движения на противоположное
            if (movingEnemy.Left < platformWithMovingEnemy.Left || movingEnemy.Left + movingEnemy.Width > platformWithMovingEnemy.Right)
            {
                movingEnemySpeed = -movingEnemySpeed;
            }
            // Если игрок дошел до отвертки, то молот исчезает и устанавливается флаг haveScrewdriver в true
            if (player.Bounds.IntersectsWith(screwdriver.Bounds))
            {
                screwdriver.Visible = false;
                haveScrewdriver = true;
            }
            // Если игрок пересекается с выходом-порталом и флаг haveScrewdriver равен true, то останавливаем таймер и выводим сообщение о прохождении уровня, а затем перезапускаем игру
            if (player.Bounds.IntersectsWith(exit.Bounds) && haveScrewdriver == true)
            {
                gameTimer.Stop();
                MessageBox.Show("Вы починили портал! " + Environment.NewLine + "Уровень пройден");
                Level2 level2 = new Level2();
                level2.Show();
            }
        }

        /// <summary>
        /// Метод, вызывающийся при столкновении со смертельно опасными объектами
        /// </summary>
        void DeadInConflict()
        {
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "enemy")
                {
                    // Если игрок столкнулся с врагом
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Image = Properties.Resources.player1_fall;
                        gameTimer.Stop();
                        // Показывается сообщение о конце игры и предлагается её перезапустить
                        MessageBox.Show("Вы умерли!" + Environment.NewLine + "Нажмите OK, чтобы играть заново");
                        RestartGame();
                    }
                }
            }
            // Если игрок упал вниз за пределы формы, то останавливаем таймер, выводим сообщение о поражении и перезапускаем игру
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                player.Image = Properties.Resources.player1_fall;
                gameTimer.Stop();
                MessageBox.Show("Вы утонули в болоте!" + Environment.NewLine + "Нажмите OK, чтобы играть заново");
                RestartGame();
            }
        }

        /// <summary>
        /// Метод для перемещения игрока
        /// </summary>
        private void MovePlayer()
        {
            // Перемещаем игрока вверх с заданной скоростью прыжка
            player.Top += jumpSpeed;

            // Если направление движения игрока влево и он находится не в начале поля, то перемещаем его влево с заданной скоростью
            if (goLeft == true && player.Left > 60)
                player.Left -= playerSpeed;
            // Если направление движения игрока влево и он находится не в конце поля, то перемещаем его вправо с заданной скоростью
            if (goRight == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
                player.Left += playerSpeed;

            // Если направление движения игрока влево и фон движется вправо, то передвигаем фон влево и перемещаем все игровые элементы вправо
            if (goLeft == true && background.Left < 0)
            {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
                player.Image = Properties.Resources.player1_left;
            }
            // Если направление движения игрока вправо и фон движется влево, то передвигаем фон вправо и перемещаем все игровые элементы влево
            if (goRight == true && background.Left > -1372)
            {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
                player.Image = Properties.Resources.player1;
            }

            if (jump == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
                jumpSpeed = 12;

            if (jump == true && force < 0)
                jump = false;
            if (player.Bounds.IntersectsWith(teleportPlatform1.Bounds))
            {
                player.Top = teleportPlatform2.Top + player.Height;
                player.Left = teleportPlatform2.Left;
            }
        }

        /// <summary>
        /// Метод - обработчик закрытия игры
        /// </summary>
        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Метод перезапуска игры
        /// </summary>
        private void RestartGame()
        {
            Level2 newWindow = new Level2();
            newWindow.ShowDialog();
        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }

        private void Level2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
