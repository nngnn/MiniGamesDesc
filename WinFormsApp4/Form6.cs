using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp4
{
    public partial class Num : Form
    {
        private List<TextBox> editTexts;
        private List<TextBox> editText;
        private int quantity = 3;
        private int Long = 1;
        private int scope = 0;
        private int[] numbers;
        public Num()
        {
            InitializeComponent();
            List<TextBox> editTexts = new List<TextBox>();
            editTexts.Add(textBox1);
            editTexts.Add(textBox2);
            editTexts.Add(textBox3);
            editTexts.Add(textBox4);
            editTexts.Add(textBox5);
            editTexts.Add(textBox6);
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

        }



        private void showToast(string message)
        {
            MessageBox.Show(message, "Важная информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static int[] GenerateRandomNumbers(int length)
        {
            var numbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                int temp = new Random().Next(0, 10);
                numbers.Add(temp);
            }
            return numbers.ToArray();
        }

        public static List<TextBox> ChooseEditTexts(int l, List<TextBox> EditTexts)
        {
            var chosenEditTexts = new List<TextBox>();
            var chosenIndexes = new HashSet<int>();

            for (int i = 0; i < l; i++)
            {
                int chosenIndex = -1;

                do
                {
                    chosenIndex = new Random().Next(6);
                } while (chosenIndexes.Contains(chosenIndex));

                chosenIndexes.Add(chosenIndex);
                chosenEditTexts.Add(EditTexts[chosenIndex]);
            }

            return chosenEditTexts;
        }

        private async void buttonRun_Click_1(object sender, EventArgs e)
        {
            List<TextBox> editTexts = new List<TextBox>();
            editTexts.Add(textBox1);
            editTexts.Add(textBox2);
            editTexts.Add(textBox3);
            editTexts.Add(textBox4);
            editTexts.Add(textBox5);
            editTexts.Add(textBox6);
            editTexts[0].Text = "";
            editTexts[1].Text = "";
            editTexts[2].Text = "";
            editTexts[3].Text = "";
            editTexts[4].Text = "";
            editTexts[5].Text = "";
            // Generate random numbers
            numbers = GenerateRandomNumbers(quantity * Long);

            // Choose EditTexts
            editText = ChooseEditTexts(quantity, editTexts);

            // Add numbers to EditTexts
            for (int i = 0; i < quantity; i += Long)
            {
                for (int j = i; j < i + Long; j++)
                {
                    editText[i / Long].Text += numbers[j];
                }
                editText[i / Long].Enabled = true;
            }

            // Disable Run button and enable Check button
            buttonRun.Enabled = false;
            buttonRun.Visible = false;
            buttonCheck.Enabled = true;
            buttonCheck.Visible = true;

            await Task.Delay(1000);
            editTexts[0].Text = "";
            editTexts[1].Text = "";
            editTexts[2].Text = "";
            editTexts[3].Text = "";
            editTexts[4].Text = "";
            editTexts[5].Text = "";
        }

        private void buttonCheck_Click_1(object sender, EventArgs e)
        {
            // Check user's answer
            int correctAnswer = 0;
            for (int i = 0; i < quantity; i += Long)
            {
                string text = editText[i / Long].Text;
                string expectedText = "";
                for (int j = i; j < i + Long; j++)
                {
                    expectedText += numbers[j];
                }

                if (text == expectedText)
                {
                    correctAnswer++;
                }
                editText[i / Long].Enabled = false;
            }

            // Check if the answer is correct
            if (correctAnswer == quantity)
            {
                // Increment scope and level
                scope++;
                if (quantity != 6)
                {
                    quantity++;
                }
                else
                {
                    Long++;
                }

                // Display success message
                showToast("Вы перешли на следующий этап");
            }
            else
            {
                // Display fail message
                showToast("Вы проиграли!" + "Ваш счет " + scope);

                // Reset scope and level
                scope = 0;
                quantity = 3;
                Long = 1;
            }


            buttonRun.Enabled = true;
            buttonRun.Visible = true;
            buttonCheck.Enabled = false;
            buttonCheck.Visible = false;
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            Hide();
        }
    }
}
