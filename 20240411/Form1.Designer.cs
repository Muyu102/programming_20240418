namespace _20240411
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_comboBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_comboBox
            // 
            this.label_comboBox.AutoSize = true;
            this.label_comboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_comboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_comboBox.ForeColor = System.Drawing.Color.Red;
            this.label_comboBox.Location = new System.Drawing.Point(410, 23);
            this.label_comboBox.Name = "label_comboBox";
            this.label_comboBox.Size = new System.Drawing.Size(180, 27);
            this.label_comboBox.TabIndex = 0;
            this.label_comboBox.Text = "選擇拳頭變換速度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "按下按鈕隨機變換，放開按鈕決定出拳";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500"});
            this.comboBox1.Location = new System.Drawing.Point(415, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 42);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(49, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "出拳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "paper.png");
            this.imageList1.Images.SetKeyName(1, "scissors.png");
            this.imageList1.Images.SetKeyName(2, "rock.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_rock
            // 
            this.btn_rock.BackgroundImage = global::_20240411.Properties.Resources.rock;
            this.btn_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rock.Location = new System.Drawing.Point(238, 433);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(120, 120);
            this.btn_rock.TabIndex = 7;
            this.btn_rock.Text = "Rock";
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myMouseDown);
            this.btn_rock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
            // 
            // btn_paper
            // 
            this.btn_paper.BackgroundImage = global::_20240411.Properties.Resources.paper;
            this.btn_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_paper.Location = new System.Drawing.Point(49, 433);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(120, 120);
            this.btn_paper.TabIndex = 8;
            this.btn_paper.Text = "Paper";
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myMouseDown);
            this.btn_paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
            // 
            // btn_scissors
            // 
            this.btn_scissors.BackgroundImage = global::_20240411.Properties.Resources.scissors;
            this.btn_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_scissors.Location = new System.Drawing.Point(426, 433);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(120, 120);
            this.btn_scissors.TabIndex = 6;
            this.btn_scissors.Text = "Scissors";
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myMouseDown);
            this.btn_scissors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_20240411.Properties.Resources.att_5YtXIfpUc_OnN7_J0sog6wCMsGCw1_RDmucvVI4mCbc;
            this.pictureBox2.Location = new System.Drawing.Point(385, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(707, 392);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 35);
            this.label.TabIndex = 9;
            this.label.Text = "結果";
            this.label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(677, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "猜拳紀錄";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(630, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 307);
            this.textBox1.TabIndex = 11;
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(567, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "最後是誰先勝2局呢!!";
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_rock);
            this.Controls.Add(this.btn_scissors);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_comboBox);
            this.Name = "Form1";
            this.Text = "guessing game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

