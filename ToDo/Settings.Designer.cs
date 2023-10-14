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
            fontSizeComboBox = new ComboBox();
            fontSizeText = new TextBox();
            WorkInBackCheckBox = new CheckBox();
            reminderText = new TextBox();
            reminderComboBox = new ComboBox();
            startupCheckBox = new CheckBox();
            warningText = new TextBox();
            SuspendLayout();
            // 
            // fontSizeComboBox
            // 
            fontSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontSizeComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fontSizeComboBox.FormattingEnabled = true;
            fontSizeComboBox.ImeMode = ImeMode.NoControl;
            fontSizeComboBox.Items.AddRange(new object[] { "6", "8", "10", "12", "14", "16", "18", "20", "22" });
            fontSizeComboBox.Location = new Point(77, 9);
            fontSizeComboBox.Name = "fontSizeComboBox";
            fontSizeComboBox.Size = new Size(52, 25);
            fontSizeComboBox.TabIndex = 8;
            // 
            // fontSizeText
            // 
            fontSizeText.BackColor = SystemColors.Control;
            fontSizeText.BorderStyle = BorderStyle.None;
            fontSizeText.Location = new Point(12, 12);
            fontSizeText.Name = "fontSizeText";
            fontSizeText.ReadOnly = true;
            fontSizeText.Size = new Size(59, 18);
            fontSizeText.TabIndex = 17;
            fontSizeText.Text = " Font Size";
            fontSizeText.TextAlign = HorizontalAlignment.Center;
            // 
            // WorkInBackCheckBox
            // 
            WorkInBackCheckBox.AutoSize = true;
            WorkInBackCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            WorkInBackCheckBox.Location = new Point(12, 40);
            WorkInBackCheckBox.Name = "WorkInBackCheckBox";
            WorkInBackCheckBox.Size = new Size(235, 21);
            WorkInBackCheckBox.TabIndex = 18;
            WorkInBackCheckBox.Text = "Run in the background after closing";
            WorkInBackCheckBox.UseVisualStyleBackColor = true;
            // 
            // reminderText
            // 
            reminderText.BackColor = SystemColors.Control;
            reminderText.BorderStyle = BorderStyle.None;
            reminderText.Location = new Point(12, 70);
            reminderText.Name = "reminderText";
            reminderText.ReadOnly = true;
            reminderText.Size = new Size(87, 18);
            reminderText.TabIndex = 20;
            reminderText.TabStop = false;
            reminderText.Text = " Remind every";
            // 
            // reminderComboBox
            // 
            reminderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            reminderComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            reminderComboBox.FormattingEnabled = true;
            reminderComboBox.ImeMode = ImeMode.NoControl;
            reminderComboBox.Items.AddRange(new object[] { "Never", "15 minutes", "30 minutes", "1 hour", "2 hours", "4 hours", "8 hours" });
            reminderComboBox.Location = new Point(105, 67);
            reminderComboBox.Name = "reminderComboBox";
            reminderComboBox.Size = new Size(111, 25);
            reminderComboBox.TabIndex = 21;
            // 
            // startupCheckBox
            // 
            startupCheckBox.AutoSize = true;
            startupCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            startupCheckBox.Location = new Point(12, 98);
            startupCheckBox.Name = "startupCheckBox";
            startupCheckBox.Size = new Size(201, 21);
            startupCheckBox.TabIndex = 22;
            startupCheckBox.Text = "Run application with Windows";
            startupCheckBox.UseVisualStyleBackColor = true;
            // 
            // warningText
            // 
            warningText.BackColor = SystemColors.Control;
            warningText.BorderStyle = BorderStyle.None;
            warningText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            warningText.ForeColor = SystemColors.WindowFrame;
            warningText.Location = new Point(12, 116);
            warningText.Name = "warningText";
            warningText.Size = new Size(180, 15);
            warningText.TabIndex = 23;
            warningText.Text = " this setting will work after reboot";
            warningText.TextAlign = HorizontalAlignment.Center;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 138);
            Controls.Add(warningText);
            Controls.Add(startupCheckBox);
            Controls.Add(reminderComboBox);
            Controls.Add(reminderText);
            Controls.Add(WorkInBackCheckBox);
            Controls.Add(fontSizeText);
            Controls.Add(fontSizeComboBox);
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

        private ComboBox fontSizeComboBox;
        public TextBox fontSizeText;
        private CheckBox WorkInBackCheckBox;
        public TextBox reminderText;
        private ComboBox reminderComboBox;
        private CheckBox startupCheckBox;
        public TextBox warningText;
    }
}