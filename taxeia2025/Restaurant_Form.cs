using Peripatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Restaurant_Form : Beaches_Form
    {

        protected override int ItemsCount => AppList_Manager.List_Restaurants.Count;
        protected override string GetTitle(int i) => AppList_Manager.List_Restaurants[i].Title;
        protected override string GetDescription(int i) => AppList_Manager.List_Restaurants[i].Description;
        protected override List<byte[]> GetImages(int i) => AppList_Manager.List_Restaurants[i].Images;
        protected override IEnumerable<string> GetAllTitles() => AppList_Manager.List_Restaurants.Select(s => s.Title);

        public Restaurant_Form()
        {
            InitializeComponent();
        }

        public Restaurant_Form(SessionContext session) : base(session)
        {
            InitializeComponent();
        }

        private void Sights_Form_Load(object sender, EventArgs e)
        {
            StartCurrentBeachSlideShow();
            Check_if_Buttons_Enabled();
            ModifyStartStopVoiceButtons();
            Add_DropdownList_Items();
            Render_new_Beach_Data();

            ApplyGuestRestrictions();
        }

        protected override void button_SaveFile_Click(object sender, EventArgs e)
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
            
            string sourceImagesDir = Path.Combine(CoreBaseDir, "Data", "Restaurant", "Images", GetTitle(Show_Index));


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


    }

}
