namespace OOP_CarParts_Kolkov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddCarPart_button = new Button();
            EditCarPart_button = new Button();
            DeleteCarPart_button = new Button();
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            Search_button = new Button();
            Search_textBox = new TextBox();
            dataGridView1 = new DataGridView();
            файлToolStripMenuItem = new ToolStripMenuItem();
            створитиНовуToolStripMenuItem = new ToolStripMenuItem();
            завантажитиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            закритиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            навігаціяToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // AddCarPart_button
            // 
            AddCarPart_button.Location = new Point(12, 606);
            AddCarPart_button.Name = "AddCarPart_button";
            AddCarPart_button.Size = new Size(136, 23);
            AddCarPart_button.TabIndex = 2;
            AddCarPart_button.Text = " + Додати запчастину";
            AddCarPart_button.UseVisualStyleBackColor = true;
            AddCarPart_button.Click += AddCarPart_button_Click;
            // 
            // EditCarPart_button
            // 
            EditCarPart_button.Location = new Point(154, 606);
            EditCarPart_button.Name = "EditCarPart_button";
            EditCarPart_button.Size = new Size(75, 23);
            EditCarPart_button.TabIndex = 3;
            EditCarPart_button.Text = "Редагувати";
            EditCarPart_button.UseVisualStyleBackColor = true;
            // 
            // DeleteCarPart_button
            // 
            DeleteCarPart_button.Location = new Point(235, 606);
            DeleteCarPart_button.Name = "DeleteCarPart_button";
            DeleteCarPart_button.Size = new Size(108, 23);
            DeleteCarPart_button.TabIndex = 4;
            DeleteCarPart_button.Text = " - Видалити";
            DeleteCarPart_button.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 41);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Search_button);
            splitContainer1.Panel2.Controls.Add(Search_textBox);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1106, 559);
            splitContainer1.SplitterDistance = 368;
            splitContainer1.TabIndex = 5;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(365, 559);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Search_button
            // 
            Search_button.Location = new Point(627, 3);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(104, 24);
            Search_button.TabIndex = 3;
            Search_button.Text = "Пошук";
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // Search_textBox
            // 
            Search_textBox.Location = new Point(3, 3);
            Search_textBox.Name = "Search_textBox";
            Search_textBox.PlaceholderText = "Пошук: артикул, назва або авто...";
            Search_textBox.Size = new Size(618, 23);
            Search_textBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(735, 527);
            dataGridView1.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиНовуToolStripMenuItem, завантажитиToolStripMenuItem, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, закритиToolStripMenuItem, toolStripMenuItem1, вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиНовуToolStripMenuItem
            // 
            створитиНовуToolStripMenuItem.Name = "створитиНовуToolStripMenuItem";
            створитиНовуToolStripMenuItem.Size = new Size(155, 22);
            створитиНовуToolStripMenuItem.Text = "Створити нову";
            створитиНовуToolStripMenuItem.Click += створитиНовуToolStripMenuItem_Click;
            // 
            // завантажитиToolStripMenuItem
            // 
            завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            завантажитиToolStripMenuItem.Size = new Size(155, 22);
            завантажитиToolStripMenuItem.Text = "Завантажити";
            завантажитиToolStripMenuItem.Click += завантажитиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(155, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(155, 22);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // закритиToolStripMenuItem
            // 
            закритиToolStripMenuItem.Name = "закритиToolStripMenuItem";
            закритиToolStripMenuItem.Size = new Size(155, 22);
            закритиToolStripMenuItem.Text = "Закрити";
            закритиToolStripMenuItem.Click += закритиToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(152, 6);
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(155, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { навігаціяToolStripMenuItem, aboutToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(61, 20);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // навігаціяToolStripMenuItem
            // 
            навігаціяToolStripMenuItem.Name = "навігаціяToolStripMenuItem";
            навігаціяToolStripMenuItem.Size = new Size(125, 22);
            навігаціяToolStripMenuItem.Text = "Навігація";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(125, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 641);
            Controls.Add(splitContainer1);
            Controls.Add(DeleteCarPart_button);
            Controls.Add(EditCarPart_button);
            Controls.Add(AddCarPart_button);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddCarPart_button;
        private Button EditCarPart_button;
        private Button DeleteCarPart_button;
        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem створитиНовуToolStripMenuItem;
        private ToolStripMenuItem завантажитиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem закритиToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStripMenuItem навігаціяToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button Search_button;
        private TextBox Search_textBox;
    }
}
