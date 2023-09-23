namespace ToDo
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Items.AddRange(new object[] { "6", "8", "10", "12", "14", "16", "18", "20", "22" });
            comboBox1.Location = new Point(77, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 25);
            comboBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 18);
            textBox2.TabIndex = 17;
            textBox2.Text = " Font Size";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(12, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(235, 21);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Run in the background after closing";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 18);
            textBox1.TabIndex = 20;
            textBox1.Text = " Remind every";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.ImeMode = ImeMode.NoControl;
            comboBox2.Items.AddRange(new object[] { "Never", "15 minutes", "30 minutes", "1 hour", "2 hours", "4 hours", "8 hours" });
            comboBox2.Location = new Point(105, 67);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 25);
            comboBox2.TabIndex = 21;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 510);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            RightToLeft = RightToLeft.No;
            Text = "Settings";
            FormClosing += SaveData;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        public TextBox textBox2;
        private CheckBox checkBox1;
        public TextBox textBox1;
        private ComboBox comboBox2;
    }
}