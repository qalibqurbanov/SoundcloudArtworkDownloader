using System;
using System.Threading;
using System.Windows.Forms;

namespace SCartDownloader_FormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Mutex-e ad vermek onu computer-wide edir, burada unikal ad vermeliyik:*/
            using (Mutex mutex = new Mutex(false, "SoundCloud Artwork Downloader"))
            {
                /* 2 saniye gozle, eger proqramin bawqa bir instance-i artiq baglanmaq erefesindedirse: */
                if (!mutex.WaitOne(TimeSpan.FromSeconds(1), false))
                {
                    MessageBox.Show("Another instance of this application is already running. Application will now close.", "SoundCloud Artwork Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
