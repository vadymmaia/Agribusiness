using System;
using System.Drawing;
using System.Windows.Forms;

namespace Agribusiness
{
    public partial class AddProductForm : Form
    {
        public AgroProduct? NewProduct { get; private set; }
        private string _selectedImagePath = string.Empty;

        public AddProductForm()
        {
            InitializeComponent();

            // Примусова прив'язка подій, щоб усе запрацювало:
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click); // Зберегти
            this.button2.Click += new System.EventHandler(this.button2_Click); // Скасувати
            this.button3.Click += new System.EventHandler(this.button3_Click); // Обрати фото

            InitCategories();
        }
        private void InitCategories()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Зернові культури", "Овочі" });
            comboBox1.SelectedIndex = 0;
            UpdateProductDropdown();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProductDropdown();
        }

        private void UpdateProductDropdown()
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem?.ToString() == "Зернові культури")
            {
                comboBox2.Items.AddRange(new string[] {
                    "Рис", "Гречка", "Ячмінь", "Просо", "Зерно", "Кукурудза", "Горох", "Овес"
                });
            }
            else if (comboBox1.SelectedItem?.ToString() == "Овочі")
            {
                comboBox2.Items.AddRange(new string[] {
                    "Морква", "Буряк", "Редиска", "Редька", "Ріпа", "Пастернак",
                    "Помідори", "Огірки", "Кабачки", "Гарбузи", "Баклажани",
                    "Солодкий перець", "Гострий перець", "Картопля", "Батат"
                });
            }

            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
        }

        // button3: Вибір зображення через OpenFileDialog
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Зображення (*.jpg;*.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(_selectedImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        // button1: Зберегти («Успіх»)
        private void button1_Click(object sender, EventArgs e)
        {
            NewProduct = new AgroProduct
            {
                Category = comboBox1.SelectedItem?.ToString() ?? "Інше",
                ProductName = comboBox2.SelectedItem?.ToString() ?? "Продукт",
                QuantityInTons = double.TryParse(textBox1.Text, out double qty) ? qty : 0.0,
                PricePerTon = double.TryParse(textBox2.Text, out double price) ? price : 0.0,
                WarehouseLocation = textBox3.Text,
                HarvestDate = dateTimePicker1.Value,
                ImagePath = _selectedImagePath
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // button2: Скасувати
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}