using Peripatos.Core;
namespace Peripatos_UI
{
    public partial class Main_Form : Form
    {
        private readonly SessionContext _session;
        public Main_Form(SessionContext session)
        {
            _session = session;
            InitializeComponent();

            _session.Changed += Session_Changed;
            ApplySessionToUi();
        }

        private void Session_Changed(object? sender, EventArgs e)
        {
            ApplySessionToUi();
        }

        private void ApplySessionToUi()
        {
            // Is someone signed in (not a Guest)?
            bool isAuth = _session.IsAuthenticated;

            if (isAuth)
            {
                this.Text = "MyApp — " + _session.User.Username;
                button_login.Visible = false;
                button_logout.Visible = true;
                button_register.Visible = false;
                loginToolStripMenuItem.Enabled = false;
                registerToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.Text = "MyApp — Guest";
                button_login.Visible = true;
                button_logout.Visible = false;
                button_register.Visible = true;
                loginToolStripMenuItem.Enabled = true;
                registerToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
            }
        }

        private void label_tour_odigos_Click(object sender, EventArgs e)
        {

        }
        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                using (var reg = new Register_Form())
                {
                    reg.StartPosition = FormStartPosition.CenterScreen; // owner is hidden
                    var regResult = reg.ShowDialog(this);

                    if (regResult == DialogResult.OK)
                    {
                        using (var login = new Login_Form())
                        {
                            login.StartPosition = FormStartPosition.CenterScreen;
                            var loginResult = login.ShowDialog(this);

                            if (loginResult == DialogResult.OK && login.AuthenticatedUser != null)
                            {
                                _session.SignIn(login.AuthenticatedUser); // now signed in
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


        private void button_login_Click(object sender, EventArgs e)
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
                        _session.SignIn(login.AuthenticatedUser);

                    }
                    else if (login.ContinueAsGuest)
                    {
                        _session.SignOut();
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


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_about.PerformClick();
        }

        //Σύνδεση μενού με τα κουμπιά
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_register.PerformClick();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_login.PerformClick();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_logout.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_beaches_Click(object sender, EventArgs e)
        {
            this.Hide();
            var beaches = new Beaches_Form(_session);
            beaches.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };
            beaches.Show(this);
        }

        private void button_sights_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sights = new Sights_Form(_session);
            sights.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };
            sights.Show(this);
        }
        private void button_restaurants_Click(object sender, EventArgs e)
        {
            this.Hide();
            var restaurants = new Restaurant_Form(_session);
            restaurants.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };
            restaurants.Show(this);
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            _session.SignOut();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός\nDeveloped by Άγγελος Μπερκέτης και Βασίλης Νεοκοσμίδης", "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
