using Peripatos.Core;
using Peripatos_UI;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Peripatos_UI
{

    public partial class Login_Form : Form
    {
        public UserProfile AuthenticatedUser { get; private set; }
        public bool ContinueAsGuest { get; private set; }
        public Login_Form()
        {
            InitializeComponent();
        }

        private void LoginForm_LinkLabel_CreateUserForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var reg = new Register_Form())
            {
                reg.StartPosition = FormStartPosition.CenterParent;
                reg.ShowDialog(this);
            }
        }

        private void LoginForm_LinkLabel_GuestForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContinueAsGuest = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected void Button_Submit_Click(object? sender, EventArgs e)
        {

            var dt = Database.Select_User(Textbox_Username.Text, Textbox_Password.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Username or password are incorrect, please try again.");
                return;
            }

            var row = dt.Rows[0];
            int userId = Convert.ToInt32(row["UserID"]);
            string username = dt.Columns.Contains("Username") ? row["Username"].ToString() : Textbox_Username.Text;

            AuthenticatedUser = UserProfile.Create(userId, username);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
