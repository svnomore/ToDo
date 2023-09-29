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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo));
            addTaskButton = new Button();
            inputField = new TextBox();
            removeTaskButton = new Button();
            taskListBox = new ListBox();
            settingsButton = new Button();
            deletedListButton = new Button();
            notifyIcon = new NotifyIcon(components);
            iconContextMenu = new ContextMenuStrip(components);
            ShowStripMenu = new ToolStripMenuItem();
            CloseStripMenu = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            iconContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(12, 44);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(75, 25);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "Add";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += AddTask;
            // 
            // inputField
            // 
            inputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputField.Location = new Point(12, 13);
            inputField.MaxLength = 90;
            inputField.Name = "inputField";
            inputField.PlaceholderText = "Add your task...";
            inputField.Size = new Size(660, 22);
            inputField.TabIndex = 1;
            // 
            // removeTaskButton
            // 
            removeTaskButton.Location = new Point(93, 44);
            removeTaskButton.Name = "removeTaskButton";
            removeTaskButton.Size = new Size(75, 25);
            removeTaskButton.TabIndex = 4;
            removeTaskButton.Text = "Remove";
            removeTaskButton.UseVisualStyleBackColor = true;
            removeTaskButton.Click += RemoveTask;
            // 
            // taskListBox
            // 
            taskListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskListBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taskListBox.ForeColor = SystemColors.MenuText;
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 18;
            taskListBox.Location = new Point(12, 75);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(660, 310);
            taskListBox.TabIndex = 15;
            taskListBox.KeyDown += ManageTaskOnButton;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingsButton.Location = new Point(597, 44);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(75, 25);
            settingsButton.TabIndex = 17;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += OpenSettings;
            // 
            // deletedListButton
            // 
            deletedListButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deletedListButton.Location = new Point(516, 44);
            deletedListButton.Name = "deletedListButton";
            deletedListButton.Size = new Size(75, 25);
            deletedListButton.TabIndex = 18;
            deletedListButton.Text = "Deleted";
            deletedListButton.UseVisualStyleBackColor = true;
            deletedListButton.Click += OpenDeletedList;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "Im working in background now";
            notifyIcon.BalloonTipTitle = "hello";
            notifyIcon.ContextMenuStrip = iconContextMenu;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "ToDo";
            // 
            // iconContextMenu
            // 
            iconContextMenu.Items.AddRange(new ToolStripItem[] { ShowStripMenu, CloseStripMenu });
            iconContextMenu.Name = "contextMenuStrip1";
            iconContextMenu.Size = new Size(168, 48);
            // 
            // ShowStripMenu
            // 
            ShowStripMenu.Name = "ShowStripMenu";
            ShowStripMenu.Size = new Size(167, 22);
            ShowStripMenu.Text = "Show";
            ShowStripMenu.Click += OnNotifyShowButtonClick;
            // 
            // CloseStripMenu
            // 
            CloseStripMenu.Name = "CloseStripMenu";
            CloseStripMenu.Size = new Size(167, 22);
            CloseStripMenu.Text = "Close Completely";
            CloseStripMenu.Click += OnNotifyCloseButtonClick;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += Remind;
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(684, 409);
            Controls.Add(deletedListButton);
            Controls.Add(settingsButton);
            Controls.Add(taskListBox);
            Controls.Add(removeTaskButton);
            Controls.Add(inputField);
            Controls.Add(addTaskButton);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(370, 370);
            Name = "ToDo";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "ToDo v0.5";
            FormClosing += UserProgramClosing;
            iconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTaskButton;
        private TextBox inputField;
        private Button removeTaskButton;
        public ListBox taskListBox;
        private Button settingsButton;
        private Button deletedListButton;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip iconContextMenu;
        private ToolStripMenuItem ShowStripMenu;
        private ToolStripMenuItem CloseStripMenu;
        private System.Windows.Forms.Timer timer;
    }
}