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
            
            // Button submit disabled by default
            Button_Submit.Enabled = false;

            // Settings for error
            errorProvider1.SetIconPadding(Textbox_Password, 2);
            errorProvider1.Icon = SystemIcons.Warning;
        }

        private void Textbox_Password_TextChanged(object sender, EventArgs e)
        {
            string input_Password = Textbox_Password.Text;
            var error_messages = new List<string>();

            //More than 10 chars
            const string CheckLength10Chars = @"^.{10,}$";

            //More than 1 uppercase letter
            const string Check1UpperCase = @"[A-Z]";

            //More than 1 symbol
            const string Check1Symbol = @"[^A-Za-z0-9]";

            //More than 1 digit
            const string Check1Digit = @"\d";


            bool isCheckLength10Chars = Regex.IsMatch(input_Password, CheckLength10Chars);
            bool isCheck1UpperCase = Regex.IsMatch(input_Password, Check1UpperCase);
            bool isCheck1Symbol = Regex.IsMatch(input_Password, Check1Symbol);
            bool isCheck1Digit = Regex.IsMatch(input_Password, Check1Digit);

            if (!isCheckLength10Chars)
            {
                error_messages.Add("≥10 chars");
            }
            if (!isCheck1UpperCase)
            {
                error_messages.Add("an uppercase letter");
            }
            if (!isCheck1Symbol)
            {
                error_messages.Add("a symbol");
            }
            if (!isCheck1Digit)
            {
                error_messages.Add("a digit");
            }


            if (error_messages.Count != 0)
            {
                Button_Submit.Enabled = false;
                // show a single concatenated error message
                errorProvider1.SetError(Textbox_Password, "Password Requirements: " + string.Join(", ", error_messages));

                // color the TextBox background light red
                Textbox_Password.BackColor = Color.MistyRose;
            }
            else
            {
                Button_Submit.Enabled = true;

                // clear error and restore normal background
                errorProvider1.SetError(Textbox_Password, "");
                Textbox_Password.BackColor = SystemColors.Window;
            }

        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            bool created;
            try
            {
                created = Database.Insert_User(Textbox_Username.Text.Trim(), Textbox_Password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected database error occurred:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!created)
            {
                MessageBox.Show(
                    "That username is already taken. Please choose another one.",
                    "Registration Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
