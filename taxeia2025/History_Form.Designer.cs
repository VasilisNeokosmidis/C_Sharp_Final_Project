namespace Peripatos_UI
{
    partial class History_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewHistory = new ListView();
            labelStats = new Label();
            progressBar = new ProgressBar();
            buttonClearHistory = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // button_about
            // 
            button_about.Location = new Point(20, 516);
            button_about.Size = new Size(110, 65);
            button_about.Visible = true;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(670, 516);
            button_exit.Size = new Size(110, 65);
            button_exit.Visible = true;
            // 
            // listViewHistory
            // 
            listViewHistory.BorderStyle = BorderStyle.FixedSingle;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.Location = new Point(20, 160);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(760, 350);
            listViewHistory.TabIndex = 0;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            // 
            // labelStats
            // 
            labelStats.BackColor = Color.LightBlue;
            labelStats.BorderStyle = BorderStyle.FixedSingle;
            labelStats.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelStats.Location = new Point(20, 50);
            labelStats.Name = "labelStats";
            labelStats.Size = new Size(760, 60);
            labelStats.TabIndex = 1;
            labelStats.Text = "Στατιστικά Ιστορικού";
            labelStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 120);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(760, 30);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 2;
            // 
            // buttonClearHistory
            // 
            buttonClearHistory.Location = new Point(140, 516);
            buttonClearHistory.Name = "buttonClearHistory";
            buttonClearHistory.Size = new Size(150, 65);
            buttonClearHistory.TabIndex = 3;
            buttonClearHistory.Text = "Καθαρισμός Ιστορικού";
            buttonClearHistory.UseVisualStyleBackColor = true;
            buttonClearHistory.Click += ButtonClearHistory_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(540, 516);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 65);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Κεντρικό Μενού";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += ButtonBack_Click;
            // 
            // History_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(buttonBack);
            Controls.Add(buttonClearHistory);
            Controls.Add(progressBar);
            Controls.Add(labelStats);
            Controls.Add(listViewHistory);
            Name = "History_Form";
            Text = "Ιστορικό Επισκέψεων";
            Load += History_Form_Load;
            Controls.SetChildIndex(listViewHistory, 0);
            Controls.SetChildIndex(labelStats, 0);
            Controls.SetChildIndex(progressBar, 0);
            Controls.SetChildIndex(buttonClearHistory, 0);
            Controls.SetChildIndex(buttonBack, 0);
            Controls.SetChildIndex(button_about, 0);
            Controls.SetChildIndex(button_exit, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewHistory;
        private Label labelStats;
        private ProgressBar progressBar;
        private Button buttonClearHistory;
        private Button buttonBack;
    }
}