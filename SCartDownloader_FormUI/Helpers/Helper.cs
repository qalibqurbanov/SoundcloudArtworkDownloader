using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument; /* Sinife bilerekden ad qoyuramki, System.Windows.Forms-daki eyni adli sinifle konflikt yaratmasin */

namespace SCartDownloader_FormUI.Helpers
{
    public static class Helper
    {
        private static FormMain FM { get; } = (FormMain)Application.OpenForms["FormMain"];
        private static string resultArtworkUrl { get; set; } = null;
        private static string artworkOriginalUrl { get; set; } = null;
        private static string lastSelectedFolder { get; set; } = null;

        public static async Task<string> BuildArtworkUrl(string MusicURL)
        {
            HtmlWeb htmlDoc = new HtmlWeb();
            HtmlDocument htmlPage = htmlDoc.Load(MusicURL);

            HtmlNode ourNode = htmlPage?.DocumentNode?.SelectSingleNode("//p/img[contains(@itemprop, 'image')]");

            if (ourNode != null)
            {
                artworkOriginalUrl = ourNode.Attributes["src"].Value;

                resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-original.jpg";

                return await Task.FromResult<string>(resultArtworkUrl);
            }
            else
            {
                MessageBox.Show("Image not found.", "SoundCloud Artwork Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return null;
            }
        }

        public static void DownloadImage(string MusicUrl = null)
        {
            if (BuildArtworkUrl(MusicUrl) != null)
            {
                switch (FM.cbOlculer.SelectedIndex)
                {
                    case 0: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-original.jpg"; } break;
                    case 1: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-t500x500.jpg"; } break;
                    case 2: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-t300x300.jpg"; } break; /* -crop */
                    case 3: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-large.jpg";    } break;
                    case 4: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-t67x67.jpg";   } break;
                    case 5: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-badge.jpg";    } break;
                    case 6: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-small.jpg";    } break;
                    case 7: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-tiny.jpg";     } break;
                    case 8: { resultArtworkUrl = artworkOriginalUrl.Substring(0, artworkOriginalUrl.LastIndexOf('-')) + "-mini.jpg";     } break;

                    default: resultArtworkUrl = null; break;
                }

                using (WebClient webClient = new WebClient())
                {
                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); /* Save dialoq acilanda bu path ile acilsin */
                        saveDialog.RestoreDirectory = true; /* Save dialoqu baglayanda son pathi yadda saxla */
                        saveDialog.Title = "SoundCloud Artwork Downloader"; /* Save dialoqun bawligi */
                        saveDialog.DefaultExt = "jpg"; /* Default fayl extension-i */
                        saveDialog.Filter = "Image file (*.jpg)|*.jpg"; /* Save dialoqda gosterile bilecek fayl tipleri */
                        saveDialog.FilterIndex = 1; /* Default olaraq hansi filter secilmiw olsun */
                        if (FM.cbRandomName.CheckState == CheckState.Checked)
                        {
                            const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                            Random random = new Random();
                            saveDialog.FileName = new string(Enumerable.Repeat(Characters, 20).Select(chars => chars[random.Next(chars.Length)]).ToArray());
                        }
                        else { saveDialog.FileName = ""; }

                        if(FM.cbLastFolder.CheckState==CheckState.Checked && lastSelectedFolder != null)
                        {
                            webClient.DownloadFileAsync(new Uri(resultArtworkUrl), lastSelectedFolder + saveDialog.FileName + ".jpg");
                        }
                        else
                        {
                            if (saveDialog.ShowDialog() == DialogResult.OK)
                            {
                                webClient.DownloadFileAsync(new Uri(resultArtworkUrl), saveDialog.FileName);

                                lastSelectedFolder = Path.GetFullPath(saveDialog.FileName).Remove(Path.GetFullPath(saveDialog.FileName).ToString().LastIndexOf(@"\")) + @"\";
                            }
                        }
                    }
                }
            }

            resultArtworkUrl = null;
        }
    }
}