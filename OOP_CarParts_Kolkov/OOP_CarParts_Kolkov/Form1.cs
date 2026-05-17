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
                        catalog.Parts = jsonService.Load();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = catalog.Parts;



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
                        catalog.Parts = jsonService.Load();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = catalog.Parts;



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Спочатку створіть або відкрийте базу данних запчастин", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                jsonService.Save(catalog.Parts);
                MessageBox.Show("Данні успішно збережені до файлу", "Save to file", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зберегти дані.", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
