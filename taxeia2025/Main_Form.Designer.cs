namespace Peripatos_UI
{
    partial class Main_Form
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            guestToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label_tour_odigos = new Label();
            button_register = new Button();
            button_login = new Button();
            button_logout = new Button();
            button_beaches = new Button();
            button_sights = new Button();
            button_restaurants = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(658, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, loginToolStripMenuItem, logoutToolStripMenuItem, guestToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 20);
            fileToolStripMenuItem.Text = "Αρχείο";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(178, 22);
            registerToolStripMenuItem.Text = "Εγγραφή";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(178, 22);
            loginToolStripMenuItem.Text = "Σύνδεση";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(178, 22);
            logoutToolStripMenuItem.Text = "Αποσύνδεση";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // guestToolStripMenuItem
            // 
            guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            guestToolStripMenuItem.Size = new Size(178, 22);
            guestToolStripMenuItem.Text = "Σύνδεση Επισκέπτη";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(178, 22);
            exitToolStripMenuItem.Text = "Έξοδος";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(62, 20);
            helpToolStripMenuItem.Text = "Βοήθεια";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(122, 22);
            aboutToolStripMenuItem.Text = "Σχετικά...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label_tour_odigos
            // 
            label_tour_odigos.AutoSize = true;
            label_tour_odigos.Location = new Point(269, 21);
            label_tour_odigos.Name = "label_tour_odigos";
            label_tour_odigos.Size = new Size(118, 15);
            label_tour_odigos.TabIndex = 1;
            label_tour_odigos.Text = "Τουριστικός Οδηγός";
            label_tour_odigos.Click += label_tour_odigos_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(18, 36);
            button_register.Margin = new Padding(3, 2, 3, 2);
            button_register.Name = "button_register";
            button_register.Size = new Size(96, 22);
            button_register.TabIndex = 2;
            button_register.Text = "Εγγραφή Χρήστη";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_login
            // 
            button_login.Location = new Point(18, 62);
            button_login.Margin = new Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(96, 22);
            button_login.TabIndex = 3;
            button_login.Text = "Σύνδεση";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(18, 88);
            button_logout.Margin = new Padding(3, 2, 3, 2);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(96, 22);
            button_logout.TabIndex = 4;
            button_logout.Text = "Αποσύνδεση";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_beaches
            // 
            button_beaches.Location = new Point(231, 61);
            button_beaches.Margin = new Padding(3, 2, 3, 2);
            button_beaches.Name = "button_beaches";
            button_beaches.Size = new Size(183, 49);
            button_beaches.TabIndex = 6;
            button_beaches.Text = "Παραλίες";
            button_beaches.UseVisualStyleBackColor = true;
            button_beaches.Click += button_beaches_Click;
            // 
            // button_sights
            // 
            button_sights.Location = new Point(231, 124);
            button_sights.Margin = new Padding(3, 2, 3, 2);
            button_sights.Name = "button_sights";
            button_sights.Size = new Size(183, 49);
            button_sights.TabIndex = 7;
            button_sights.Text = "Αξιοθέατα";
            button_sights.UseVisualStyleBackColor = true;
            button_sights.Click += button_sights_Click;
            // 
            // button_restaurants
            // 
            button_restaurants.Location = new Point(231, 190);
            button_restaurants.Margin = new Padding(3, 2, 3, 2);
            button_restaurants.Name = "button_restaurants";
            button_restaurants.Size = new Size(183, 49);
            button_restaurants.TabIndex = 8;
            button_restaurants.Text = "Εστιατόρια";
            button_restaurants.UseVisualStyleBackColor = true;
            button_restaurants.Click += button_restaurants_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 320);
            Controls.Add(button_restaurants);
            Controls.Add(button_sights);
            Controls.Add(button_beaches);
            Controls.Add(button_logout);
            Controls.Add(button_login);
            Controls.Add(button_register);
            Controls.Add(label_tour_odigos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Τουριστικός Οδηγός";
            FormClosed += Main_Form_FormClosed;
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
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem guestToolStripMenuItem;
        private Label label_tour_odigos;
        private Button button_register;
        private Button button_login;
        private Button button_logout;
        private Button button_beaches;
        private Button button_sights;
        private Button button_restaurants;
    }
}
