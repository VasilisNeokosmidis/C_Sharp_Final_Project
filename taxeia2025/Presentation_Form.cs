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
                message = $"Καλώς ήρθατε, {Session.User.Username}! \n\nΩς εγγεγραμμένος χρήστης,\nμπορείτε να κάνετε κλικ για να δείτε \nτο βίντεο για την Πάρο!";
                backColor = Color.DarkGreen;
            }
            else
            {
                message = "Περιορισμένη Πρόσβαση\n\nMπορείτε να δείτε το βίντεο για την Πάρο\nμόνο αν είστε εγγεγραμμένος χρήστης.\n\nΠαρακαλώ συνδεθείτε.";
                backColor = Color.DarkRed;
            }

            var messageLabel = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                BackColor = backColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
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
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Videos", "Paros.mp4");
            Process.Start(new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            });
        }

        private void Presentation_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_mainform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void ApplySessionToUI()
        {
            base.ApplySessionToUI();
            ShowUserMessage();
        }
    }
}
