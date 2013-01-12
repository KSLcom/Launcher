using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

namespace Launcher
{
    /// <summary>
    /// Methods for Accessing Windows API
    /// </summary>
    public class WinApi
    {
        [DllImport("kernel32.dll")]
        private static extern bool Beep(int Frequenz, int Dauer);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint hMsg, int wParam, int lParam);
        private const int HWND_BROADCAST = 0xFFFF;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MONITORPOWER = 0xF170;
        private const int MONITOR_ON = -1;
        private const int MONITOR_OFF = 2;
        private const int MONITOR_STANBY = 1;

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int waveOutSetVolume(IntPtr uDeviceID, uint dwVolume);

        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;

        public WinApi()
        {


        }

        /// <summary>
        /// Make a system beep
        /// </summary>
        /// <param name="f">Frequency of the beep</param>
        /// <param name="dur">Duration of the beep</param>
        public void Beeping(int f, int dur)
        {
            Beep(f, dur);
        }

        /// <summary>
        /// Take a screen shot and save it to folder
        /// </summary>
        /// <param name="state">-1 for activate, 2 for set to powersave</param>
        public void ScreenShot(string folder)
        {
            ScreenShot(folder, "0");
        }

        /// <summary>
        /// Take a screen shot and save it to folder with group
        /// </summary>
        /// <param name="folder">Path for saving screen shot PNG</param>
        /// <param name="group">Group name if multiple computers save a screenshot</param>
        public void ScreenShot(string folder, string group)
        {
            string path = "";
            DateTime d = DateTime.Now;
            string strDate = d.ToString("yyyyMMddHHmmss");
            if (group.Length == 0)
            {
                group = "0";
            }
            if (folder.Length == 0)
            {
                path = @"c:\home\" + SystemInformation.ComputerName.ToString() + "-" + group + "-" + strDate + ".png";
            }
            else
            {
                if (folder.LastIndexOf(@"\") == folder.Length - 1)
                {
                    path = folder + SystemInformation.ComputerName.ToString() + "-" + group + "-" + strDate + ".png";
                }
                else
                {
                    path = folder + @"\" + SystemInformation.ComputerName.ToString() + "-" + group + "-" + strDate + ".png";
                }
            }

            try
            {
                // Set the bitmap object to the size of the screen
                bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);

                // Create a graphics object from the bitmap
                gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                // Take the screenshot from the upper left corner to the right bottom corner
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                // Save the screenshot to the specified path that the user has chosen
                bmpScreenshot.Save(path, ImageFormat.Png);
            }
            catch
            {
                // Just swallow errors
            }
        }

        /// <summary>
        /// Sets System Volume
        /// </summary>
        /// <param name="volume">Volume from 0-100</param>
        public void SetVolume(int volume)
        {
            // Calculate the volume that's being set
            int NewVolume = ((ushort.MaxValue / 10) * volume);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        /// <summary>
        /// Turns Monitor/Screen form powersave mode to active
        /// </summary>
        /// <param name="state">-1 for activate, 2 for set to powersave</param>
        public void ScreenState(int state)
        {
            //  http://fci-h.blogspot.com/2007/03/turn-off-your-monitor-via-code-c.html
            //  1 - the display is going to low power.
            //  2 - the display is being shut off.
            // –1 - the display is being turned on (undocumented value).
            SendMessage((IntPtr)HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, state);
        }

        /// <summary>
        /// Add Launcher to Windows Startup
        /// </summary>
        public void RunAtStartup()
        {
            bool runAsStartup = false;

            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // Check to see the current state (running at startup or not)
            if (rkApp.GetValue("Launcher") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                runAsStartup = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                runAsStartup = true;
            }

            if (runAsStartup)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("Launcher", Application.ExecutablePath.ToString());
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("Launcher", false);
            }

        }

    }
}
