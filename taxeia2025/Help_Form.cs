using Peripatos.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Help_Form : Base_Form
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        public Help_Form(SessionContext session) : base(session)
        {
            InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {
            LoadHelpContent();
        }

        private void LoadHelpContent()
        {
            LoadOverviewContent();
            LoadGuideContent();
            LoadAboutContent();
        }

        private void LoadOverviewContent()
        {
            richTextBoxOverview.Text = @"Καλώς ήρθατε στον τουριστικό οδηγό Peripatos!

Η εφαρμογή Peripatos δημιουργήθηκε για να δείτε τις ομορφιές της Πάρου, ένα από τα πιο όμορφα νησιά της Ελλάδας.

Τι προσφέρει η εφαρμογή:
ΠΑΡΑΛΙΕΣ: Ανακαλύψτε τις παραλίες του νησιού
ΑΞΙΟΘΕΑΤΑ: Εξερευνήστε αξιοθέατα
ΕΣΤΙΑΤΟΡΙΑ: Βρείτε τα καλύτερα εστιατόρια
ΠΑΡΟΥΣΙΑΣΗ: Δείτε βίντεο για την ομορφιά της Πάρου
ΙΣΤΟΡΙΚΟ: Παρακολουθήστε τις επισκέψεις σας (μόνο για εγγεγραμμένους χρήστες)

Χαρακτηριστικά για Εγγεγραμμένους Χρήστες:
Πλήρης πρόσβαση σε όλες τις λειτουργίες της εφαρμογής
Φωνητική αφήγηση περιεχομένου
Παρακολούθηση βίντεο
Παρακολούθηση ιστορικού επισκέψεων
Αποθήκευση αρχείου τοπικά
Προσωποποιημένη εμπειρία";
        }

        private void LoadGuideContent()
        {
            richTextBoxGuide.Text = @"Οδηγός Χρήσης

1. ΕΝΑΡΞΗ ΕΦΑΡΜΟΓΗΣ
Όταν ανοίγει η εφαρμογή, μπορείτε να επιλέξτε αν θέλετε να συνδεθείτε ή να συνεχίσετε ως επισκέπτης

2. ΕΓΓΡΑΦΗ/ΣΥΝΔΕΣΗ
Εγγραφή: Κλικ στο ""Εγγραφή"" για δημιουργία λογαριασμού. Απαιτείται κωδικός με περισσότερους από 10 χαρακτήρες και τουλάχιστον ένα κεφαλαίο γράμμα, σύμβολο και αριθμό.
Σύνδεση: Εισάγετε username/password
Επισκέπτης: Περιορισμένη πρόσβαση χωρίς εγγραφή

3. ΠΛΟΗΓΗΣΗ ΣΤΙΣ ΦΟΡΜΕΣ
Χρησιμοποιήστε το κεντρικό μενού για πλοήγηση
Κάθε φόρμα έχει δικά της κουμπιά και λειτουργίες

4. ΧΡΗΣΗ ΦΟΡΜΩΝ
Παραλίες/Αξιοθέατα/Εστιατόρια:
Περιήγηση με κουμπιά Προηγούμενο/Επόμενο
Dropdown λίστα για άμεση πρόσβαση
Slideshow εικόνων (αυτόματο ή χειροκίνητο)
Voice narration (εγγεγραμμένοι χρήστες)
Αποθήκευση αρχείων (εγγεγραμμένοι χρήστες)

Παρουσίαση:
Κλικ για προβολή βίντεο (εγγεγραμμένοι χρήστες)

Ιστορικό:
Παρακολούθηση επισκέψεων σε φόρμες
Ποσοστό φορμών που έχει επισκεφθεί ο χρήστης
Καθαρισμός ιστορικού

5. ΣΥΝΤΟΜΕΥΣΕΙΣ ΠΛΗΚΤΡΟΛΟΓΙΟΥ
F1: Βοήθεια (οποιαδήποτε φόρμα)
Esc: Κλείσιμο φόρμας";
        }

        private void LoadAboutContent()
        {
            richTextBoxAbout.Text = @"Πληροφορίες Εφαρμογής

Peripatos - Ο ψηφιακός οδηγός της Πάρου

Έκδοση: 1.0

ΟΜΑΔΑ ΑΝΑΠΤΥΞΗΣ
Αυτή η εφαρμογή αναπτύχθηκε από τους (με αλφαβητική σειρά):
’γγελος Μπερκέτης
Βασίλης Νεοκοσμίδης
";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}