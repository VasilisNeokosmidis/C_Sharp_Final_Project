namespace Peripatos_UI
{
    partial class Restaurant_Form
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
            // TextBox_PlaceTitle
            // 
            TextBox_PlaceTitle.Margin = new Padding(3, 5, 3, 5);
            // 
            // RichTextBox_PlaceDescription
            // 
            RichTextBox_PlaceDescription.Margin = new Padding(3, 5, 3, 5);
            RichTextBox_PlaceDescription.Size = new Size(739, 245);
            // 
            // button_Previous
            // 
            button_Previous.Text = "Προηγούμενο Εστιατόριο";
            // 
            // button_Next
            // 
            button_Next.Text = "Επόμενο Εστιατόριο";
            // 
            // Restaurant_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 772);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Restaurant_Form";
            Text = "Restaurant_Form";
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}