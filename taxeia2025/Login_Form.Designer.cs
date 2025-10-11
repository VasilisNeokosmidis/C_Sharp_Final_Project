using System.Windows.Forms;

namespace Peripatos_UI
{
    partial class Login_Form
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
            Label_LoginTitle = new Label();
            Textbox_Username = new TextBox();
            Label_Username = new Label();
            Label_Password = new Label();
            Textbox_Password = new TextBox();
            Button_Submit = new Button();
            LoginForm_Label_CreateUser = new Label();
            LoginForm_LinkLabel_CreateUserForm = new LinkLabel();
            LoginForm_Label_GuestForm = new Label();
            LoginForm_LinkLabel_GuestForm = new LinkLabel();
            SuspendLayout();
            // 
            // Label_LoginTitle
            // 
            Label_LoginTitle.Anchor = AnchorStyles.Top;
            Label_LoginTitle.AutoSize = true;
            Label_LoginTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_LoginTitle.Location = new Point(91, 27);
            Label_LoginTitle.Name = "Label_LoginTitle";
            Label_LoginTitle.Size = new Size(369, 46);
            Label_LoginTitle.TabIndex = 0;
            Label_LoginTitle.Text = "Welcome to Peripatos";
            Label_LoginTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Textbox_Username
            // 
            Textbox_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox_Username.Location = new Point(171, 147);
            Textbox_Username.Margin = new Padding(3, 4, 3, 4);
            Textbox_Username.Name = "Textbox_Username";
            Textbox_Username.Size = new Size(285, 34);
            Textbox_Username.TabIndex = 1;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Username.Location = new Point(69, 151);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(103, 28);
            Label_Username.TabIndex = 2;
            Label_Username.Text = "Username:";
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Password.Location = new Point(69, 217);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(97, 28);
            Label_Password.TabIndex = 3;
            Label_Password.Text = "Password:";
            // 
            // Textbox_Password
            // 
            Textbox_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox_Password.Location = new Point(171, 213);
            Textbox_Password.Margin = new Padding(3, 4, 3, 4);
            Textbox_Password.Name = "Textbox_Password";
            Textbox_Password.Size = new Size(285, 34);
            Textbox_Password.TabIndex = 4;
            Textbox_Password.UseSystemPasswordChar = true;
            // 
            // Button_Submit
            // 
            Button_Submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Submit.Location = new Point(206, 293);
            Button_Submit.Margin = new Padding(3, 4, 3, 4);
            Button_Submit.Name = "Button_Submit";
            Button_Submit.Size = new Size(137, 53);
            Button_Submit.TabIndex = 5;
            Button_Submit.Text = "Login";
            Button_Submit.UseVisualStyleBackColor = true;
            Button_Submit.Click += Button_Submit_Click;
            // 
            // LoginForm_Label_CreateUser
            // 
            LoginForm_Label_CreateUser.AutoSize = true;
            LoginForm_Label_CreateUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginForm_Label_CreateUser.Location = new Point(69, 373);
            LoginForm_Label_CreateUser.Name = "LoginForm_Label_CreateUser";
            LoginForm_Label_CreateUser.Size = new Size(287, 20);
            LoginForm_Label_CreateUser.TabIndex = 6;
            LoginForm_Label_CreateUser.Text = "Δεν έχετε εγγραφεί; Φτιάξτε Λογαριασμό";
            // 
            // LoginForm_LinkLabel_CreateUserForm
            // 
            LoginForm_LinkLabel_CreateUserForm.AutoSize = true;
            LoginForm_LinkLabel_CreateUserForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginForm_LinkLabel_CreateUserForm.Location = new Point(362, 373);
            LoginForm_LinkLabel_CreateUserForm.Name = "LoginForm_LinkLabel_CreateUserForm";
            LoginForm_LinkLabel_CreateUserForm.Size = new Size(37, 20);
            LoginForm_LinkLabel_CreateUserForm.TabIndex = 7;
            LoginForm_LinkLabel_CreateUserForm.TabStop = true;
            LoginForm_LinkLabel_CreateUserForm.Text = "εδώ";
            LoginForm_LinkLabel_CreateUserForm.LinkClicked += LoginForm_LinkLabel_CreateUserForm_LinkClicked;
            // 
            // LoginForm_Label_GuestForm
            // 
            LoginForm_Label_GuestForm.AutoSize = true;
            LoginForm_Label_GuestForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginForm_Label_GuestForm.Location = new Point(69, 407);
            LoginForm_Label_GuestForm.Name = "LoginForm_Label_GuestForm";
            LoginForm_Label_GuestForm.Size = new Size(386, 20);
            LoginForm_Label_GuestForm.TabIndex = 8;
            LoginForm_Label_GuestForm.Text = "Συνεχίστε σαν επισκέπτης με περιορισμένα δικαιώματα";
            // 
            // LoginForm_LinkLabel_GuestForm
            // 
            LoginForm_LinkLabel_GuestForm.AutoSize = true;
            LoginForm_LinkLabel_GuestForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginForm_LinkLabel_GuestForm.Location = new Point(461, 407);
            LoginForm_LinkLabel_GuestForm.Name = "LoginForm_LinkLabel_GuestForm";
            LoginForm_LinkLabel_GuestForm.Size = new Size(37, 20);
            LoginForm_LinkLabel_GuestForm.TabIndex = 9;
            LoginForm_LinkLabel_GuestForm.TabStop = true;
            LoginForm_LinkLabel_GuestForm.Text = "εδώ";
            LoginForm_LinkLabel_GuestForm.LinkClicked += LoginForm_LinkLabel_GuestForm_LinkClicked;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 480);
            Controls.Add(LoginForm_LinkLabel_GuestForm);
            Controls.Add(LoginForm_Label_GuestForm);
            Controls.Add(LoginForm_LinkLabel_CreateUserForm);
            Controls.Add(LoginForm_Label_CreateUser);
            Controls.Add(Button_Submit);
            Controls.Add(Textbox_Password);
            Controls.Add(Label_Password);
            Controls.Add(Label_Username);
            Controls.Add(Textbox_Username);
            Controls.Add(Label_LoginTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peripatos - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label_Username;
        protected Label Label_LoginTitle;
        protected Label LoginForm_Label_CreateUser;
        protected LinkLabel LoginForm_LinkLabel_CreateUserForm;
        protected LinkLabel LoginForm_LinkLabel_GuestForm;
        protected Label LoginForm_Label_GuestForm;
        protected Button Button_Submit;
        protected TextBox Textbox_Password;
        protected TextBox Textbox_Username;
        protected Label Label_Password;
    }
}
