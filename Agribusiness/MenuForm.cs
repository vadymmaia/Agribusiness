using AgroBusinessApp;
using System;
using System.Windows.Forms;

namespace Agribusiness
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            // Примусова прив'язка кнопок меню:
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
        }        // button1: Перехід до форми бази даних (MainForm)
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        // button2: Перехід до форми додавання товару (AddProductForm)
        private void button2_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            if (addForm.ShowDialog() == DialogResult.OK && addForm.NewProduct != null)
            {
                AgroDataManager dataManager = new AgroDataManager();
                var list = dataManager.LoadData();
                list.Add(addForm.NewProduct);
                dataManager.SaveData(list);
                MessageBox.Show("Товар успішно додано до бази!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // button3: Вихід із застосунку
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}