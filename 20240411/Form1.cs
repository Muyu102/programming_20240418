using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240411
{
    public partial class Form1 : Form
    {
        int i = 0;
        int computerWins = 0;
        int playerWins = 0;
        bool gameEnded = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_button_Click(object sender, EventArgs e)
        {

        }

        private void lbl_combobox_Click(object sender, EventArgs e)
        {

        }

        private void cmb_interval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            pictureBox1.Image = imageList1.Images[i%3];
        }

        private void cmb_interval_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            timer.Interval = Int32.Parse(cmb.Text);
        }

        private void but_process_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameEnded)
                return;

            timer.Enabled = true;
        }

        private void but_process_MouseUp(object sender, MouseEventArgs e)
        {
            if (gameEnded)
                return;

            timer.Enabled= false;
            Random rd = new Random();
            int index = rd.Next(0,3);
            pictureBox1 .Image = imageList1.Images[index];

            /*
             *index: 
             * 0 - paper
             * 1 - scissors
             * 2 - rock
             */

            int win_lose = 0;
            /*
             * 0 - even
             * 1 - win
             * 2 - loose
             */

            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "paper":
                    if (index == 0)
                        win_lose = 1;
                    else if (index == 1)
                        win_lose = 2;
                    else
                        win_lose = 1;
                    break;
                case "scissors":
                    if (index == 1)
                        win_lose = 0;
                    else if (index == 0)
                        win_lose = 1;
                    else
                        win_lose = 2;
                    break;
                case "rock":
                    if (index == 2)
                        win_lose = 0;
                    else if (index == 0)
                        win_lose = 2;
                    else
                        win_lose = 1;
                    break;
            }

            if (win_lose == 0)
            {
                label1.Text = "EVEN";
                label1.ForeColor = Color.Green;
            }

            else if (win_lose == 1)
            {
                label1.Text = "YOU WIN";
                label1.ForeColor = Color.Red;
                playerWins++;
            }

            else
            {
                label1.Text = "YOU LOSE";
                label1.ForeColor = Color.Blue;
                computerWins++;
            }

            textBox1.AppendText($"{label1.Text}{Environment.NewLine}");

            if (playerWins == 2 || computerWins == 2)
            {
                gameEnded = true;
                if (playerWins == 2)
                    label1.Text = "You WIN!";
                else
                    label1.Text = "You LOSE!";
                but_process.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_process_Click(object sender, EventArgs e)
        {
            gameEnded = false;
            playerWins = 0;
            computerWins = 0;
            label1.Text = "";
            textBox1.Clear();
            but_process.Enabled = true;
        }
    }
}
