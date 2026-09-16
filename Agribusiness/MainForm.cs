using AgroBusinessApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Agribusiness
{
    public partial class MainForm : Form
    {
        private readonly AgroDataManager _dataManager = new AgroDataManager();
        private List<AgroProduct> _allProducts = new List<AgroProduct>();

        public MainForm()
        {
            InitializeComponent();

            // Прив'язка подій з правильним типуванням
            if (button1 != null) button1.Click += button1_Click;
            if (button2 != null) button2.Click += button2_Click;
            if (button3 != null) button3.Click += button3_Click;
            if (button4 != null) button4.Click += button4_Click;
            if (button5 != null) button5.Click += button5_Click;

            if (textBox1 != null) textBox1.TextChanged += textBox1_TextChanged;
            if (comboBox1 != null) comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            if (dataGridView1 != null) dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            this.Load += MainForm_Load;
        }

        // Завантаження даних при відкритті форми
        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (comboBox1 != null && comboBox1.Items.Count == 0)
            {
                comboBox1.Items.AddRange(new string[] { "Без сортування", "За обсягом (спадання)", "За ціною (спадання)" });
                comboBox1.SelectedIndex = 0;
            }

            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            _allProducts = _dataManager.LoadData() ?? new List<AgroProduct>();
            ApplyFilterAndSort();
        }

        private void ApplyFilterAndSort()
        {
            var filtered = _allProducts.AsEnumerable();

            // Пошук за назвою або складом
            string searchText = textBox1?.Text.Trim().ToLower() ?? string.Empty;
            if (!string.IsNullOrEmpty(searchText))
            {
                filtered = filtered.Where(p =>
                    (p.ProductName != null && p.ProductName.ToLower().Contains(searchText)) ||
                    (p.WarehouseLocation != null && p.WarehouseLocation.ToLower().Contains(searchText))
                );
            }

            // Сортування
            if (comboBox1 != null)
            {
                if (comboBox1.SelectedIndex == 1)
                    filtered = filtered.OrderByDescending(p => p.QuantityInTons);
                else if (comboBox1.SelectedIndex == 2)
                    filtered = filtered.OrderByDescending(p => p.PricePerTon);
            }

            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtered.ToList();
            }
        }

        // Відображення фото обраного товару
        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1 != null && pictureBox1 != null && dataGridView1.CurrentRow?.DataBoundItem is AgroProduct selected)
            {
                if (!string.IsNullOrEmpty(selected.ImagePath) && File.Exists(selected.ImagePath))
                {
                    if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(selected.ImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
        }

        // Кнопка: Додати
        private void button1_Click(object? sender, EventArgs e)
        {
            using (AddProductForm addForm = new AddProductForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewProduct != null)
                {
                    _allProducts.Add(addForm.NewProduct);
                    _dataManager.SaveData(_allProducts);
                    LoadDataToGrid();
                }
            }
        }

        // Кнопка: Видалити
        private void button2_Click(object? sender, EventArgs e)
        {
            if (dataGridView1?.CurrentRow?.DataBoundItem is AgroProduct selected)
            {
                var confirm = MessageBox.Show($"Видалити товар '{selected.ProductName}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    _allProducts.RemoveAll(p => p.Id == selected.Id);
                    _dataManager.SaveData(_allProducts);
                    LoadDataToGrid();
                }
            }
            else
            {
                MessageBox.Show("Оберіть товар у таблиці для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка: Бэкап
        private void button3_Click(object? sender, EventArgs e)
        {
            _dataManager.CreateBackup();
            MessageBox.Show("Резервну копію бази даних успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Кнопка: Звіт
        private void button4_Click(object? sender, EventArgs e)
        {
            if (_allProducts == null || _allProducts.Count == 0)
            {
                MessageBox.Show("Немає даних для формування звіту.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовий файл (*.txt)|*.txt";
                saveFileDialog.Title = "Зберегти звіт про агропродукцію";
                saveFileDialog.FileName = $"Звіт_Агропродукція_{DateTime.Now:yyyy-MM-dd}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        double totalTons = _allProducts.Sum(p => p.QuantityInTons);
                        double totalPrice = _allProducts.Sum(p => p.QuantityInTons * p.PricePerTon);

                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                        {
                            writer.WriteLine("==================================================");
                            writer.WriteLine("             ЗВІТ ПРО АГРОПРОДУКЦІЮ              ");
                            writer.WriteLine($"Дата формування: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                            writer.WriteLine("==================================================");
                            writer.WriteLine();

                            writer.WriteLine(string.Format("{0,-20} | {1,-10} | {2,-12} | {3,-15}", "Назва", "Обсяг (т)", "Ціна/т (грн)", "Склад"));
                            writer.WriteLine(new string('-', 68));

                            foreach (var item in _allProducts)
                            {
                                writer.WriteLine(string.Format("{0,-20} | {1,-10:F2} | {2,-12:F2} | {3,-15}",
                                    item.ProductName ?? "-",
                                    item.QuantityInTons,
                                    item.PricePerTon,
                                    item.WarehouseLocation ?? "-"));
                            }

                            writer.WriteLine(new string('-', 68));
                            writer.WriteLine($"Всього найменувань : {_allProducts.Count}");
                            writer.WriteLine($"Загальний обсяг    : {totalTons:F2} тонн");
                            writer.WriteLine($"Загальна вартість  : {totalPrice:F2} грн.");
                            writer.WriteLine("==================================================");
                        }

                        MessageBox.Show("Звіт успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Кнопка: Назад у меню
        private void button5_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object? sender, EventArgs e) => ApplyFilterAndSort();

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e) => ApplyFilterAndSort();

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.ReadOnly = true; // Забороняє редагування клітинок
                dataGridView1.AllowUserToAddRows = false; // Прибирає порожній рядок знизу
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Виділяє рядок повністю
            }

            if (comboBox1 != null && comboBox1.Items.Count == 0)
            {
                comboBox1.Items.AddRange(new string[] { "Без сортування", "За обсягом (спадання)", "За ціною (спадання)" });
                comboBox1.SelectedIndex = 0;
            }

            LoadDataToGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}