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
            listBox = new ListBox();
            clearButton = new Button();
            recoverButton = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 17;
            listBox.Location = new Point(12, 46);
            listBox.Name = "listBox";
            listBox.Size = new Size(624, 361);
            listBox.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 12);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 28);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearDeletedTasks;
            // 
            // recoverButton
            // 
            recoverButton.Location = new Point(93, 12);
            recoverButton.Name = "recoverButton";
            recoverButton.Size = new Size(75, 28);
            recoverButton.TabIndex = 2;
            recoverButton.Text = "Recover";
            recoverButton.UseVisualStyleBackColor = true;
            recoverButton.Click += Recover;
            // 
            // DeletedList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 419);
            Controls.Add(recoverButton);
            Controls.Add(clearButton);
            Controls.Add(listBox);
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

        private ListBox listBox;
        private Button clearButton;
        private Button recoverButton;
    }
}