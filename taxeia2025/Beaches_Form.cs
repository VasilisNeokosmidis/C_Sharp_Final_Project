using Peripatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Beaches_Form : Base_Form
    {

        private SpeechSynthesizer? _synth;
        private SpeechSynthesizer synthesizer => _synth ??= new SpeechSynthesizer();
        private List<byte[]> _slideshowImages = [];
        private int _currentImageIndex;



        protected static bool IsDesignModeStatic =>
        LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        protected bool IsDesignMode =>
            IsDesignModeStatic || (Site?.DesignMode ?? false);
        protected virtual int ItemsCount => AppList_Manager.List_Beaches.Count;
        protected int Show_Index = 0;
        protected virtual string GetTitle(int i) => AppList_Manager.List_Beaches[i].Title;
        protected virtual string GetDescription(int i) => AppList_Manager.List_Beaches[i].Description;
        protected virtual List<byte[]> GetImages(int i) => AppList_Manager.List_Beaches[i].Images;
        protected virtual IEnumerable<string> GetAllTitles() => AppList_Manager.List_Beaches.Select(b => b.Title);



        public Beaches_Form()
        {
            InitializeComponent();
        }

        public Beaches_Form(SessionContext session) : base(session)
        {
            InitializeComponent();
        }

        private void Beaches_Form_Load(object sender, EventArgs e)
        {
            if (IsDesignMode) return;

            StartCurrentBeachSlideShow();
            Check_if_Buttons_Enabled();
            ModifyStartStopVoiceButtons();
            Add_DropdownList_Items();
            Render_new_Beach_Data();

            if (Session != null)
            {
                ApplyGuestRestrictions();
            }
            else
            {
                ApplyGuestRestrictions();
            }
        }

        protected override void ApplySessionToUI()
        {
            base.ApplySessionToUI();
            ApplyGuestRestrictions();
        }

        protected void ApplyGuestRestrictions()
        {
            bool isGuest = (Session == null) || !Session.IsAuthenticated;

            button_SaveFile.Enabled = !isGuest;
            button_StartVoice.Enabled = !isGuest;
            button_StopVoice.Enabled = !isGuest;


        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.SpeakAsyncCancelAll();
            }
            Show_Index--;
            Check_if_Buttons_Enabled();
            Render_new_Beach_Data();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.SpeakAsyncCancelAll();
            }
            Show_Index++;
            Check_if_Buttons_Enabled();
            Render_new_Beach_Data();
        }

        protected virtual void Check_if_Buttons_Enabled()
        {
            if (Show_Index == 0)
            {
                button_Previous.Enabled = false;
                button_Next.Enabled = true;
            }
            else if (Show_Index > 0 && Show_Index < ItemsCount - 1)
            {
                button_Previous.Enabled = true;
                button_Next.Enabled = true;
            }
            else
            {
                button_Previous.Enabled = true;
                button_Next.Enabled = false;
            }
        }

        protected virtual void Render_new_Beach_Data()
        {
            TextBox_PlaceTitle.Text = GetTitle(Show_Index);
            RichTextBox_PlaceDescription.Text = GetDescription(Show_Index);
            StartCurrentBeachSlideShow();
        }

        protected void ModifyStartStopVoiceButtons()
        {
            if (IsDesignMode) return;

            button_StartVoice.FlatStyle = FlatStyle.Flat;
            button_StartVoice.FlatAppearance.BorderSize = 0;
            button_StartVoice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_StartVoice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_StartVoice.BackColor = Color.Transparent;
            button_StartVoice.ForeColor = Color.Transparent;
            button_StartVoice.Text = "";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "start_voice_icon.jpg");
            button_StartVoice.Image = Image.FromFile(path);
            button_StartVoice.ImageAlign = ContentAlignment.MiddleCenter;
            button_StartVoice.TabStop = false;
            button_StartVoice.FlatAppearance.MouseOverBackColor = Color.LightGray;

            button_StopVoice.FlatStyle = FlatStyle.Flat;
            button_StopVoice.FlatAppearance.BorderSize = 0;
            button_StopVoice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_StopVoice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_StopVoice.BackColor = Color.Transparent;
            button_StopVoice.ForeColor = Color.Transparent;
            button_StopVoice.Text = "";
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "stop_voice_icon.jpg");
            button_StopVoice.Image = Image.FromFile(path);
            button_StopVoice.ImageAlign = ContentAlignment.MiddleCenter;
            button_StopVoice.TabStop = false;
            button_StopVoice.FlatAppearance.MouseOverBackColor = Color.LightGray;
        }

        private void button_StartVoice_Click(object sender, EventArgs e)
        {
            if (IsDesignMode) return;

            string text = GetDescription(Show_Index);
            synthesizer.SelectVoice("Microsoft Stefanos");
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SpeakAsync(text);
        }

        private void button_StopVoice_Click(object sender, EventArgs e)
        {
            if (IsDesignMode) return;
            synthesizer.SpeakAsyncCancelAll();
        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
            this.Close();
        }

        protected void StartCurrentBeachSlideShow()
        {
            if (IsDesignMode) return;

            _slideshowImages = GetImages(Show_Index);
            _currentImageIndex = -1;
            ShowNextImage();
            SildeshowTimer.Start();
        }

        private void ShowNextImage()
        {
            if (_slideshowImages.Count == 0) return;

            _currentImageIndex = (_currentImageIndex + 1) % _slideshowImages.Count;


            var oldImage = PictureBox_PlaceImage.Image;
            PictureBox_PlaceImage.Image = BytesToBitmapSafe(_slideshowImages[_currentImageIndex]);
            oldImage?.Dispose();
        }

        private static Bitmap BytesToBitmapSafe(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            using var temp = Image.FromStream(ms);
            return new Bitmap(temp);
        }

        private void SildeshowTimer_Tick(object sender, EventArgs e)
        {
            ShowNextImage();
        }

        protected virtual void button_SaveFile_Click(object sender, EventArgs e)
        {
            if (IsDesignMode || ItemsCount == 0) return;

            using var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            var selectedPath = dlg.SelectedPath;

            var title = GetTitle(Show_Index);
            var description = GetDescription(Show_Index);

            var folder = Path.Combine(selectedPath, title);
            Directory.CreateDirectory(folder);

            File.WriteAllText(Path.Combine(folder, $"{title}_Info.txt"),
                $"Title: {title}{Environment.NewLine}{Environment.NewLine}Description:{Environment.NewLine}{description}",
                Encoding.UTF8);



            var imagesFolder = Path.Combine(folder, "Images");
            Directory.CreateDirectory(imagesFolder);

            string CoreBaseDir = Path.GetFullPath(
            Path.Combine(
                Path.GetDirectoryName(typeof(Database).Assembly.Location)!,
                @"..\..\..\..\Peripatos.Core"
            ));

            string sourceImagesDir = Path.Combine(CoreBaseDir, "Data", "Beach", "Images", GetTitle(Show_Index));


            if (Directory.Exists(sourceImagesDir))
            {
                foreach (var srcPath in Directory.EnumerateFiles(sourceImagesDir, "*", SearchOption.AllDirectories))
                {
                    string relative = Path.GetRelativePath(sourceImagesDir, srcPath);
                    string dstPath = Path.Combine(imagesFolder, relative);

                    Directory.CreateDirectory(Path.GetDirectoryName(dstPath)!);
                    File.Copy(srcPath, dstPath, overwrite: true);
                }
            }
        }

        protected void Add_DropdownList_Items()
        {
            Dropdown_Select_List.Items.Clear();
            foreach (var title in GetAllTitles())
                Dropdown_Select_List.Items.Add(title);
        }

        private void Dropdown_Select_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
            Show_Index = Dropdown_Select_List.SelectedIndex;
            Check_if_Buttons_Enabled();
            Render_new_Beach_Data();
        }

        private void TextBox_PlaceTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Slideshow_Click(object sender, EventArgs e)
        {
            if (SildeshowTimer.Enabled)
            {
                SildeshowTimer.Stop();
            }
            else
            {
                SildeshowTimer.Start();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.SpeakAsyncCancelAll();
            }
            synthesizer.Dispose();
            base.OnFormClosing(e);
        }
    }
}
