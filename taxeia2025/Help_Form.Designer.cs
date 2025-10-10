namespace Peripatos_UI
{
    partial class Help_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Form));
            tabControlHelp = new TabControl();
            tabPageOverview = new TabPage();
            richTextBoxOverview = new RichTextBox();
            tabPageGuide = new TabPage();
            richTextBoxGuide = new RichTextBox();
            tabPageAbout = new TabPage();
            richTextBoxAbout = new RichTextBox();
            buttonClose = new Button();
            labelTitle = new Label();
            tabControlHelp.SuspendLayout();
            tabPageOverview.SuspendLayout();
            tabPageGuide.SuspendLayout();
            tabPageAbout.SuspendLayout();
            SuspendLayout();
            // 
            // button_about
            // 
            button_about.Location = new Point(10, 447);
            button_about.Size = new Size(84, 37);
            // 
            // button_exit
            // 
            button_exit.Location = new Point(590, 447);
            button_exit.Size = new Size(84, 37);
            // 
            // tabControlHelp
            // 
            tabControlHelp.Controls.Add(tabPageOverview);
            tabControlHelp.Controls.Add(tabPageGuide);
            tabControlHelp.Controls.Add(tabPageAbout);
            tabControlHelp.Font = new Font("Segoe UI", 10F);
            tabControlHelp.Location = new Point(10, 68);
            tabControlHelp.Margin = new Padding(3, 2, 3, 2);
            tabControlHelp.Name = "tabControlHelp";
            tabControlHelp.SelectedIndex = 0;
            tabControlHelp.Size = new Size(679, 375);
            tabControlHelp.TabIndex = 0;
            // 
            // tabPageOverview
            // 
            tabPageOverview.Controls.Add(richTextBoxOverview);
            tabPageOverview.Location = new Point(4, 26);
            tabPageOverview.Margin = new Padding(3, 2, 3, 2);
            tabPageOverview.Name = "tabPageOverview";
            tabPageOverview.Padding = new Padding(3, 2, 3, 2);
            tabPageOverview.Size = new Size(671, 345);
            tabPageOverview.TabIndex = 0;
            tabPageOverview.Text = "Γενικές Πληροφορίες";
            tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOverview
            // 
            richTextBoxOverview.BackColor = Color.White;
            richTextBoxOverview.BorderStyle = BorderStyle.None;
            richTextBoxOverview.Dock = DockStyle.Fill;
            richTextBoxOverview.Font = new Font("Segoe UI", 11F);
            richTextBoxOverview.Location = new Point(3, 2);
            richTextBoxOverview.Margin = new Padding(3, 2, 3, 2);
            richTextBoxOverview.Name = "richTextBoxOverview";
            richTextBoxOverview.ReadOnly = true;
            richTextBoxOverview.Size = new Size(665, 341);
            richTextBoxOverview.TabIndex = 0;
            richTextBoxOverview.Text = resources.GetString("richTextBoxOverview.Text");
            // 
            // tabPageGuide
            // 
            tabPageGuide.Controls.Add(richTextBoxGuide);
            tabPageGuide.Location = new Point(4, 26);
            tabPageGuide.Margin = new Padding(3, 2, 3, 2);
            tabPageGuide.Name = "tabPageGuide";
            tabPageGuide.Padding = new Padding(3, 2, 3, 2);
            tabPageGuide.Size = new Size(671, 345);
            tabPageGuide.TabIndex = 1;
            tabPageGuide.Text = "Οδηγός Χρήσης";
            tabPageGuide.UseVisualStyleBackColor = true;
            // 
            // richTextBoxGuide
            // 
            richTextBoxGuide.BackColor = Color.White;
            richTextBoxGuide.BorderStyle = BorderStyle.None;
            richTextBoxGuide.Dock = DockStyle.Fill;
            richTextBoxGuide.Font = new Font("Segoe UI", 11F);
            richTextBoxGuide.Location = new Point(3, 2);
            richTextBoxGuide.Margin = new Padding(3, 2, 3, 2);
            richTextBoxGuide.Name = "richTextBoxGuide";
            richTextBoxGuide.ReadOnly = true;
            richTextBoxGuide.Size = new Size(665, 341);
            richTextBoxGuide.TabIndex = 0;
            richTextBoxGuide.Text = resources.GetString("richTextBoxGuide.Text");
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(richTextBoxAbout);
            tabPageAbout.Location = new Point(4, 26);
            tabPageAbout.Margin = new Padding(3, 2, 3, 2);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(3, 2, 3, 2);
            tabPageAbout.Size = new Size(671, 345);
            tabPageAbout.TabIndex = 2;
            tabPageAbout.Text = "Πληροφορίες Εφαρμογής";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAbout
            // 
            richTextBoxAbout.BackColor = Color.White;
            richTextBoxAbout.BorderStyle = BorderStyle.None;
            richTextBoxAbout.Dock = DockStyle.Fill;
            richTextBoxAbout.Font = new Font("Segoe UI", 11F);
            richTextBoxAbout.Location = new Point(3, 2);
            richTextBoxAbout.Margin = new Padding(3, 2, 3, 2);
            richTextBoxAbout.Name = "richTextBoxAbout";
            richTextBoxAbout.ReadOnly = true;
            richTextBoxAbout.Size = new Size(665, 341);
            richTextBoxAbout.TabIndex = 0;
            richTextBoxAbout.Text = resources.GetString("richTextBoxAbout.Text");
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(270, 447);
            buttonClose.Margin = new Padding(3, 2, 3, 2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(159, 49);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Κλείσιμο Βοήθειας";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkBlue;
            labelTitle.Location = new Point(10, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(679, 30);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Οδηγός Χρήστη - Peripatos Travel Guide";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Help_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 510);
            Controls.Add(labelTitle);
            Controls.Add(buttonClose);
            Controls.Add(tabControlHelp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Help_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Οδηγός Χρήστη - Peripatos";
            Load += Help_Form_Load;
            Controls.SetChildIndex(button_about, 0);
            Controls.SetChildIndex(button_exit, 0);
            Controls.SetChildIndex(tabControlHelp, 0);
            Controls.SetChildIndex(buttonClose, 0);
            Controls.SetChildIndex(labelTitle, 0);
            tabControlHelp.ResumeLayout(false);
            tabPageOverview.ResumeLayout(false);
            tabPageGuide.ResumeLayout(false);
            tabPageAbout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlHelp;
        private TabPage tabPageOverview;
        private TabPage tabPageGuide;
        private TabPage tabPageAbout;
        private RichTextBox richTextBoxOverview;
        private RichTextBox richTextBoxGuide;
        private RichTextBox richTextBoxAbout;
        private Button buttonClose;
        private Label labelTitle;
    }
}