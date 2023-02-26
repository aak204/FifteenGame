using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FifteenGUI
{
    public partial class Fifteen : Form
    {
        private Game game;
        int count = 0;
        int seconds = 0;
        int minutes = 0;
        int ms = 0;
        public Fifteen()
        {
            InitializeComponent();
            game = new Game(4);

            RefreshButtonField();
        }
        private void GameStart()
        {
            timer1.Start();
            count = 0;
            label1.Text = "Счётчик ходов: " + count.ToString();
            game.Start();
            for (int j = 0; j < 20; j++)
                game.ShiftRandom();
            RefreshButtonField();

        }
        private void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                GetButton(position).Text = game.GetNumber(position).ToString();
                GetButton(position).Visible = (game.GetNumber(position) > 0);
            }
            if (game.Check())
            {
                timer1.Stop();
                seconds = 0;
                minutes = 0;
                ms = 0;
                label2.Text = "Время: " + minutes.ToString() + " минут  " + seconds.ToString() + " секунд";
                count = 0;
                label1.Text = "Счётчик ходов: " + count.ToString();
                DialogResult result = MessageBox.Show("Поздравляем, вы выиграли! Хотели бы вы сыграть еще раз?", "Победа!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    GameStart();
                else
                    this.Close();
            }
        }

        private Button GetButton(int index)
        {
            return Controls.Find("button" + index, true).FirstOrDefault() as Button;
        }



        private void startMenu_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void Fifteen_Load(object sender, EventArgs e)
        {
            GameStart();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Счётчик ходов: " + count.ToString();
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Shift(position);
            RefreshButtonField();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms / 10 > 0)
            {
                seconds++;
                ms = 0;
            }
            if (seconds / 60 > 0)
            {
                minutes++;
                seconds = 0;
            }
            label2.Text = "Время: " + minutes.ToString() + " минут  " + seconds.ToString() + " секунд";
        }
    }
}
