namespace Peripatos_UI
{
    partial class Beaches_Form
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
            components = new System.ComponentModel.Container();
            PictureBox_PlaceImage = new PictureBox();
            TextBox_PlaceTitle = new TextBox();
            RichTextBox_PlaceDescription = new RichTextBox();
            button_Previous = new Button();
            button_Next = new Button();
            button_StartVoice = new Button();
            button_StopVoice = new Button();
            button_BackToMenu = new Button();
            SildeshowTimer = new System.Windows.Forms.Timer(components);
            button_SaveFile = new Button();
            Dropdown_Select_List = new ComboBox();
            button_Slideshow = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).BeginInit();
            SuspendLayout();
            // 
            // button_about
            // 
            button_about.Location = new Point(780, 233);
            button_about.Margin = new Padding(3, 4, 3, 4);
            button_about.Size = new Size(246, 72);
            // 
            // button_exit
            // 
            button_exit.Location = new Point(780, 313);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Size = new Size(246, 72);
            // 
            // PictureBox_PlaceImage
            // 
            PictureBox_PlaceImage.Location = new Point(14, 73);
            PictureBox_PlaceImage.Margin = new Padding(3, 4, 3, 4);
            PictureBox_PlaceImage.Name = "PictureBox_PlaceImage";
            PictureBox_PlaceImage.Size = new Size(739, 312);
            PictureBox_PlaceImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_PlaceImage.TabIndex = 0;
            PictureBox_PlaceImage.TabStop = false;
            // 
            // TextBox_PlaceTitle
            // 
            TextBox_PlaceTitle.Location = new Point(14, 36);
            TextBox_PlaceTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_PlaceTitle.Name = "TextBox_PlaceTitle";
            TextBox_PlaceTitle.ReadOnly = true;
            TextBox_PlaceTitle.Size = new Size(739, 27);
            TextBox_PlaceTitle.TabIndex = 1;
            TextBox_PlaceTitle.TextChanged += TextBox_PlaceTitle_TextChanged;
            // 
            // RichTextBox_PlaceDescription
            // 
            RichTextBox_PlaceDescription.Location = new Point(12, 393);
            RichTextBox_PlaceDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_PlaceDescription.Name = "RichTextBox_PlaceDescription";
            RichTextBox_PlaceDescription.ReadOnly = true;
            RichTextBox_PlaceDescription.Size = new Size(741, 185);
            RichTextBox_PlaceDescription.TabIndex = 2;
            RichTextBox_PlaceDescription.Text = "";
            // 
            // button_Previous
            // 
            button_Previous.Location = new Point(780, 522);
            button_Previous.Margin = new Padding(3, 4, 3, 4);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(121, 56);
            button_Previous.TabIndex = 3;
            button_Previous.Text = "Προηγούμενη Παραλία";
            button_Previous.UseVisualStyleBackColor = true;
            button_Previous.Click += Button_Previous_Click;
            // 
            // button_Next
            // 
            button_Next.Location = new Point(907, 522);
            button_Next.Margin = new Padding(3, 4, 3, 4);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(119, 56);
            button_Next.TabIndex = 4;
            button_Next.Text = "Επόμενη Παραλία";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Click += button_Next_Click;
            // 
            // button_StartVoice
            // 
            button_StartVoice.Location = new Point(780, 442);
            button_StartVoice.Margin = new Padding(3, 4, 3, 4);
            button_StartVoice.Name = "button_StartVoice";
            button_StartVoice.Size = new Size(121, 72);
            button_StartVoice.TabIndex = 5;
            button_StartVoice.Text = "Start Voice Button";
            button_StartVoice.UseVisualStyleBackColor = true;
            button_StartVoice.Click += button_StartVoice_Click;
            // 
            // button_StopVoice
            // 
            button_StopVoice.Location = new Point(907, 442);
            button_StopVoice.Margin = new Padding(3, 4, 3, 4);
            button_StopVoice.Name = "button_StopVoice";
            button_StopVoice.Size = new Size(119, 72);
            button_StopVoice.TabIndex = 6;
            button_StopVoice.Text = "Stop Voice Button";
            button_StopVoice.UseVisualStyleBackColor = true;
            button_StopVoice.Click += button_StopVoice_Click;
            // 
            // button_BackToMenu
            // 
            button_BackToMenu.Location = new Point(780, 73);
            button_BackToMenu.Margin = new Padding(3, 4, 3, 4);
            button_BackToMenu.Name = "button_BackToMenu";
            button_BackToMenu.Size = new Size(246, 72);
            button_BackToMenu.TabIndex = 7;
            button_BackToMenu.Text = "Πίσω στο αρχικό μενού";
            button_BackToMenu.UseVisualStyleBackColor = true;
            button_BackToMenu.Click += button_BackToMenu_Click;
            // 
            // SildeshowTimer
            // 
            SildeshowTimer.Interval = 2000;
            SildeshowTimer.Tick += SildeshowTimer_Tick;
            // 
            // button_SaveFile
            // 
            button_SaveFile.Location = new Point(780, 153);
            button_SaveFile.Margin = new Padding(3, 4, 3, 4);
            button_SaveFile.Name = "button_SaveFile";
            button_SaveFile.Size = new Size(246, 72);
            button_SaveFile.TabIndex = 8;
            button_SaveFile.Text = "Αποθήκευση σε αρχείο";
            button_SaveFile.UseVisualStyleBackColor = true;
            button_SaveFile.Click += button_SaveFile_Click;
            // 
            // Dropdown_Select_List
            // 
            Dropdown_Select_List.FormattingEnabled = true;
            Dropdown_Select_List.Location = new Point(780, 35);
            Dropdown_Select_List.Margin = new Padding(3, 4, 3, 4);
            Dropdown_Select_List.Name = "Dropdown_Select_List";
            Dropdown_Select_List.Size = new Size(246, 28);
            Dropdown_Select_List.TabIndex = 9;
            Dropdown_Select_List.SelectedIndexChanged += Dropdown_Select_List_SelectedIndexChanged;
            // 
            // button_Slideshow
            // 
            button_Slideshow.Location = new Point(780, 393);
            button_Slideshow.Name = "button_Slideshow";
            button_Slideshow.Size = new Size(246, 44);
            button_Slideshow.TabIndex = 13;
            button_Slideshow.Text = "Έναρξη/Σταμάτημα slides";
            button_Slideshow.UseVisualStyleBackColor = true;
            button_Slideshow.Click += button_Slideshow_Click;
            // 
            // Beaches_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 597);
            Controls.Add(button_Slideshow);
            Controls.Add(Dropdown_Select_List);
            Controls.Add(button_SaveFile);
            Controls.Add(button_BackToMenu);
            Controls.Add(button_StopVoice);
            Controls.Add(button_StartVoice);
            Controls.Add(button_Next);
            Controls.Add(button_Previous);
            Controls.Add(RichTextBox_PlaceDescription);
            Controls.Add(TextBox_PlaceTitle);
            Controls.Add(PictureBox_PlaceImage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Beaches_Form";
            Text = "Beaches_Form";
            Load += Beaches_Form_Load;
            Controls.SetChildIndex(PictureBox_PlaceImage, 0);
            Controls.SetChildIndex(TextBox_PlaceTitle, 0);
            Controls.SetChildIndex(RichTextBox_PlaceDescription, 0);
            Controls.SetChildIndex(button_Previous, 0);
            Controls.SetChildIndex(button_Next, 0);
            Controls.SetChildIndex(button_StartVoice, 0);
            Controls.SetChildIndex(button_StopVoice, 0);
            Controls.SetChildIndex(button_BackToMenu, 0);
            Controls.SetChildIndex(button_SaveFile, 0);
            Controls.SetChildIndex(Dropdown_Select_List, 0);
            Controls.SetChildIndex(button_about, 0);
            Controls.SetChildIndex(button_exit, 0);
            Controls.SetChildIndex(button_Slideshow, 0);
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox PictureBox_PlaceImage;
        public TextBox TextBox_PlaceTitle;
        public RichTextBox RichTextBox_PlaceDescription;
        public Button button_Previous;
        public Button button_Next;
        public Button button_StartVoice;
        public Button button_StopVoice;
        public Button button_BackToMenu;
        public System.Windows.Forms.Timer SildeshowTimer;
        public Button button_SaveFile;
        public ComboBox Dropdown_Select_List;
        private Button button_Slideshow;
    }
}