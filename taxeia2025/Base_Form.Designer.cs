namespace Peripatos_UI
{
    partial class Base_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            viewHistoryToolStripMenuItem = new ToolStripMenuItem();
            clearHistoryToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            showHelpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            button_about = new Button();
            button_exit = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, historyToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, loginToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(114, 24);
            fileToolStripMenuItem.Text = "Λογαριασμός";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(224, 26);
            registerToolStripMenuItem.Text = "Εγγραφή";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(224, 26);
            loginToolStripMenuItem.Text = "Σύνδεση";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Αποσύνδεση";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Έξοδος";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHistoryToolStripMenuItem, clearHistoryToolStripMenuItem });
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(82, 24);
            historyToolStripMenuItem.Text = "Ιστορικό";
            // 
            // viewHistoryToolStripMenuItem
            // 
            viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            viewHistoryToolStripMenuItem.Size = new Size(246, 26);
            viewHistoryToolStripMenuItem.Text = "Προβολή Ιστορικού";
            viewHistoryToolStripMenuItem.Click += viewHistoryToolStripMenuItem_Click;
            // 
            // clearHistoryToolStripMenuItem
            // 
            clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            clearHistoryToolStripMenuItem.Size = new Size(246, 26);
            clearHistoryToolStripMenuItem.Text = "Καθαρισμός Ιστορικού";
            clearHistoryToolStripMenuItem.Click += clearHistoryToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showHelpToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(79, 24);
            helpToolStripMenuItem.Text = "Βοήθεια";
            // 
            // showHelpToolStripMenuItem
            // 
            showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            showHelpToolStripMenuItem.Size = new Size(201, 26);
            showHelpToolStripMenuItem.Text = "Οδηγός Χρήσης";
            showHelpToolStripMenuItem.Click += showHelpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(201, 26);
            aboutToolStripMenuItem.Text = "Σχετικά...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // button_about
            // 
            button_about.Location = new Point(35, 314);
            button_about.Name = "button_about";
            button_about.Size = new Size(110, 65);
            button_about.TabIndex = 11;
            button_about.Text = "Σχετικά";
            button_about.UseVisualStyleBackColor = true;
            button_about.Click += button_about_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Transparent;
            button_exit.Location = new Point(623, 314);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(110, 65);
            button_exit.TabIndex = 12;
            button_exit.Text = "Έξοδος";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // Base_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_exit);
            Controls.Add(button_about);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Base_Form";
            Text = "Base_Form";
            Load += Base_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem viewHistoryToolStripMenuItem;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem showHelpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        public Button button_about;
        public Button button_exit;
    }
}