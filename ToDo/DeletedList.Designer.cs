namespace ToDo
{
    partial class DeletedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedList));
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(12, 46);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(624, 361);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 1;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClearDeletedTasks;
            // 
            // DeletedList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 419);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(300, 300);
            Name = "DeletedList";
            Text = "Deleted Tasks";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
    }
}