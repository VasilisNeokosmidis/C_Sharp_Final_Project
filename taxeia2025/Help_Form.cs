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
            richTextBoxOverview.Text = @"����� ������ ���� ���������� ����� Peripatos!

� �������� Peripatos ������������� ��� �� ����� ��� �������� ��� �����, ��� ��� �� ��� ������ ����� ��� �������.

�� ��������� � ��������:
��������: ���������� ��� �������� ��� ������
���������: ����������� ���������
����������: ������ �� �������� ����������
����������: ����� ������ ��� ��� ������� ��� �����
��������: �������������� ��� ���������� ��� (���� ��� �������������� �������)

�������������� ��� �������������� �������:
������ �������� �� ���� ��� ����������� ��� ���������
�������� ������� ������������
������������� ������
������������� ��������� ����������
���������� ������� ������
��������������� ��������";
        }

        private void LoadGuideContent()
        {
            richTextBoxGuide.Text = @"������ ������

1. ������ ���������
���� ������� � ��������, �������� �� �������� �� ������ �� ���������� � �� ���������� �� ����������

2. �������/�������
�������: ���� ��� ""�������"" ��� ���������� �����������. ���������� ������� �� ������������� ��� 10 ���������� ��� ����������� ��� �������� ������, ������� ��� ������.
�������: �������� username/password
����������: ������������ �������� ����� �������

3. �������� ���� ������
�������������� �� �������� ����� ��� ��������
���� ����� ���� ���� ��� ������� ��� �����������

4. ����� ������
��������/���������/����������:
��������� �� ������� �����������/�������
Dropdown ����� ��� ����� ��������
Slideshow ������� (�������� � �����������)
Voice narration (������������� �������)
���������� ������� (������������� �������)

����������:
���� ��� ������� ������ (������������� �������)

��������:
������������� ���������� �� ������
������� ������ ��� ���� ���������� � �������
���������� ���������

5. ������������ �������������
F1: ������� (����������� �����)
Esc: �������� ������
Enter: ������� ������ (slideshow)";
        }

        private void LoadAboutContent()
        {
            richTextBoxAbout.Text = @"����������� ���������

Peripatos - � �������� ������ ��� �����

������: 1.0

����� ���������
���� � �������� ����������� ��� ���� (�� ���������� �����):
������� ���������
������� �����������
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