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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Label_LoginTitle
            // 
            Label_LoginTitle.Location = new Point(150, -4);
            Label_LoginTitle.Size = new Size(341, 45);
            Label_LoginTitle.Text = "Register to \"Peripatos\"";
            // 
            // LoginForm_Label_CreateUser
            // 
            LoginForm_Label_CreateUser.Location = new Point(12, 407);
            // 
            // LoginForm_LinkLabel_CreateUserForm
            // 
            LoginForm_LinkLabel_CreateUserForm.Location = new Point(411, 407);
            // 
            // LoginForm_LinkLabel_GuestForm
            // 
            LoginForm_LinkLabel_GuestForm.Location = new Point(371, 407);
            // LoginForm_Label_GuestForm
            // 
            LoginForm_Label_GuestForm.Location = new Point(24, 424);
            // 
            // Button_Submit
            // 
            Button_Submit.Location = new Point(228, 258);
            Button_Submit.Margin = new Padding(3, 2, 3, 2);
            Button_Submit.Size = new Size(148, 38);
            Button_Submit.Text = "Register";
            // 
            // Textbox_Password
            // 
            Textbox_Password.Location = new Point(259, 187);
            Textbox_Password.Margin = new Padding(3, 4, 3, 4);
            Textbox_Password.Size = new Size(249, 35);
            Textbox_Password.TextChanged += Textbox_Password_TextChanged;
            // 
            // Textbox_Username
            // 
            Textbox_Username.Size = new Size(249, 35);
            // 
            // Label_Password
            // 
            Label_Password.Location = new Point(150, 187);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register_Form";
            Text = "Peripatos - Register";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
    }
}