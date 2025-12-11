using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SavesRecap.ViewModels
{
    partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        private void AboutApp()
        {
            string aboutText = "Saves Recap\n" +
                               "Version: 1.0\n";
            string descriptionText = "Its a simple app used to make sure your backup are safe.\n" +
                                     "App needed to update Elden Ring saves in case damaging and lost.";
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(aboutText + "\n" + descriptionText + "\n\n" + dateTime);
        }
        [RelayCommand]
        private void UrlOpenning(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                try
                {
                    string currentDir = Directory.GetCurrentDirectory();
                    string path = Path.Combine(currentDir, url);
                    path = Path.GetFullPath(path);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true
                    });
                }
                catch
                {
                    MessageBox.Show($"Unable to open the link or file.\n\nError while {url} opening");
                }
            }
        }
    }
}
