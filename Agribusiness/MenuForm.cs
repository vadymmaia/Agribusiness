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

            // ПРИМІТКА: Прив'язку подію (this.button1.Click += ...) вилучено звідси,
            // оскільки Visual Studio вже автоматично прив'язує їх у MenuForm.Designer.cs.
            // Подвійна прив'язка викликала відкриття вікна двічі!
        }

        // button1: Перехід до форми бази даних (MainForm)
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            // Коли закриється MainForm — закриваємо й меню (цілком додаток)
            mainForm.FormClosed += (s, args) => this.Close();

            mainForm.Show(); // Відкриваємо форму звичайним чином
            this.Hide();     // Приховуємо головне меню
        }

        // button2: Перехід до форми додавання товару (AddProductForm)
        private void button2_Click(object sender, EventArgs e)
        {
            // Ховаємо поточне меню
            this.Hide();

            using (AddProductForm addForm = new AddProductForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewProduct != null)
                {
                    AgroDataManager dataManager = new AgroDataManager();
                    var list = dataManager.LoadData();
                    list.Add(addForm.NewProduct);
                    dataManager.SaveData(list);
                    MessageBox.Show("Товар успішно додано до бази!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Після додавання товару повертаємо (показуємо) назад головне меню
            this.Show();
        }

        // button3: Вихід із застосунку
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}