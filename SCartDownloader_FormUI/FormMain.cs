using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SCartDownloader_FormUI.Helpers;

namespace SCartDownloader_FormUI
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();

            this.Icon = Properties.Resources._1;

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
        }

        // **************************************************************************
        private readonly Regex regex = new Regex(@"^(?<track>https:\/\/soundcloud.com\/(?:(?!sets|stats|groups|upload|you|mobile|stream|messages|discover|notifications|terms-of-use|people|pages|jobs|settings|logout|charts|imprint|popular)(?:[a-z0-9\-_]{1,25}))\/(?:(?:(?!sets|playlist|stats|settings|logout|notifications|you|messages)(?:[a-z0-9\-_]{1,100}))(?:\/s\-[a-zA-Z0-9\-_]{1,10})?))(?:[a-z0-9\-\?=\/]*)$");

        //private static ConfigurationFileMap fileMap = new ConfigurationFileMap($"{Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf(@"\"))}\\Settings.config"); //Path to your config file
        //private static Configuration configuration { get; set; } = ConfigurationManager.OpenMappedMachineConfiguration(fileMap);


        /* Elave etdiyim config fayl default adda(App.Config) olmayanda hec cure qebul eletdire bilmedim proqrama. */
        // Get the application configuration file.
       private static Configuration config =   ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        // Get the conectionStrings section.
        private static AppSettingsSection appSettings = config.AppSettings;

      //Save the configuration
      //config.Save(ConfigurationSaveMode.Modified);

      //Refresh the Section
        // ConfigurationManager.RefreshSection("connectionStrings");
        // **************************************************************************

        private async void btnFind_Click(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtMusicUrl.Text))
            {
                string result = await Helper.BuildArtworkUrl(txtMusicUrl.Text);
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
            if (regex.IsMatch(txtMusicUrl.Text)) { Helper.DownloadImage(txtMusicUrl.Text); }
            else
            {
                txtMusicUrl.Clear();
                pbArtwork.Image = Properties.Resources._2;
                txtMusicUrl.WaterMark = "Please enter valid music url. Example: https://soundcloud.com/AUTHOR/SONG";
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* Faylin strukturu '<configuration>'-dan, taki, 'key'(adi dogru yazilmalidir kodda gosterdiyimiz adi ile) ve 'value'-suna(default deyer verilmelidir uygun tip esasinda) qeder dogru yazilmasa NullReferenceException alacayiq.  */

            appSettings.Settings[("cb_GenerateRandomFileName")].Value = cbRandomName.Checked.ToString();
            appSettings.Settings[("cb_SaveToLastSelectedFolder")].Value = cbLastFolder.Checked.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void FormMain_Load(object sender, EventArgs e)
       {
            cbRandomName.Checked = Convert.ToBoolean(appSettings?.Settings["cb_GenerateRandomFileName"]?.Value);
            cbLastFolder.Checked = Convert.ToBoolean(appSettings?.Settings["cb_SaveToLastSelectedFolder"]?.Value);
        }
    }
}