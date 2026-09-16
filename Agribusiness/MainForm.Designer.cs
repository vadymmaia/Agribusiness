namespace Agribusiness
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(946, 188);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 335);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(824, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 92);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(824, 454);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 102);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(347, 363);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 5;
            button1.Text = "Додати товар";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(347, 409);
            button2.Name = "button2";
            button2.Size = new Size(208, 29);
            button2.TabIndex = 6;
            button2.Text = "Видалити обране";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(347, 444);
            button3.Name = "button3";
            button3.Size = new Size(208, 29);
            button3.TabIndex = 7;
            button3.Text = "Створити бэкап";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(347, 479);
            button4.Name = "button4";
            button4.Size = new Size(208, 29);
            button4.TabIndex = 8;
            button4.Text = "Сформувати звіт";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(347, 514);
            button5.Name = "button5";
            button5.Size = new Size(208, 29);
            button5.TabIndex = 9;
            button5.Text = "Вихід у меню";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 338);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 11;
            label1.Text = "Пошук:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 286);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 12;
            label2.Text = "Сортування:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 314);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 13;
            label3.Text = "Фото товару:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 27);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 14;
            label4.Text = "Деталі продукту";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 679);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 15;
            label5.Text = "Статус системи: Готово";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(998, 691);
            label6.Name = "label6";
            label6.Size = new Size(180, 20);
            label6.TabIndex = 16;
            label6.Text = "Облік агропродукції v1.0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1190, 720);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}