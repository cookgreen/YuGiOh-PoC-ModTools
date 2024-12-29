﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Net;
using YuGiOh_PoC_Patcher.YuGi;
using System.Runtime.Serialization.Json;
using FileDialogExtenders;
using CustomControls;
using jSkin;
using System.Globalization;
namespace YuGiOh_PoC_Patcher
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            base.SetVisibleCore(false);

            WebClient w = new WebClient(); //TODO: Shorter Timeout Range
            w.Headers.Add("user-agent", "Mozilla/5.0 (Yu-Gi-Oh Updater; Linux; rv:1.0) Gecko/20160408 Yu-Gi-Oh-Client/" + Version.actualVerison);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Force TLS 1.2 on old .NET 4.5
            Version_JSON actualVersion;

            try
            {
                string json_data = w.DownloadString(Version.urlversion);
                actualVersion = JSONSerializer<Version_JSON>.DeSerialize(json_data);
            }
            catch(WebException ex) // Timeout, Server dead, TLS 1.3 is forced (in 2030's?)...
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                actualVersion = new Version_JSON();
                actualVersion.newestVersion = 0;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxButtons buttons_ok = MessageBoxButtons.OK;
            DialogResult result;
            string caption = "Yu-Gi-Oh Updater";

            if (actualVersion.newestVersion > Version.actualVerison)
            {
                string message = " New update is available! - Version: " + actualVersion.newestVersion.ToString(CultureInfo.InvariantCulture) + "\n\n Do you want to downtload it? \n\n---Server Message---\n\n" + actualVersion.message;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Hack over cmd for non-elevated EXE (UAC) to Launch a URL with default webbrowser
                    //Process.Start("cmd", "/C start \"\" \"" + actualVersion.url + "\"");
                    System.Diagnostics.Process.Start(actualVersion.url);
                    Application.Exit();
                }

            }

            //Check if registry for yugi exists
            RegistryKey checkSettings = Registry.CurrentUser.OpenSubKey("SOFTWARE\\YuGiOhModLauncher\\v1\\", true);
            
            //Create Default Registry Values when it dosent Exist
            if (checkSettings == null)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

                key.CreateSubKey("YuGiOhModLauncher");
                key = key.OpenSubKey("YuGiOhModLauncher", true);

                key.CreateSubKey("v1");
                key = key.OpenSubKey("v1", true);

                //Hardcoded Default Values
                key.SetValue("60 FPS Mode", "True");
                key.SetValue("Disable Sound", "False");
                key.SetValue("Easy", "False");
                key.SetValue("FPS Counter", "False");
                key.SetValue("Full Screen (16-Bit)", "False");
                key.SetValue("Full Screen (24-Bit)", "False");
                key.SetValue("Full Screen (32-Bit)", "False");
                key.SetValue("Hard", "True");
                key.SetValue("Window Mode", "True");
                key.SetValue("Language", "English");

                try //TODO : TEST...
                {
                    key.SetValue("GamePath", (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\KONAMI\\Yu-Gi-Oh! Power Of Chaos\\system\\", "InstallDirJ", -1));
                }
                catch (Exception)
                {
                    key.SetValue("GamePath", "NaN");
                }

                OperatingSystem OS = Environment.OSVersion;
                if ((OS.Platform == PlatformID.Win32NT) && (OS.Version.Major >= 6))
                {
                    key.SetValue("Windows Vista+ Bugfix", "True");
                }else
                {
                    key.SetValue("Windows Vista+ Bugfix", "False");
                }

                //string serialized = JsonConvert.SerializeObject(YuGiOh_Version.versionJSON);
                //key.SetValue("DefaultSkip", "true");
            }
            base.SetVisibleCore(true);
            base.Text += Version.actualVerison.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void Button_ModLauncher_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Coming one day, i swear! ¯\_(ツ)_/¯");
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.ShowDialog();
        }

        private void Button_Game_Click(object sender, EventArgs e)
        {
            YuGi.Launcher.YuGiGameInit.startYuGi();
        }

        private void Button_ChangePath_Click(object sender, EventArgs e)
        {
            YuGiExtendedMethods.SetDefaultGamePath();
        }

        private void Button_BaseSettings_Click(object sender, EventArgs e)
        {
            BasicSettings BasicSettings = new BasicSettings();
            BasicSettings.ShowDialog();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://derplayer.neocities.org");
        }
    }

    public static class JSONSerializer<TType> where TType : class
    {
        /// <summary>
        /// Deserializes an object from JSON with 100% .net libary (system.runtime.serialization.json)
        /// </summary>
        public static TType DeSerialize(string json)
        {
            using (var stream = new MemoryStream(Encoding.Default.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(typeof(TType));
                return serializer.ReadObject(stream) as TType;
            }
        }
    }
}
