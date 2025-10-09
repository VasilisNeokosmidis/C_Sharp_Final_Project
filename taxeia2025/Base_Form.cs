using Peripatos.Core;
using System;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Base_Form : Form
    {
        protected SessionContext? Session { get; private set; }

        public Base_Form()
        {
            InitializeComponent();
        }

        public Base_Form(SessionContext session) : this()
        {
            Session = session;
        }

        private void Base_Form_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                Session.Changed += Session_Changed;
                ApplySessionToMenu();
            }
        }

        private void Session_Changed(object? sender, EventArgs e)
        {
            ApplySessionToMenu();
        }

        private void ApplySessionToMenu()
        {
            if (Session == null) return;

            bool isAuth = Session.IsAuthenticated;

            loginToolStripMenuItem.Enabled = !isAuth;
            registerToolStripMenuItem.Enabled = !isAuth;
            logoutToolStripMenuItem.Enabled = isAuth;
        }

        #region Menu Event Handlers

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                using (var reg = new Register_Form())
                {
                    reg.StartPosition = FormStartPosition.CenterScreen;
                    var regResult = reg.ShowDialog(this);

                    if (regResult == DialogResult.OK)
                    {
                        using (var login = new Login_Form())
                        {
                            login.StartPosition = FormStartPosition.CenterScreen;
                            var loginResult = login.ShowDialog(this);

                            if (loginResult == DialogResult.OK && login.AuthenticatedUser != null)
                            {
                                Session?.SignIn(login.AuthenticatedUser);
                            }
                        }
                    }
                }
            }
            finally
            {
                this.Show();
                this.Activate();
                this.BringToFront();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                using (var login = new Login_Form())
                {
                    login.StartPosition = FormStartPosition.CenterParent;
                    var result = login.ShowDialog(this);

                    if (result == DialogResult.OK && login.AuthenticatedUser != null)
                    {
                        Session?.SignIn(login.AuthenticatedUser);
                    }
                    else if (login.ContinueAsGuest)
                    {
                        Session?.SignOut();
                    }
                }
            }
            finally
            {
                this.Show();
                this.Activate();
                this.BringToFront();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session?.SignOut();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός\nDeveloped by ’γγελος Μπερκέτης και Βασίλης Νεοκοσμίδης", "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Session != null)
                {
                    Session.Changed -= Session_Changed;
                }
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός\nDeveloped by ’γγελος Μπερκέτης και Βασίλης Νεοκοσμίδης", "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}