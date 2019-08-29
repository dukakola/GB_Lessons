using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Отображать минимальное количество ходов для выигрыша

//1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//   б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
//   в) * Добавить кнопку «Отменить», которая отменяет последние ходы.

// Трифонов Александр


namespace Work_01
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            InitializeComponent();
        }
        public void HideButtons()
        {
            btnMulti.Enabled = false;
            btnPlus.Enabled = false;
            btnReset.Enabled = false;
            btnReturn.Enabled = false;
        }
        public void ShowButtons()
        {
            btnMulti.Enabled = true;
            btnPlus.Enabled = true;
            btnReset.Enabled = true;
            btnReturn.Enabled = true;
        }
        public void GoodMessage()
        {
            MessageBox.Show("Поздравляю, Вы выиграли!");
            doubler.Reset();
            HideButtons();
        }
        public void BadMessage()
        {
            MessageBox.Show("Вы проиграли.");
            doubler.Reset();
            HideButtons();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HideButtons();
        }
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler = new Doubler(new Random().Next(1,100));
            lblToGoValue.Text = doubler.ToGo.ToString();
            lblCurrentValue.Text = doubler.Current.ToString();
            lblCountMove.Text = doubler.Move.ToString();
            MessageBox.Show($"Цель - получить число: {doubler.ToGo.ToString()}");
            ShowButtons();
        }
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            doubler.Plus();
            lblCurrentValue.Text = doubler.Current.ToString();
            lblCountMove.Text = doubler.Move.ToString();

            if (doubler.Current > doubler.ToGo)
            {
                BadMessage();
            }
            if (doubler.Current == doubler.ToGo)
            {
                GoodMessage();
            }
        }
        private void BtnMulti_Click(object sender, EventArgs e)
        {
            doubler.Multi();
            lblCurrentValue.Text = doubler.Current.ToString();
            lblCountMove.Text = doubler.Move.ToString();

            if (doubler.Current > doubler.ToGo)
            {
                BadMessage();
            }
            if (doubler.Current == doubler.ToGo)
            {
                GoodMessage();
            }         
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            lblCurrentValue.Text = doubler.Current.ToString();
            lblCountMove.Text = doubler.Move.ToString();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            doubler.Current = doubler.Return;

            if (doubler.Current > doubler.ToGo)
            {
                BadMessage();
            }
            if (doubler.Current == doubler.ToGo)
            {
                GoodMessage();
            }
            lblCurrentValue.Text = doubler.Return.ToString();
        }
    }
}
