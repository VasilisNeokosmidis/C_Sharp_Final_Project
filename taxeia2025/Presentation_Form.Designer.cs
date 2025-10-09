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
            button_mainform = new Button();
            SuspendLayout();
            // 
            // button_about
            // 
            button_about.Location = new Point(12, 373);
            // 
            // button_exit
            // 
            button_exit.Location = new Point(678, 373);
            // 
            // panelVideo
            // 
            panelVideo.BackColor = Color.Black;
            panelVideo.Location = new Point(12, 33);
            panelVideo.Name = "panelVideo";
            panelVideo.Size = new Size(776, 334);
            panelVideo.TabIndex = 0;
            // 
            // button_mainform
            // 
            button_mainform.Location = new Point(342, 373);
            button_mainform.Name = "button_mainform";
            button_mainform.Size = new Size(110, 65);
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
            Name = "Presentation_Form";
            Text = "Presentation_Form";
            FormClosed += Presentation_Form_FormClosed;
            Load += Presentation_Form_Load;
            Controls.SetChildIndex(button_about, 0);
            Controls.SetChildIndex(button_exit, 0);
            Controls.SetChildIndex(button_mainform, 0);
            Controls.SetChildIndex(panelVideo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelVideo;
        private Button button_mainform;
    }
}