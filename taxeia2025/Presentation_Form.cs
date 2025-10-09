using Peripatos.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Presentation_Form : Base_Form
    {
        public Presentation_Form()
        {
            InitializeComponent();
        }

        public Presentation_Form(SessionContext session) : base(session)
        {
            InitializeComponent();
        }

        private void Presentation_Form_Load(object sender, EventArgs e)
        {
            ShowUserMessage();
        }

        private void ShowUserMessage()
        {
            panelVideo.Controls.Clear();

            string message;
            Color backColor;

            if (Session?.IsAuthenticated == true && !Session.User.IsGuest)
            {
                message = $"🎬 Καλώς ήρθατε {Session.User.Username}! 🎬\n\nΩς εγγεγραμμένος χρήστης,\nκάντε κλικ για να δείτε το βίντεο\nγια την Πάρο!";
                backColor = Color.DarkGreen;
            }
            else
            {
                message = "🔒 Περιορισμένη Πρόσβαση 🔒\n\nΑν είστε εγγεγραμμένος χρήστης,\nμπορείτε να δείτε το βίντεο\nγια την Πάρο.\n\nΠαρακαλώ συνδεθείτε.";
                backColor = Color.DarkRed;
            }

            var messageLabel = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                BackColor = backColor,
                ForeColor = Color.White,
                Font = new Font("Calibri", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Session?.IsAuthenticated == true && !Session.User.IsGuest ? Cursors.Hand : Cursors.Default
            };

            if (Session?.IsAuthenticated == true && !Session.User.IsGuest)
            {
                messageLabel.Click += MessageLabel_Click;
            }

            panelVideo.Controls.Add(messageLabel);
        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "Videos", "Paros.mp4");

            if (File.Exists(videoPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = videoPath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Το αρχείο βίντεο δεν βρέθηκε.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Presentation_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_mainform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός\nDeveloped by Άγγελος Μπερκέτης και Βασίλης Νεοκοσμίδης", "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
