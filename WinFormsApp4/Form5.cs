using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp4
{

    public partial class Cup : Form
    {
        private int _numShuffles = 1;
        private int _winningImageIndex;
        private PictureBox[] pictureBox;
        private Image[] images;

        public Cup()
        {
            InitializeComponent();

            pictureBox = new PictureBox[]
{
    cup1,
    cup2,
    cup3
};
            // Загрузить изображения наперстков
            images = new Image[]
            {
                Image.FromFile("Boll.png"),
                Image.FromFile("rer.png")
            };

            // Установить изображения на PictureBox
            for (int i = 0; i < 3; i++)
            {
                pictureBox[i].Image = images[1];
            }

            // Случайно выбрать выигрышный наперсток
            _winningImageIndex = new Random().Next(3);
        }



        private void cup3_Click(object sender, EventArgs e)
        {
            // Проверить, выбран ли выигрышный наперсток
            if (sender == pictureBox[_winningImageIndex])
            {
                // Выиграть игру
                labelStatus.Text = "Вы выиграли!";
            }
            else
            {
                // Проиграть игру
                labelStatus.Text = "Вы проиграли!";
            }
        }

        private void cup2_Click(object sender, EventArgs e)
        {
            // Проверить, выбран ли выигрышный наперсток
            if (sender == pictureBox[_winningImageIndex])
            {
                // Выиграть игру
                labelStatus.Text = "Вы выиграли!";
            }
            else
            {
                // Проиграть игру
                labelStatus.Text = "Вы проиграли!";
            }
        }

        private void cup1_Click(object sender, EventArgs e)
        {
            // Проверить, выбран ли выигрышный наперсток
            if (sender == pictureBox[_winningImageIndex])
            {
                // Выиграть игру
                labelStatus.Text = "Вы выиграли!";
            }
            else
            {
                // Проиграть игру
                labelStatus.Text = "Вы проиграли!";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Показать выигрышный наперсток на 500 миллисекунд
            pictureBox[_winningImageIndex].Image = images[0];
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            pictureBox[_winningImageIndex].Image = images[1];

            // Перемешать наперстки в случайном порядке _numShuffles раз
            for (int i = 0; i < _numShuffles; i++)
            {
                // Перемешать позиции наперстков
                for (int j = 0; j < 2; j++)
                {
                    int index1 = new Random().Next(3);
                    int index2 = new Random().Next(3);
                    int index3 = new Random().Next(3);
                    while (index1 == index2 || index3 == index2 || index1 == index3)
                    {
                        index2 = new Random().Next(3);
                        index1 = new Random().Next(3);
                        index3 = new Random().Next(3);
                    }

                    // Переместить PictureBox
                    Point location1 = pictureBox[index1].Location;
                    Point location2 = pictureBox[index2].Location;
                    Point location3 = pictureBox[index3].Location;

                    // Анимация перемещения
                    for (int k = 0; k < 5; k++)
                    {
                        // Рассчитать промежуточное положение
                        float t = (float)k / 5;
                        float x = (1 - t) * location1.X + t * location2.X;
                        float y = (1 - t) * location1.Y + t * location2.Y;
                        // Установить положение PictureBox
                        pictureBox[index1].Location = new Point(((int)x), (int)y);
                        pictureBox[index2].Location = new Point(((int)x), (int)y);
                        pictureBox[index3].BringToFront();

                        // Ожидать 100 миллисекунд
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }

                    // Установить окончательное положение
                    pictureBox[index1].Location = location2;
                    pictureBox[index2].Location = location1;
                    pictureBox[index3].Location = location3;


                }
            }

            // Увеличить количество перемешиваний на 1
            _numShuffles++;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            Hide();
        }
    }
}

