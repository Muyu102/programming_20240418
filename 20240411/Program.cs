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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20240411
{
    public partial class Form1 : Form
    {
        int i = 0;
        int computerWins = 0;
        int playerWins = 0;
        //private PictureBox pictureBox1;
        //private System.Windows.Forms.ComboBox ComboBox;
        //private System.Windows.Forms.Label label_combox;
        //private System.Windows.Forms.Button but_process;
        //private System.Windows.Forms.Button btn_paper;
        //private System.Windows.Forms.Button but_scissors;
        //private System.Windows.Forms.Button but_rock;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox textBox1;
        //private Timer timer;
        //private IContainer components;
        //private System.Windows.Forms.Label label3;
        //private ImageList imageList1;
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
            int index = rd.Next(0, 3);
            pictureBox1.Image = imageList1.Images[index];

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
                label_combox.Text = "EVEN";
                label_combox.ForeColor = Color.Green;
            }

            else if (win_lose == 1)
            {
                label_combox.Text = "YOU WIN";
                label_combox.ForeColor = Color.Red;
                playerWins++;
            }

            else
            {
                label_combox.Text = "YOU LOSE";
                label_combox.ForeColor = Color.Blue;
                computerWins++;
            }

            textBox1.AppendText($"{label_combox.Text}{Environment.NewLine}");

            if (playerWins == 2 || computerWins == 2)
            {
                gameEnded = true;
                if (playerWins == 2)
                    label_combox.Text = "You WIN!";
                else
                    label_combox.Text = "You LOSE!";
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
            label_combox.Text = "";
            textBox1.Clear();
            but_process.Enabled = true;
        }

        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        //    this.ComboBox = new System.Windows.Forms.ComboBox();
        //    this.label_combox = new System.Windows.Forms.Label();
        //    this.but_process = new System.Windows.Forms.Button();
        //    this.label2 = new System.Windows.Forms.Label();
        //    this.textBox1 = new System.Windows.Forms.TextBox();
        //    this.timer = new System.Windows.Forms.Timer(this.components);
        //    this.label3 = new System.Windows.Forms.Label();
        //    this.but_rock = new System.Windows.Forms.Button();
        //    this.but_scissors = new System.Windows.Forms.Button();
        //    this.btn_paper = new System.Windows.Forms.Button();
        //    this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //    this.imageList1 = new System.Windows.Forms.ImageList(this.components);
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // ComboBox
        //    // 
        //    this.ComboBox.FormattingEnabled = true;
        //    this.ComboBox.Items.AddRange(new object[] {
        //    "50",
        //    "100",
        //    "500",
        //    "1000"});
        //    this.ComboBox.Location = new System.Drawing.Point(244, 83);
        //    this.ComboBox.Name = "ComboBox";
        //    this.ComboBox.Size = new System.Drawing.Size(121, 20);
        //    this.ComboBox.TabIndex = 1;
        //    this.ComboBox.Text = "100";
        //    this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.cmb_interval_SelectionChangeCommitted);
        //    // 
        //    // label_combox
        //    // 
        //    this.label_combox.AutoSize = true;
        //    this.label_combox.Location = new System.Drawing.Point(274, 37);
        //    this.label_combox.Name = "label_combox";
        //    this.label_combox.Size = new System.Drawing.Size(53, 12);
        //    this.label_combox.TabIndex = 2;
        //    this.label_combox.Text = "出拳速度";
        //    // 
        //    // but_process
        //    // 
        //    this.but_process.Location = new System.Drawing.Point(68, 248);
        //    this.but_process.Name = "but_process";
        //    this.but_process.Size = new System.Drawing.Size(75, 23);
        //    this.but_process.TabIndex = 3;
        //    this.but_process.Text = "出拳";
        //    this.but_process.UseVisualStyleBackColor = true;
        //    this.but_process.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseDown);
        //    this.but_process.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseUp);
        //    // 
        //    // label2
        //    // 
        //    this.label2.AutoSize = true;
        //    this.label2.Location = new System.Drawing.Point(215, 126);
        //    this.label2.Name = "label2";
        //    this.label2.Size = new System.Drawing.Size(0, 12);
        //    this.label2.TabIndex = 7;
        //    // 
        //    // textBox1
        //    // 
        //    this.textBox1.Location = new System.Drawing.Point(253, 136);
        //    this.textBox1.Multiline = true;
        //    this.textBox1.Name = "textBox1";
        //    this.textBox1.Size = new System.Drawing.Size(100, 100);
        //    this.textBox1.TabIndex = 8;
        //    this.textBox1.Click += new System.EventHandler(this.but_process_Click);
        //    this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseUp);
        //    // 
        //    // label3
        //    // 
        //    this.label3.AutoSize = true;
        //    this.label3.Location = new System.Drawing.Point(51, 224);
        //    this.label3.Name = "label3";
        //    this.label3.Size = new System.Drawing.Size(113, 12);
        //    this.label3.TabIndex = 9;
        //    this.label3.Text = "按下出拳，放開決定";
        //    // 
        //    // but_rock
        //    // 
        //    this.but_rock.BackgroundImage = global::_20240411.Properties.Resources.rock;
        //    this.but_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //    this.but_rock.Location = new System.Drawing.Point(264, 309);
        //    this.but_rock.Name = "but_rock";
        //    this.but_rock.Size = new System.Drawing.Size(120, 120);
        //    this.but_rock.TabIndex = 6;
        //    this.but_rock.Text = "but_rock";
        //    this.but_rock.UseVisualStyleBackColor = true;
        //    this.but_rock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseDown);
        //    this.but_rock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseUp);
        //    // 
        //    // but_scissors
        //    // 
        //    this.but_scissors.BackgroundImage = global::_20240411.Properties.Resources.scissors;
        //    this.but_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //    this.but_scissors.Location = new System.Drawing.Point(138, 309);
        //    this.but_scissors.Name = "but_scissors";
        //    this.but_scissors.Size = new System.Drawing.Size(120, 120);
        //    this.but_scissors.TabIndex = 5;
        //    this.but_scissors.Text = "button3";
        //    this.but_scissors.UseVisualStyleBackColor = true;
        //    this.but_scissors.Click += new System.EventHandler(this.button3_Click);
        //    this.but_scissors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseDown);
        //    this.but_scissors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseUp);
        //    // 
        //    // btn_paper
        //    // 
        //    this.btn_paper.BackgroundImage = global::_20240411.Properties.Resources.paper;
        //    this.btn_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //    this.btn_paper.Location = new System.Drawing.Point(12, 309);
        //    this.btn_paper.Name = "btn_paper";
        //    this.btn_paper.Size = new System.Drawing.Size(120, 120);
        //    this.btn_paper.TabIndex = 4;
        //    this.btn_paper.Text = "button2";
        //    this.btn_paper.UseVisualStyleBackColor = true;
        //    this.btn_paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseDown);
        //    this.btn_paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_process_MouseUp);
        //    // 
        //    // pictureBox1
        //    // 
        //    this.pictureBox1.Location = new System.Drawing.Point(31, 23);
        //    this.pictureBox1.Name = "pictureBox1";
        //    this.pictureBox1.Size = new System.Drawing.Size(164, 167);
        //    this.pictureBox1.TabIndex = 0;
        //    this.pictureBox1.TabStop = false;
        //    // 
        //    // imageList1
        //    // 
        //    this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
        //    this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
        //    this.imageList1.Images.SetKeyName(0, "paper.png");
        //    this.imageList1.Images.SetKeyName(1, "rock.png");
        //    this.imageList1.Images.SetKeyName(2, "scissors.png");
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(394, 441);
        //    this.Controls.Add(this.label3);
        //    this.Controls.Add(this.textBox1);
        //    this.Controls.Add(this.label2);
        //    this.Controls.Add(this.but_rock);
        //    this.Controls.Add(this.but_scissors);
        //    this.Controls.Add(this.btn_paper);
        //    this.Controls.Add(this.but_process);
        //    this.Controls.Add(this.label_combox);
        //    this.Controls.Add(this.ComboBox);
        //    this.Controls.Add(this.pictureBox1);
        //    this.Name = "Form1";
        //    this.Load += new System.EventHandler(this.Form1_Load_1);
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
