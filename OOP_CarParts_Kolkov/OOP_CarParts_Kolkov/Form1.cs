using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using OOP_CarParts_Kolkov.Models;


namespace OOP_CarParts_Kolkov
{
    public partial class Form1 : Form
    {
        private CatalogManager catalog;
        private JsonService jsonService;
        public Form1()
        {

            InitializeComponent();
            catalog = new CatalogManager();
            this.Text = "Каталог запчастин";
            UpdateUIState();

        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*";
                openFileDialog.Title = "Оберіть файл бази запчастин";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        jsonService = new JsonService(filePath);
                        UpdateUIState();
                        catalog.Parts = jsonService.Load();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = catalog.Parts;
                        UpdateVehicleTreeView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void створитиНовуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateDatabase createDatabase = new CreateDatabase())
            {
                if (createDatabase.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Базу успішно створено!");
                    try
                    {
                        string filePath = createDatabase.DatabaseName;
                        jsonService = new JsonService(filePath);
                        UpdateUIState();

                        catalog.Parts = jsonService.Load();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = catalog.Parts;
                        UpdateVehicleTreeView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (jsonService == null)
                {
                    MessageBox.Show("Спочатку створіть або відкрийте базу данних запчастин",
                        "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                jsonService.Save(catalog.Parts);
                MessageBox.Show("Данні успішно збережені до файлу", "Save to file",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зберегти дані.", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonService == null)
            {
                MessageBox.Show("Спочатку створіть або відкрийте базу данних запчастин",
                    "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Зберегти базу запчастин як...";
                dialog.Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*";
                dialog.DefaultExt = "json";
                dialog.AddExtension = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string newFilePath = dialog.FileName;
                        jsonService = new JsonService(newFilePath);
                        jsonService.Save(catalog.Parts);
                        MessageBox.Show("Дані збережено у новий файл", "Збереження",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не вдалося зберегти файл: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Бажаєте зберегти зміни перед тим, як закрити поточну базу?",
                "Закриття бази даних",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    jsonService.Save(catalog.Parts);
                    ClearCurrentDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                ClearCurrentDatabase();
            }
        }


        private void ClearCurrentDatabase()
        {
            if (catalog.Parts != null)
            {
                catalog.Parts.Clear();
            }
            jsonService = null;
            UpdateUIState();
            dataGridView1.DataSource = null;
            UpdateVehicleTreeView();
            this.Text = "Каталог запчастин";
            MessageBox.Show("Базу даних закрито.", "Інформація",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateUIState()
        {
            bool isDbLoaded = (jsonService != null);

            зберегтиToolStripMenuItem.Enabled = isDbLoaded;
            зберегтиЯкToolStripMenuItem.Enabled = isDbLoaded;
            закритиToolStripMenuItem.Enabled = isDbLoaded;
            AddCarPart_button.Enabled = isDbLoaded;
            EditCarPart_button.Enabled = isDbLoaded;
            DeleteCarPart_button.Enabled = isDbLoaded;
            Search_button.Enabled = isDbLoaded;
            Search_textBox.Enabled = isDbLoaded;
        }
        private void UpdateVehicleTreeView()
        {

            treeView1.Nodes.Clear();
            if (catalog == null || catalog.Parts == null || catalog.Parts.Count == 0)
            {
                return;
            }
            var carDictionary = new Dictionary<string, List<Part>>();
            foreach (var part in catalog.Parts)
            {
                if (part.CompatibleCars != null)
                {
                    foreach (var car in part.CompatibleCars)
                    {
                        string carKey = $"{car.brand} {car.model}";
                        if (!carDictionary.ContainsKey(carKey))
                        {
                            carDictionary[carKey] = new List<Part>();
                        }
                        carDictionary[carKey].Add(part);
                    }
                }
            }
            foreach (var kvp in carDictionary)
            {

                TreeNode carNode = new TreeNode(kvp.Key + "    ");
                carNode.NodeFont = new Font(treeView1.Font, FontStyle.Bold);
                foreach (var part in kvp.Value)
                {
                    string partInfo = $"{part.Name} (ID: {part.Id}) — {part.Price} грн.";
                    carNode.Nodes.Add(partInfo);
                }
                treeView1.Nodes.Add(carNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (catalog.Parts == null || catalog == null) return;
            if (e.Node.Parent != null)
            {
                string nodeText = e.Node.Text;
                int idStart = nodeText.IndexOf("(ID: ") + 5;
                int idEnd = nodeText.IndexOf(")", idStart);
                if (idStart > 4 && idEnd > idStart)
                {
                    string selectedId = nodeText.Substring(idStart, idEnd - idStart);
                    var filteredParts = catalog.Parts
                        .Where(part => part.Id == selectedId)
                        .ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filteredParts;
                }
            }
            else
            {
                string selectedCarName = e.Node.Text.Trim();
                var carParts = catalog.Parts
                    .Where(part => part.CompatibleCars != null &&
                                   part.CompatibleCars.Any(car => $"{car.brand} {car.model}" == selectedCarName))
                    .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = carParts;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string query = Search_textBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(query))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = catalog.Parts;
                return;
            }
            var searchResults = catalog.Parts.Where(part =>
            (part.Id != null && part.Id.ToLower().Contains(query)) ||
            (part.Name != null && part.Name.ToLower().Contains(query)) ||
            (part.CompatibleCars != null && part.CompatibleCars.Any(car =>
            (car.brand != null && car.brand.ToLower().Contains(query)) ||
            (car.model != null && car.model.ToLower().Contains(query)) ||
            ($"{car.brand} {car.model}".ToLower().Contains(query))))).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchResults;

            if (searchResults.Count == 0)
            {
                MessageBox.Show("За вашим запитом нічого не знайдено. Спробуйте змінити критерії пошуку.",
                                "Результати пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddCarPart_button_Click(object sender, EventArgs e)
        {
            using (PartDetails partDetails = new PartDetails())
            {

            }
        }
    }

}
