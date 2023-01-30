using System;
using IniParser;
using System.IO;
using IniParser.Model;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
using SCartDownloader_FormUI.Helpers;

namespace SCartDownloader_FormUI
{
    public partial class FormMain : MetroForm
    {
        #region Vars
        // Verilen soundcloud musiqi linkinin dogrulugunu yoxlayir:
        private readonly Regex regex = new Regex(@"^(?<track>https:\/\/soundcloud.com\/(?:(?!sets|stats|groups|upload|you|mobile|stream|messages|discover|notifications|terms-of-use|people|pages|jobs|settings|logout|charts|imprint|popular)(?:[a-z0-9\-_]{1,25}))\/(?:(?:(?!sets|playlist|stats|settings|logout|notifications|you|messages)(?:[a-z0-9\-_]{1,100}))(?:\/s\-[a-zA-Z0-9\-_]{1,10})?))(?:[a-z0-9\-\?=\/]*)$");

        // Hazirki assembly-nin pathini saxlayir:
        private static readonly string ApplicationPath = Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf("\\")) + "\\";

        // 'ini' fayla yazma/oxuma emeliyyatlarini tetbiq edir:
        private static FileIniDataParser ConfigurationManager { get; set; } = new FileIniDataParser();

        // Konfiqurasiya faylindan oxudugumuz datalari saxlayir:
        private static IniData ConfigurationFileContent { get; set; }

        // Konfiqurasiyanin hara yerlewdiyini saxlayir:
        private static string ConfigurationFilePath { get; } = ApplicationPath + "SoundcloudArtworkDownloader.ini";
        #endregion Vars

        public FormMain()
        {
            InitializeComponent();

            #region Create configuration file if not exists
            if (!File.Exists(ConfigurationFilePath)) { File.Create(ConfigurationFilePath); }
            else { ConfigurationFileContent = ConfigurationManager.ReadFile(ConfigurationFilePath); }
            #endregion Create configuration file if not exists

            #region Settings of Form Controls
            lblVersion.Text = $"v{Application.ProductVersion}";

            pbArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            pbArtwork.Image = Properties.Resources._2;

            cbOlculer.Items.AddRange(new object[]
            {
                "Originally uploaded image",
                "500x500",
                "300x300",
                "100x100",
                "67x67",
                "47x47",
                "32x32",
                "20x20",
                "16x16"
            });
            cbOlculer.SelectedIndex = 0;

            txtMusicUrl.TabIndex = 0;
            cbOlculer.TabIndex = 1;
            btnFind.TabIndex = 2;
            btnSave.TabIndex = 3;
            cbRandomName.TabIndex = 4;
            cbLastFolder.TabIndex = 5;
            #endregion Settings of Form Controls
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtMusicUrl.Text))
            {
                string result = await ImageHelper.BuildArtworkUrl(txtMusicUrl.Text);
                if (result != null) { pbArtwork.ImageLocation = result; }
                else { pbArtwork.Image = Properties.Resources._2; }
            }
            else
            {
                txtMusicUrl.Clear();
                pbArtwork.Image = Properties.Resources._2;
                txtMusicUrl.WaterMark = "Please enter valid music url. Example: https://soundcloud.com/AUTHOR/SONG";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtMusicUrl.Text)) { ImageHelper.DownloadImage(txtMusicUrl.Text); }
            else
            {
                txtMusicUrl.Clear();
                pbArtwork.Image = Properties.Resources._2;
                txtMusicUrl.WaterMark = "Please enter valid music url. Example: https://soundcloud.com/AUTHOR/SONG";
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigurationFileContent["Settings"]["GenerateRandomFileName"] = cbRandomName.Checked.ToString();
            ConfigurationFileContent["Settings"]["SaveToLastSelectedFolder"] = cbLastFolder.Checked.ToString();
            ConfigurationManager.WriteFile(ConfigurationFilePath, ConfigurationFileContent);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(File.Exists(ConfigurationFilePath))
            {
                cbRandomName.Checked = Convert.ToBoolean(ConfigurationFileContent["Settings"]["GenerateRandomFileName"]);
                cbLastFolder.Checked = Convert.ToBoolean(ConfigurationFileContent["Settings"]["SaveToLastSelectedFolder"]);
            }
        }
    }
}