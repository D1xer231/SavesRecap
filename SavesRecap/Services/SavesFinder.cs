using SavesRecap.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SavesRecap.Services
{
    class SavesFinder
    {
        public static string PathFinder()
        {
            string roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string erPath = Path.Combine(roaming, "EldenRing");

            if (Directory.Exists(erPath))
            {
                foreach (var dir in Directory.GetDirectories(erPath))
                {
                    var saves = Directory.GetFiles(dir, "*.sl2");
                    if (saves.Length > 0)
                    {
                        return saves[0];
                    }
                }
            }
            return null;
        }

        public static void SaveFinder(string sourcePath)
        {
            if (sourcePath == null)
            {
                MessageBox.Show("Elden Ring Save is not found!");
                return;
            }

            byte[] data = File.ReadAllBytes(sourcePath);

            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MyEldenRingBackup");
            Directory.CreateDirectory(folder);

            string fileName = Path.GetFileName(sourcePath);
            string savePath = Path.Combine(folder, fileName);
            File.WriteAllBytes(savePath, data);

            MessageBox.Show("Backup saved!");
        }
    }
}
