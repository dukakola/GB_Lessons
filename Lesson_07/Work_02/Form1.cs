using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек 
//    пытается его угадать за минимальное число попыток.Для ввода данных от человека используется элемент TextBox.
//
// Трифонов Александр
namespace Work_02
{
    public partial class Form1 : Form
    {
        RandomNumbers rannum;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTry.Enabled = false;
            txtUserAnswer.Enabled = false;
            btnHelp.Enabled = false;
        }

        private void НоваяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rannum = new RandomNumbers(new Random().Next(1, 100));
            btnTry.Enabled = true;
            txtUserAnswer.Enabled = true;
            btnHelp.Enabled = true;
            lblTryCount.Text = rannum.Try.ToString();
            txtUserAnswer.Clear();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTry_Click(object sender, EventArgs e)
        {
            rannum.TryCount();
            lblTryCount.Text = rannum.Try.ToString();

            if (txtUserAnswer.Text == rannum.Num.ToString())
            {
                MessageBox.Show("Поздравляю, вы угадали!");
                rannum.Reset();
                btnTry.Enabled = false;
                txtUserAnswer.Enabled = false;
                btnHelp.Enabled = false;
            }

            if (rannum.Try == 0)
            {
                MessageBox.Show($"Вы проиграли. \nЗагаданное число {rannum.Num.ToString()}.");
                rannum.Reset();
                btnTry.Enabled = false;
                txtUserAnswer.Enabled = false;
                btnHelp.Enabled = false;
            }

            txtUserAnswer.Clear();
        }

        private void TxtUserAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnTry_Click(this, new EventArgs());
                txtUserAnswer.Clear();
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Загаданное число {rannum.Num}");
        }
    }
}
