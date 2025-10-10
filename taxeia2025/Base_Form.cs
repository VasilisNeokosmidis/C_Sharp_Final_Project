using Peripatos.Core;
using System;
using System.ComponentModel;
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
                ApplySessionToUI();
                

                string formName = this.GetType().Name;
                Session.MarkFormVisited(formName);
            }
        }

        private void Session_Changed(object? sender, EventArgs e)
        {
            ApplySessionToUI();
        }

        protected virtual void ApplySessionToUI()
        {
            ApplySessionToMenu();
            
            bool isAuth = Session?.IsAuthenticated == true;
            if (isAuth)
            {
                this.Text = $"Peripatos � {Session.User.Username}";
            }
            else
            {
                this.Text = "Peripatos � Guest";
            }
        }

        private void ApplySessionToMenu()
        {
            if (Session == null) return;

            bool isAuth = Session.IsAuthenticated;

            loginToolStripMenuItem.Enabled = !isAuth;
            registerToolStripMenuItem.Enabled = !isAuth;
            logoutToolStripMenuItem.Enabled = isAuth;
            

            historyToolStripMenuItem.Enabled = isAuth && !Session.User.IsGuest;
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

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session == null) return;

            this.Hide();
            var historyForm = new History_Form(Session);
            historyForm.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };
            historyForm.Show(this);
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session == null) return;

            var result = MessageBox.Show(
                "����� �������� ��� ������ �� ���������� �� �������� ����������;",
                "���������� ���������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Session.History.ClearHistory();
                MessageBox.Show("�� �������� ����������� ��������!", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����������� ������\nDeveloped by ������� ��������� ��� ������� �����������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����������� ������\nDeveloped by ������� ��������� ��� ������� �����������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                ShowHelp();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        protected virtual void ShowHelp()
        {
            using (var helpForm = new Help_Form(Session))
            {
                helpForm.ShowDialog(this);
            }
        }

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

        private void showHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }
    }
}