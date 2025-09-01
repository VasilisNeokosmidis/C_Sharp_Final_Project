namespace Peripatos_UI
{
    partial class Register_Form
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
            errorProvider1 = new ErrorProvider(components);
            Label_RegisterTitle = new Label();
            Textbox_Username = new TextBox();
            Label_Username = new Label();
            Label_Password = new Label();
            Textbox_Password = new TextBox();
            Button_Submit = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Label_RegisterTitle
            // 
            Label_RegisterTitle.Anchor = AnchorStyles.Top;
            Label_RegisterTitle.AutoSize = true;
            Label_RegisterTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_RegisterTitle.Location = new Point(80, 20);
            Label_RegisterTitle.Name = "Label_RegisterTitle";
            Label_RegisterTitle.Size = new Size(290, 37);
            Label_RegisterTitle.TabIndex = 0;
            Label_RegisterTitle.Text = "Register to Peripatos";
            Label_RegisterTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Textbox_Username
            // 
            Textbox_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox_Username.Location = new Point(150, 110);
            Textbox_Username.Name = "Textbox_Username";
            Textbox_Username.Size = new Size(250, 29);
            Textbox_Username.TabIndex = 1;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Username.Location = new Point(60, 113);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(84, 21);
            Label_Username.TabIndex = 2;
            Label_Username.Text = "Username:";
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Password.Location = new Point(60, 163);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(79, 21);
            Label_Password.TabIndex = 3;
            Label_Password.Text = "Password:";
            // 
            // Textbox_Password
            // 
            Textbox_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox_Password.Location = new Point(150, 160);
            Textbox_Password.Name = "Textbox_Password";
            Textbox_Password.Size = new Size(250, 29);
            Textbox_Password.TabIndex = 4;
            Textbox_Password.UseSystemPasswordChar = true;
            Textbox_Password.TextChanged += Textbox_Password_TextChanged;
            // 
            // Button_Submit
            // 
            Button_Submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Submit.Location = new Point(180, 220);
            Button_Submit.Name = "Button_Submit";
            Button_Submit.Size = new Size(120, 40);
            Button_Submit.TabIndex = 5;
            Button_Submit.Text = "Register";
            Button_Submit.UseVisualStyleBackColor = true;
            Button_Submit.Click += Button_Submit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 280);
            Controls.Add(Button_Submit);
            Controls.Add(Textbox_Password);
            Controls.Add(Label_Password);
            Controls.Add(Label_Username);
            Controls.Add(Textbox_Username);
            Controls.Add(Label_RegisterTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peripatos - Register";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label Label_RegisterTitle;
        private TextBox Textbox_Username;
        private Label Label_Username;
        private Label Label_Password;
        private TextBox Textbox_Password;
        private Button Button_Submit;
    }
}