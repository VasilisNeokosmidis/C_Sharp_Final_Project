using Peripatos.Core;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class History_Form : Base_Form
    {
        public History_Form()
        {
            InitializeComponent();
            InitializeHistoryControls();
        }

        public History_Form(SessionContext session) : base(session)
        {
            InitializeComponent();
            InitializeHistoryControls();
        }

        private void InitializeHistoryControls()
        {
            this.Text = "Ιστορικό Επισκέψεων";
            this.ClientSize = new Size(800, 600);

            // Setup ListView columns
            listViewHistory.Columns.Add("Φόρμα", 200);
            listViewHistory.Columns.Add("Κατάσταση", 150);
            listViewHistory.Columns.Add("Τελευταία Επίσκεψη", 200);
            listViewHistory.Columns.Add("Περιγραφή", 200);
        }

        private void History_Form_Load(object sender, EventArgs e)
        {
            // Check if user has access to history
            if (Session == null || !Session.IsAuthenticated || Session.User.IsGuest)
            {
                MessageBox.Show(
                    "Η πρόσβαση στο ιστορικό επιτρέπεται μόνο σε εγγεγραμμένους χρήστες.\n\nΠαρακαλώ συνδεθείτε με τον λογαριασμό σας.",
                    "Πρόσβαση Απαγορευμένη",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                this.Close();
                return;
            }

            LoadHistoryData();
        }

        private void LoadHistoryData()
        {
            if (Session?.History == null) return;

            listViewHistory.Items.Clear();

            var history = Session.History;
            var totalForms = history.AvailableForms.Count;
            var visitedForms = history.VisitedForms.Count;

            // Update stats
            labelStats.Text = $"Στατιστικά: Επισκεφθήκατε {visitedForms}/{totalForms} φόρμες ({history.GetCompletionPercentage():F1}%)";
            progressBar.Value = (int)history.GetCompletionPercentage();

            // Load form data
            foreach (var formName in history.AvailableForms)
            {
                var displayName = history.GetFormDisplayName(formName);
                var hasVisited = history.HasVisitedForm(formName);
                var lastVisit = history.GetLastVisitTime(formName);

                var item = new ListViewItem(displayName);
                
                if (hasVisited)
                {
                    item.SubItems.Add("Επισκεφθήκατε");
                    item.SubItems.Add(lastVisit?.ToString("dd/MM/yyyy HH:mm") ?? "N/A");
                    item.BackColor = Color.LightGreen;
                }
                else
                {
                    item.SubItems.Add("Δεν επισκεφθήκατε");
                    item.SubItems.Add("-");
                    item.BackColor = Color.LightPink;
                }

                item.SubItems.Add(GetFormDescription(formName));
                listViewHistory.Items.Add(item);
            }

            // Auto-resize columns
            foreach (ColumnHeader column in listViewHistory.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private string GetFormDescription(string formName)
        {
            if (formName == "Beaches_Form") return "Πληροφορίες για παραλίες";
            if (formName == "Sights_Form") return "Αξιοθέατα και μνημεία";
            if (formName == "Restaurant_Form") return "Εστιατόρια και ταβέρνες";
            if (formName == "Presentation_Form") return "Βίντεο παρουσίασης Πάρου";
            return "Άγνωστη φόρμα";
        }

        private void ButtonClearHistory_Click(object sender, EventArgs e)
        {
            if (Session?.History == null) return;

            var result = MessageBox.Show(
                "Είστε σίγουροι ότι θέλετε να καθαρίσετε το ιστορικό επισκέψεων;\n\nΑυτή η ενέργεια δεν μπορεί να αναιρεθεί.",
                "Καθαρισμός Ιστορικού",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Session.ClearUserHistory();
                LoadHistoryData();
                MessageBox.Show("Το ιστορικό καθαρίστηκε επιτυχώς!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                ShowHelp();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}