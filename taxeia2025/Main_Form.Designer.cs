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
            label_tour_odigos = new Label();
            button_register = new Button();
            button_login = new Button();
            button_logout = new Button();
            button_beaches = new Button();
            button_sights = new Button();
            button_restaurants = new Button();
            button_presentation = new Button();
            button_history = new Button();
            SuspendLayout();
            // 
            // button_about
            // 
            button_about.Location = new Point(21, 253);
            // 
            // button_exit
            // 
            button_exit.Location = new Point(628, 253);
            // 
            // label_tour_odigos
            // 
            label_tour_odigos.AutoSize = true;
            label_tour_odigos.Location = new Point(307, 28);
            label_tour_odigos.Name = "label_tour_odigos";
            label_tour_odigos.Size = new Size(148, 20);
            label_tour_odigos.TabIndex = 1;
            label_tour_odigos.Text = "Τουριστικός Οδηγός";
            label_tour_odigos.Click += label_tour_odigos_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(21, 48);
            button_register.Name = "button_register";
            button_register.Size = new Size(110, 29);
            button_register.TabIndex = 2;
            button_register.Text = "Εγγραφή Χρήστη";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_login
            // 
            button_login.Location = new Point(21, 83);
            button_login.Name = "button_login";
            button_login.Size = new Size(110, 29);
            button_login.TabIndex = 3;
            button_login.Text = "Σύνδεση";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(21, 117);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(110, 29);
            button_logout.TabIndex = 4;
            button_logout.Text = "Αποσύνδεση";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_beaches
            // 
            button_beaches.Location = new Point(264, 81);
            button_beaches.Name = "button_beaches";
            button_beaches.Size = new Size(209, 65);
            button_beaches.TabIndex = 6;
            button_beaches.Text = "Παραλίες";
            button_beaches.UseVisualStyleBackColor = true;
            button_beaches.Click += button_beaches_Click;
            // 
            // button_sights
            // 
            button_sights.Location = new Point(264, 165);
            button_sights.Name = "button_sights";
            button_sights.Size = new Size(209, 65);
            button_sights.TabIndex = 7;
            button_sights.Text = "Αξιοθέατα";
            button_sights.UseVisualStyleBackColor = true;
            button_sights.Click += button_sights_Click;
            // 
            // button_restaurants
            // 
            button_restaurants.Location = new Point(264, 253);
            button_restaurants.Name = "button_restaurants";
            button_restaurants.Size = new Size(209, 65);
            button_restaurants.TabIndex = 8;
            button_restaurants.Text = "Εστιατόρια";
            button_restaurants.UseVisualStyleBackColor = true;
            button_restaurants.Click += button_restaurants_Click;
            // 
            // button_presentation
            // 
            button_presentation.Location = new Point(629, 83);
            button_presentation.Margin = new Padding(3, 4, 3, 4);
            button_presentation.Name = "button_presentation";
            button_presentation.Size = new Size(109, 63);
            button_presentation.TabIndex = 12;
            button_presentation.Text = "ΠΑΡΟΥΣΙΑΣΗ";
            button_presentation.UseVisualStyleBackColor = true;
            button_presentation.Click += button_presentation_Click;
            // 
            // button_history
            // 
            button_history.Location = new Point(628, 165);
            button_history.Margin = new Padding(3, 4, 3, 4);
            button_history.Name = "button_history";
            button_history.Size = new Size(110, 65);
            button_history.TabIndex = 13;
            button_history.Text = "Ιστορικό";
            button_history.UseVisualStyleBackColor = true;
            button_history.Click += button_history_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 427);
            Controls.Add(button_history);
            Controls.Add(button_presentation);
            Controls.Add(button_restaurants);
            Controls.Add(button_sights);
            Controls.Add(button_beaches);
            Controls.Add(button_logout);
            Controls.Add(button_login);
            Controls.Add(button_register);
            Controls.Add(label_tour_odigos);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Τουριστικός Οδηγός";
            FormClosed += Main_Form_FormClosed;
            Load += Main_Form_Load;
            Controls.SetChildIndex(button_about, 0);
            Controls.SetChildIndex(button_exit, 0);
            Controls.SetChildIndex(label_tour_odigos, 0);
            Controls.SetChildIndex(button_register, 0);
            Controls.SetChildIndex(button_login, 0);
            Controls.SetChildIndex(button_logout, 0);
            Controls.SetChildIndex(button_beaches, 0);
            Controls.SetChildIndex(button_sights, 0);
            Controls.SetChildIndex(button_restaurants, 0);
            Controls.SetChildIndex(button_presentation, 0);
            Controls.SetChildIndex(button_history, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tour_odigos;
        private Button button_register;
        private Button button_login;
        private Button button_logout;
        private Button button_beaches;
        private Button button_sights;
        private Button button_restaurants;
        private Button button_presentation;
        private Button button_history;
    }
}
