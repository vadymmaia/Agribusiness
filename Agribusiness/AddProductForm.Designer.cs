namespace Agribusiness
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(791, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(386, 215);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 33);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(586, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F);
            textBox2.Location = new Point(586, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 31);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F);
            textBox3.Location = new Point(586, 430);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 31);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F);
            dateTimePicker1.Location = new Point(556, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(394, 529);
            button1.Name = "button1";
            button1.Size = new Size(156, 39);
            button1.TabIndex = 9;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(629, 529);
            button2.Name = "button2";
            button2.Size = new Size(156, 39);
            button2.TabIndex = 10;
            button2.Text = "Скасувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(692, 223);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 12;
            label1.Text = "Категорія:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(294, 218);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 13;
            label2.Text = "Продукт:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(452, 307);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 14;
            label3.Text = "Обсяг (тонн):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(394, 366);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 15;
            label4.Text = "Ціна за тонну (грн):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(418, 433);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 16;
            label5.Text = "Склад / Локація:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(356, 144);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 17;
            label6.Text = "Дата збору врожаю:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(488, 40);
            label7.Name = "label7";
            label7.Size = new Size(318, 41);
            label7.TabIndex = 18;
            label7.Text = "Додати новий товар";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(70, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 62);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(70, 181);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 62);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(70, 447);
            button3.Name = "button3";
            button3.Size = new Size(156, 39);
            button3.TabIndex = 21;
            button3.Text = "Обрати фото";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1158, 746);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}