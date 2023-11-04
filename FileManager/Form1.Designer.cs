namespace FileManager
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
            components = new System.ComponentModel.Container();
            GoToButton = new Button();
            path = new TextBox();
            backButton = new Button();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            createToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            directoryToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            removeToolStripMenuItem1 = new ToolStripMenuItem();
            renameToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            moreToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            RemovePanel = new Panel();
            RPanelOKButton2 = new Button();
            label1 = new Label();
            DestDir = new TextBox();
            RPanelOKButton = new Button();
            RPanelCancleButton = new Button();
            CreationPanel = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            CreateName = new TextBox();
            CreationPanelCancleButton = new Button();
            CreationPanelOKButton2 = new Button();
            CreationPanelOKButton = new Button();
            FindPanel = new Panel();
            label4 = new Label();
            FindThis = new TextBox();
            FindCancle = new Button();
            FindButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            backgraundToolStripMenuItem = new ToolStripMenuItem();
            dackToolStripMenuItem = new ToolStripMenuItem();
            ligthToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            RemovePanel.SuspendLayout();
            CreationPanel.SuspendLayout();
            FindPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GoToButton
            // 
            GoToButton.BackColor = Color.Gray;
            GoToButton.Location = new Point(48, 43);
            GoToButton.Name = "GoToButton";
            GoToButton.Size = new Size(52, 26);
            GoToButton.TabIndex = 0;
            GoToButton.Text = "Go to";
            GoToButton.UseVisualStyleBackColor = false;
            GoToButton.Click += button1_Click;
            // 
            // path
            // 
            path.BackColor = Color.Gray;
            path.BorderStyle = BorderStyle.FixedSingle;
            path.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            path.ForeColor = Color.WhiteSmoke;
            path.Location = new Point(106, 39);
            path.Name = "path";
            path.Size = new Size(447, 29);
            path.TabIndex = 1;
            path.Text = "C:\\";
            path.KeyPress += path_KeyPress;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Gray;
            backButton.Location = new Point(559, 41);
            backButton.Name = "backButton";
            backButton.Size = new Size(48, 25);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DimGray;
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.SeaShell;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(48, 75);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(562, 344);
            listBox1.TabIndex = 3;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ControlDark;
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem1, refreshToolStripMenuItem, moreToolStripMenuItem, backToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(89, 158);
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem, directoryToolStripMenuItem });
            createToolStripMenuItem.ForeColor = Color.Black;
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(88, 22);
            createToolStripMenuItem.Text = "Create";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.ControlDark;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(122, 22);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // directoryToolStripMenuItem
            // 
            directoryToolStripMenuItem.BackColor = SystemColors.ControlDark;
            directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            directoryToolStripMenuItem.Size = new Size(122, 22);
            directoryToolStripMenuItem.Text = "Directory";
            directoryToolStripMenuItem.Click += directoryToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem1, removeToolStripMenuItem1, renameToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(88, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new Size(117, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.Size = new Size(117, 22);
            removeToolStripMenuItem1.Text = "Remove";
            removeToolStripMenuItem1.Click += removeToolStripMenuItem1_Click;
            // 
            // renameToolStripMenuItem1
            // 
            renameToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            renameToolStripMenuItem1.Size = new Size(117, 22);
            renameToolStripMenuItem1.Text = "Rename";
            renameToolStripMenuItem1.Click += renameToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(88, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(88, 22);
            toolStripMenuItem1.Text = "Find";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(88, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new Size(88, 22);
            moreToolStripMenuItem.Text = "More";
            moreToolStripMenuItem.Click += moreToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(88, 22);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // RemovePanel
            // 
            RemovePanel.BackColor = Color.FromArgb(64, 64, 64);
            RemovePanel.Controls.Add(RPanelOKButton2);
            RemovePanel.Controls.Add(label1);
            RemovePanel.Controls.Add(DestDir);
            RemovePanel.Controls.Add(RPanelOKButton);
            RemovePanel.Controls.Add(RPanelCancleButton);
            RemovePanel.Location = new Point(137, 126);
            RemovePanel.Name = "RemovePanel";
            RemovePanel.Size = new Size(423, 171);
            RemovePanel.TabIndex = 6;
            RemovePanel.Visible = false;
            RemovePanel.Leave += RemovePanel_Leave;
            // 
            // RPanelOKButton2
            // 
            RPanelOKButton2.BackColor = Color.Gray;
            RPanelOKButton2.FlatAppearance.BorderColor = Color.Black;
            RPanelOKButton2.Location = new Point(100, 110);
            RPanelOKButton2.Name = "RPanelOKButton2";
            RPanelOKButton2.Size = new Size(66, 23);
            RPanelOKButton2.TabIndex = 3;
            RPanelOKButton2.Text = "OK";
            RPanelOKButton2.UseVisualStyleBackColor = false;
            RPanelOKButton2.Click += CopyPanelOKButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(99, 42);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 2;
            label1.Text = "Destination directory:";
            // 
            // DestDir
            // 
            DestDir.BackColor = SystemColors.WindowFrame;
            DestDir.BorderStyle = BorderStyle.None;
            DestDir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DestDir.ForeColor = Color.WhiteSmoke;
            DestDir.Location = new Point(99, 70);
            DestDir.Name = "DestDir";
            DestDir.Size = new Size(204, 16);
            DestDir.TabIndex = 1;
            // 
            // RPanelOKButton
            // 
            RPanelOKButton.BackColor = Color.Gray;
            RPanelOKButton.Location = new Point(99, 110);
            RPanelOKButton.Name = "RPanelOKButton";
            RPanelOKButton.Size = new Size(67, 24);
            RPanelOKButton.TabIndex = 0;
            RPanelOKButton.Text = "OK";
            RPanelOKButton.UseVisualStyleBackColor = false;
            RPanelOKButton.Click += CopyPanelOKButton_Click;
            // 
            // RPanelCancleButton
            // 
            RPanelCancleButton.BackColor = Color.Gray;
            RPanelCancleButton.Location = new Point(236, 110);
            RPanelCancleButton.Name = "RPanelCancleButton";
            RPanelCancleButton.Size = new Size(67, 24);
            RPanelCancleButton.TabIndex = 0;
            RPanelCancleButton.Text = "Cancle";
            RPanelCancleButton.UseVisualStyleBackColor = false;
            RPanelCancleButton.Click += CopyPanelCancleButton_Click;
            // 
            // CreationPanel
            // 
            CreationPanel.BackColor = Color.FromArgb(64, 64, 64);
            CreationPanel.Controls.Add(label3);
            CreationPanel.Controls.Add(comboBox1);
            CreationPanel.Controls.Add(label2);
            CreationPanel.Controls.Add(CreateName);
            CreationPanel.Controls.Add(CreationPanelCancleButton);
            CreationPanel.Controls.Add(CreationPanelOKButton2);
            CreationPanel.Controls.Add(CreationPanelOKButton);
            CreationPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreationPanel.Location = new Point(134, 142);
            CreationPanel.Name = "CreationPanel";
            CreationPanel.Size = new Size(400, 158);
            CreationPanel.TabIndex = 7;
            CreationPanel.Visible = false;
            CreationPanel.Leave += CreationPanel_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(274, 50);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "type(for file only)";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { ".txt", ".docx" });
            comboBox1.Location = new Point(284, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(64, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(30, 32);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 2;
            label2.Text = "Name of file/dir";
            // 
            // CreateName
            // 
            CreateName.BackColor = SystemColors.WindowFrame;
            CreateName.BorderStyle = BorderStyle.FixedSingle;
            CreateName.Location = new Point(30, 68);
            CreateName.Name = "CreateName";
            CreateName.Size = new Size(204, 23);
            CreateName.TabIndex = 1;
            // 
            // CreationPanelCancleButton
            // 
            CreationPanelCancleButton.BackColor = Color.Gray;
            CreationPanelCancleButton.Location = new Point(222, 108);
            CreationPanelCancleButton.Name = "CreationPanelCancleButton";
            CreationPanelCancleButton.Size = new Size(67, 24);
            CreationPanelCancleButton.TabIndex = 0;
            CreationPanelCancleButton.Text = "Cancle";
            CreationPanelCancleButton.UseVisualStyleBackColor = false;
            CreationPanelCancleButton.Click += CreationPanelCancleButton_Click;
            // 
            // CreationPanelOKButton2
            // 
            CreationPanelOKButton2.BackColor = Color.Gray;
            CreationPanelOKButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreationPanelOKButton2.Location = new Point(76, 108);
            CreationPanelOKButton2.Name = "CreationPanelOKButton2";
            CreationPanelOKButton2.Size = new Size(67, 24);
            CreationPanelOKButton2.TabIndex = 0;
            CreationPanelOKButton2.Text = "OK";
            CreationPanelOKButton2.UseVisualStyleBackColor = false;
            CreationPanelOKButton2.Click += CreationPanelOKButton2_Click;
            // 
            // CreationPanelOKButton
            // 
            CreationPanelOKButton.Location = new Point(76, 108);
            CreationPanelOKButton.Name = "CreationPanelOKButton";
            CreationPanelOKButton.Size = new Size(67, 24);
            CreationPanelOKButton.TabIndex = 0;
            CreationPanelOKButton.Text = "OK";
            CreationPanelOKButton.UseVisualStyleBackColor = true;
            CreationPanelOKButton.Click += CreationPanelOKButton_Click;
            // 
            // FindPanel
            // 
            FindPanel.BackColor = Color.FromArgb(64, 64, 64);
            FindPanel.Controls.Add(label4);
            FindPanel.Controls.Add(FindThis);
            FindPanel.Controls.Add(FindCancle);
            FindPanel.Controls.Add(FindButton);
            FindPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FindPanel.Location = new Point(145, 306);
            FindPanel.Name = "FindPanel";
            FindPanel.Size = new Size(389, 87);
            FindPanel.TabIndex = 8;
            FindPanel.Visible = false;
            FindPanel.Leave += FindPanel_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(132, 18);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 2;
            label4.Text = "Name to find:";
            // 
            // FindThis
            // 
            FindThis.BackColor = SystemColors.WindowFrame;
            FindThis.BorderStyle = BorderStyle.FixedSingle;
            FindThis.Location = new Point(98, 45);
            FindThis.Name = "FindThis";
            FindThis.Size = new Size(180, 23);
            FindThis.TabIndex = 1;
            // 
            // FindCancle
            // 
            FindCancle.BackColor = Color.Gray;
            FindCancle.Location = new Point(269, 17);
            FindCancle.Name = "FindCancle";
            FindCancle.Size = new Size(54, 22);
            FindCancle.TabIndex = 0;
            FindCancle.Text = "Cancle";
            FindCancle.UseVisualStyleBackColor = false;
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.Gray;
            FindButton.Location = new Point(43, 17);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(54, 22);
            FindButton.TabIndex = 0;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += button1_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(722, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.BackColor = SystemColors.AppWorkspace;
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem1, closeToolStripMenuItem });
            fileToolStripMenuItem1.ForeColor = SystemColors.ActiveCaptionText;
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "File";
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { backgraundToolStripMenuItem });
            editToolStripMenuItem1.ForeColor = SystemColors.WindowText;
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(103, 22);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // backgraundToolStripMenuItem
            // 
            backgraundToolStripMenuItem.BackColor = SystemColors.ControlDark;
            backgraundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dackToolStripMenuItem, ligthToolStripMenuItem });
            backgraundToolStripMenuItem.ForeColor = SystemColors.WindowText;
            backgraundToolStripMenuItem.Name = "backgraundToolStripMenuItem";
            backgraundToolStripMenuItem.Size = new Size(110, 22);
            backgraundToolStripMenuItem.Text = "Theme";
            // 
            // dackToolStripMenuItem
            // 
            dackToolStripMenuItem.BackColor = SystemColors.ControlDark;
            dackToolStripMenuItem.ForeColor = SystemColors.WindowText;
            dackToolStripMenuItem.Name = "dackToolStripMenuItem";
            dackToolStripMenuItem.Size = new Size(101, 22);
            dackToolStripMenuItem.Text = "Dark";
            dackToolStripMenuItem.Click += dackToolStripMenuItem_Click;
            // 
            // ligthToolStripMenuItem
            // 
            ligthToolStripMenuItem.BackColor = SystemColors.ControlDark;
            ligthToolStripMenuItem.ForeColor = SystemColors.WindowText;
            ligthToolStripMenuItem.Name = "ligthToolStripMenuItem";
            ligthToolStripMenuItem.Size = new Size(101, 22);
            ligthToolStripMenuItem.Text = "Ligth";
            ligthToolStripMenuItem.Click += ligthToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = SystemColors.ControlDark;
            closeToolStripMenuItem.ForeColor = SystemColors.WindowText;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(722, 447);
            Controls.Add(menuStrip1);
            Controls.Add(FindPanel);
            Controls.Add(RemovePanel);
            Controls.Add(CreationPanel);
            Controls.Add(listBox1);
            Controls.Add(backButton);
            Controls.Add(path);
            Controls.Add(GoToButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File manager";
            KeyPress += path_KeyPress;
            contextMenuStrip1.ResumeLayout(false);
            RemovePanel.ResumeLayout(false);
            RemovePanel.PerformLayout();
            CreationPanel.ResumeLayout(false);
            CreationPanel.PerformLayout();
            FindPanel.ResumeLayout(false);
            FindPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GoToButton;
        private TextBox path;
        private Button backButton;
        private ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel RemovePanel;
        private Label label1;
        private TextBox DestDir;
        private Button RPanelOKButton;
        private Button RPanelCancleButton;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem directoryToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Panel CreationPanel;
        private Label label2;
        private TextBox CreateName;
        private Button CreationPanelCancleButton;
        private Button CreationPanelOKButton;
        private Label label3;
        private ComboBox comboBox1;
        private Button CreationPanelOKButton2;
        private ToolStripMenuItem moreToolStripMenuItem;
        private Button RPanelOKButton2;
        private Panel FindPanel;
        private Label label4;
        private TextBox FindThis;
        private Button FindCancle;
        private Button FindButton;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private ToolStripMenuItem renameToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem backgraundToolStripMenuItem;
        private ToolStripMenuItem dackToolStripMenuItem;
        private ToolStripMenuItem ligthToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}