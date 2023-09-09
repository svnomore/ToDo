namespace ToDo
{
    partial class ToDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddTask;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 13);
            textBox1.MaxLength = 90;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Add your task...";
            textBox1.Size = new Size(767, 22);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(93, 44);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 4;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RemoveTask;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(12, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(767, 382);
            listBox1.TabIndex = 15;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(704, 44);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 17;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OpenForm2;
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(791, 480);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ToDo";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "ToDo v0.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        public ListBox listBox1;
        private Button button3;
    }
}