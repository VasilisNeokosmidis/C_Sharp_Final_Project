namespace Peripatos_UI
{
    partial class Presentation_Form
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
            panelVideo = new Panel();
            button_about = new Button();
            button_exit = new Button();
            button_mainform = new Button();
            SuspendLayout();
            // 
            // panelVideo
            // 
            panelVideo.BackColor = Color.Black;
            panelVideo.Location = new Point(12, 12);
            panelVideo.Name = "panelVideo";
            panelVideo.Size = new Size(776, 360);
            panelVideo.TabIndex = 0;
            // 
            // button_about
            // 
            button_about.Location = new Point(12, 386);
            button_about.Name = "button_about";
            button_about.Size = new Size(110, 52);
            button_about.TabIndex = 11;
            button_about.Text = "Σχετικά";
            button_about.UseVisualStyleBackColor = true;
            button_about.Click += button_about_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Transparent;
            button_exit.Location = new Point(678, 386);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(110, 52);
            button_exit.TabIndex = 12;
            button_exit.Text = "ΕΞΟΔΟΣ";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_mainform
            // 
            button_mainform.Location = new Point(346, 386);
            button_mainform.Name = "button_mainform";
            button_mainform.Size = new Size(110, 52);
            button_mainform.TabIndex = 13;
            button_mainform.Text = "Αρχικό Μενού";
            button_mainform.UseVisualStyleBackColor = true;
            button_mainform.Click += button_mainform_Click;
            // 
            // Presentation_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelVideo);
            Controls.Add(button_mainform);
            Controls.Add(button_exit);
            Controls.Add(button_about);
            Name = "Presentation_Form";
            Text = "Presentation_Form";
            FormClosed += Presentation_Form_FormClosed;
            Load += Presentation_Form_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panelVideo;
        private Button button_about;
        private Button button_exit;
        private Button button_mainform;
    }
}