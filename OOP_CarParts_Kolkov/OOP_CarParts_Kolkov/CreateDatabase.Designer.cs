namespace OOP_CarParts_Kolkov
{
    partial class CreateDatabase
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            NameEntry = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(159, 82);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Скасувати";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(78, 82);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 2;
            label1.Text = "Введіть назву бази данних:";
            // 
            // NameEntry
            // 
            NameEntry.Location = new Point(12, 38);
            NameEntry.Name = "NameEntry";
            NameEntry.Size = new Size(186, 23);
            NameEntry.TabIndex = 3;
            // 
            // CreateDatabase
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(246, 117);
            Controls.Add(NameEntry);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CreateDatabase";
            Text = "CreateDatabase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox NameEntry;
    }
}