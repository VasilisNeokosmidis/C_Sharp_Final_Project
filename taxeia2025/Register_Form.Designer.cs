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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Label_RegisterTitle
            // 
            Label_RegisterTitle.Anchor = AnchorStyles.Top;
            Label_RegisterTitle.AutoSize = true;
            Label_RegisterTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_RegisterTitle.Location = new Point(91, 27);
            Label_RegisterTitle.Name = "Label_RegisterTitle";
            Label_RegisterTitle.Size = new Size(352, 46);
            Label_RegisterTitle.TabIndex = 0;
            Label_RegisterTitle.Text = "Register to Peripatos";
            Label_RegisterTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Textbox_Username
            // 
            Textbox_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox_Username.Location = new Point(178, 151);
            Textbox_Username.Margin = new Padding(3, 5, 3, 5);
            Textbox_Username.Name = "Textbox_Username";
            Textbox_Username.Size = new Size(286, 34);
            Textbox_Username.TabIndex = 1;
            Textbox_Username.TextChanged += Textbox_Username_TextChanged;
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
            Textbox_Password.Location = new Point(178, 214);
            Textbox_Password.Margin = new Padding(3, 4, 3, 4);
            Textbox_Password.Name = "Textbox_Password";
            Textbox_Password.Size = new Size(286, 34);
            Textbox_Password.TabIndex = 4;
            Textbox_Password.UseSystemPasswordChar = true;
            Textbox_Password.TextChanged += Textbox_Password_TextChanged;
            // 
            // Button_Submit
            // 
            Button_Submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Submit.Location = new Point(233, 281);
            Button_Submit.Margin = new Padding(3, 4, 3, 4);
            Button_Submit.Name = "Button_Submit";
            Button_Submit.Size = new Size(137, 53);
            Button_Submit.TabIndex = 5;
            Button_Submit.Text = "Register";
            Button_Submit.UseVisualStyleBackColor = true;
            Button_Submit.Click += Button_Submit_Click;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 373);
            Controls.Add(Button_Submit);
            Controls.Add(Textbox_Password);
            Controls.Add(Label_Password);
            Controls.Add(Label_Username);
            Controls.Add(Textbox_Username);
            Controls.Add(Label_RegisterTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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