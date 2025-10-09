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
            // button_about
            // 
            button_about.Location = new Point(780, 233);
            button_about.Margin = new Padding(3, 4, 3, 4);
            button_about.Size = new Size(173, 72);
            // 
            // button_exit
            // 
            button_exit.Location = new Point(780, 313);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Size = new Size(173, 72);
            // 
            // PictureBox_PlaceImage
            // 
            PictureBox_PlaceImage.Location = new Point(14, 73);
            PictureBox_PlaceImage.Margin = new Padding(3, 4, 3, 4);
            PictureBox_PlaceImage.Size = new Size(739, 312);
            // 
            // TextBox_PlaceTitle
            // 
            TextBox_PlaceTitle.Location = new Point(14, 36);
            TextBox_PlaceTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_PlaceTitle.Size = new Size(739, 27);
            // 
            // RichTextBox_PlaceDescription
            // 
            RichTextBox_PlaceDescription.Location = new Point(12, 393);
            RichTextBox_PlaceDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_PlaceDescription.Size = new Size(741, 185);
            // 
            // button_Previous
            // 
            button_Previous.Location = new Point(780, 522);
            button_Previous.Margin = new Padding(3, 4, 3, 4);
            button_Previous.Size = new Size(121, 56);
            button_Previous.Text = "Προηγούμενο Αξιοθέατο";
            // 
            // button_Next
            // 
            button_Next.Location = new Point(907, 522);
            button_Next.Margin = new Padding(3, 4, 3, 4);
            button_Next.Size = new Size(119, 56);
            button_Next.Text = "Επόμενο Αξιοθέατο";
            // 
            // button_StartVoice
            // 
            button_StartVoice.Location = new Point(780, 442);
            button_StartVoice.Margin = new Padding(3, 4, 3, 4);
            button_StartVoice.Size = new Size(121, 72);
            // 
            // button_StopVoice
            // 
            button_StopVoice.Location = new Point(907, 442);
            button_StopVoice.Margin = new Padding(3, 4, 3, 4);
            button_StopVoice.Size = new Size(119, 72);
            // 
            // button_BackToMenu
            // 
            button_BackToMenu.Location = new Point(780, 73);
            button_BackToMenu.Margin = new Padding(3, 4, 3, 4);
            button_BackToMenu.Size = new Size(173, 72);
            // 
            // button_SaveFile
            // 
            button_SaveFile.Location = new Point(780, 153);
            button_SaveFile.Margin = new Padding(3, 4, 3, 4);
            button_SaveFile.Size = new Size(173, 72);
            // 
            // Dropdown_Select_List
            // 
            Dropdown_Select_List.Location = new Point(995, 36);
            Dropdown_Select_List.Margin = new Padding(3, 4, 3, 4);
            Dropdown_Select_List.Size = new Size(194, 28);
            // 
            // Sights_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 727);
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