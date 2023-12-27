using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info Check = new Info();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Check = new Form4();
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cup Check = new Cup();
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Num Check = new Num();
            Check.Show();
            Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu Check2 = new Menu();
            Info Check3 = new Info();
            Form4 Check4 = new Form4();
            Cup Check5 = new Cup();
            Num Check6 = new Num();
            Check2.Close();
            Check3.Close();
            Check4.Close();
            Check5.Close();
            Check6.Close();
        }
    }
}
