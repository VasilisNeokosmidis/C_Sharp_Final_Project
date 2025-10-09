namespace Peripatos_UI
{
    partial class Sights_Form
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
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).BeginInit();
            SuspendLayout();
            // 
            // button_Previous
            // 
            button_Previous.Text = "Προηγούμενο Αξιοθέατο";
            // 
            // button_Next
            // 
            button_Next.Text = "Επόμενο Αξιοθέατο";
            // 
            // Sights_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 545);
            Name = "Sights_Form";
            Text = "Sights_Form";
            Load += Sights_Form_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}