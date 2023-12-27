using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp4
{
    public partial class Form4 : Form
    {
        #region GameInfo
        private bool blockClick = false;
        private PictureBox lastClickedPictureBox = null;
        private int points;
        private float time;
        private Image[] images = new Image[18];
        private const int side = 100;
        private const int between = 5;
        private Color defaultBackColor = Color.Gray;
        #endregion
        #region For Wrong Timer
        private PictureBox hide1 = null;
        private PictureBox hide2 = null;
        #endregion
        public Form4()
        {
            InitializeComponent();
            LoadImages();
            InitializePictureBoxes(Shuffle());
        }
        private void InitializePictureBoxes(int[,] inputTags)
        {
            int x = 0, y = 0;
            for (int i = 0; i < 6; i++)
            {
                y = between + i * (side + between);
                for (int j = 0; j < 6; j++)
                {
                    x = between + j * (side + between);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(side, side);
                    pictureBox.Location = new Point(x, y);
                    pictureBox.Tag = inputTags[i, j];
                    pictureBox.BackColor = defaultBackColor;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += ClickPictureBox;
                    pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    gamePanel.Controls.Add(pictureBox);
                }
            }
            gamePanel.Size = new Size(x + between + side, y + between + side);
        }

        private void ClickPictureBox(object senderObj, EventArgs e)
        {
            if (blockClick) return;
            PictureBox sender = (PictureBox)senderObj;
            if (sender == null || lastClickedPictureBox == sender || sender.Tag == null)
            {
                return;
            }
            int currentImageId = (int)sender.Tag;
            sender.Image = images[currentImageId];
            if (lastClickedPictureBox == null)
            {
                lastClickedPictureBox = sender;
                statusLabel.Text = "Выберите картинку";
                statusLabel.BackColor = Color.Gray;
            }
            else
            {
                int lastImageInfo = (int)lastClickedPictureBox.Tag;
                if (lastImageInfo == currentImageId)
                {
                    sender.Click -= ClickPictureBox;
                    lastClickedPictureBox.Click -= ClickPictureBox;
                    ballsLabel.Text = $"Очки: {++points}";
                    statusLabel.Text = "Верно!";
                    statusLabel.BackColor = Color.Green;
                    if (points >= 18)
                    {
                        gameTimer.Stop();
                        blockClick = true;
                        statusLabel.Text = "Победа!";
                        if (WinWrite())
                        {
                            new Menu().Show();
                        }
                        Close();
                    }
                }
                else
                {
                    statusLabel.Text = "Неверно! Ожидайте...";
                    statusLabel.BackColor = Color.Red;
                    blockClick = true;
                    hide1 = sender;
                    hide2 = lastClickedPictureBox;
                    wrongTimer.Start();
                }
                lastClickedPictureBox = null;
            }
        }

        private void LoadImages()
        {
            string[] paths = Directory.GetFiles("politics");
            if (paths.Length < 18)
            {
                MessageBox.Show("Требую больше картинок!");
                Close();
            }
            for (int i = 0; i < 18; i++)
            {
                images[i] = Image.FromFile(paths[i]);
            }
        }

        private int[,] Shuffle()
        {
            int[,] shuffleArray = new int[6, 6]
            {
                { 0, 0, 1, 1, 2, 2 },
                { 3, 3, 4, 4, 5, 5 },
                { 6, 6, 7, 7, 8, 8 },
                { 9, 9, 10, 10, 11, 11 },
                { 12, 12, 13, 13, 14, 14 },
                { 15, 15, 16, 16, 17, 17 }
            };
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int temp;
            for (int i = 0; i < random.Next(100, 500); i++)
            {
                int firstX = random.Next(0, 6);
                int firstY = random.Next(0, 6);
                int secondX = random.Next(0, 6);
                int secondY = random.Next(0, 6);
                temp = shuffleArray[firstX, firstY];
                shuffleArray[firstX, firstY] = shuffleArray[secondX, secondY];
                shuffleArray[secondX, secondY] = temp;
            }
            return shuffleArray;
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            time += 0.1F;
            if (time < 60)
            {
                timeLabel.Text = $"Время:\n{Math.Round(time, 1)} сек";
            }
            else
            {
                int mins = (int)time / 60;
                float secs = time % 60;
                timeLabel.Text = $"Время:\n{mins} мин {Math.Round(secs, 1)} сек";
            }
        }

        private void wrongTimer_Tick(object sender, EventArgs e)
        {
            hide1.Image = hide2.Image = null;
            statusLabel.Text = "Выберите картинку";
            statusLabel.BackColor = Color.Gray;
            blockClick = false;
            wrongTimer.Stop();
        }
        private bool WinWrite()
        {
            if (File.Exists("baze.db"))
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=baze.db;Version=3;"))
                {
                    connection.Open();
                    object readResult;
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"SELECT Time FROM Users WHERE Nickname = ;";
                        readResult = command.ExecuteScalar();
                    }
                    if (readResult == null || (long)readResult > (int)time)
                    {
                        using (SQLiteCommand command = connection.CreateCommand())
                        {
                            if (readResult == null)
                            {
                                command.CommandText = $"INSERT INTO Users(Nickname, Points, Time) VALUES({points}, {(int)time});";
                            }
                            else
                            {
                                command.CommandText = $"UPDATE Users SET Time={(int)time} WHERE Nickname = ;";
                            }
                            command.ExecuteNonQuery();
                        }
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Ваша победа не была зафиксирована, так как база данных не была найдена.", "Ошибка");
                return false;
            }
        }
        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            Hide();
        }

        private void wrongTimer_Tick_1(object sender, EventArgs e)
        {
            hide1.Image = hide2.Image = null;
            statusLabel.Text = "Выберите картинку";
            statusLabel.BackColor = Color.Gray;
            blockClick = false;
            wrongTimer.Stop();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
