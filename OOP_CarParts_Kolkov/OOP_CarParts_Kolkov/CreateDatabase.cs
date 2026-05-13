using OOP_CarParts_Kolkov.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CarParts_Kolkov
{
    public partial class CreateDatabase : Form
    {
        public CreateDatabase()
        {
            InitializeComponent();
        }

        public string DatabaseName { get; private set; }


        private void button2_Click(object sender, EventArgs e)
        {
            string input =  NameEntry.Text.Trim();
            if (Regex.IsMatch(input, @"^[a-zA-Z0-9_\-]+$"))
            {
                
                DatabaseName = input + ".json";
                if (!File.Exists(DatabaseName))
                {
                    File.Create(DatabaseName).Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("База данних з такою назвою вже існує!",
                                "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                
                MessageBox.Show("Назва може містити лише латинські літери, цифри, дефіси та підкреслення. Символи крапки заборонені.",
                                "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
