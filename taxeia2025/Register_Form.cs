using Peripatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
            Button_Submit.Enabled = false;
            errorProvider1.SetIconPadding(Textbox_Password, 2);
            errorProvider1.SetIconPadding(Textbox_Username, 2);
            errorProvider1.Icon = SystemIcons.Warning;
        }

        private void Textbox_Password_TextChanged(object sender, EventArgs e)
        {
            string password = Textbox_Password.Text;
            var errors = new List<string>();

            if (!Regex.IsMatch(password, @"^.{10,}$"))
                errors.Add("≥10 chars");
            if (!Regex.IsMatch(password, @"[A-Z]"))
                errors.Add("an uppercase letter");
            if (!Regex.IsMatch(password, @"[^A-Za-z0-9]"))
                errors.Add("a symbol");
            if (!Regex.IsMatch(password, @"\d"))
                errors.Add("a digit");

            if (errors.Count > 0)
            {
                errorProvider1.SetError(Textbox_Password, "Password Requirements: " + string.Join(", ", errors));
                Textbox_Password.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(Textbox_Password, "");
                Textbox_Password.BackColor = SystemColors.Window;
            }

            UpdateSubmitButton();
        }

        private void Textbox_Username_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername();
        }

        private void ValidateUsername()
        {
            string username = Textbox_Username.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                errorProvider1.SetError(Textbox_Username, "Username is required");
                Textbox_Username.BackColor = Color.MistyRose;
                UpdateSubmitButton();
                return;
            }

            try
            {
                if (Database.UsernameExists(username))
                {
                    errorProvider1.SetError(Textbox_Username, "Username already exists. Please choose another one.");
                    Textbox_Username.BackColor = Color.MistyRose;
                    UpdateSubmitButton();
                    return;
                }
            }
            catch (Exception)
            {
                
            }

            errorProvider1.SetError(Textbox_Username, "");
            Textbox_Username.BackColor = SystemColors.Window;
            UpdateSubmitButton();
        }

        private void UpdateSubmitButton()
        {
            bool usernameValid = string.IsNullOrEmpty(errorProvider1.GetError(Textbox_Username)) && 
                                !string.IsNullOrWhiteSpace(Textbox_Username.Text);
            
            bool passwordValid = string.IsNullOrEmpty(errorProvider1.GetError(Textbox_Password)) && 
                                !string.IsNullOrWhiteSpace(Textbox_Password.Text);

            Button_Submit.Enabled = usernameValid && passwordValid;
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string username = Textbox_Username.Text.Trim();
            string password = Textbox_Password.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Database.UsernameExists(username))
                {
                    MessageBox.Show("That username is already taken. Please choose another one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Textbox_Username.Focus();
                    return;
                }

                bool created = Database.Insert_User(username, password);
                
                if (!created)
                {
                    MessageBox.Show("Registration failed. Please try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Registration successful! You can now log in with your credentials.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
