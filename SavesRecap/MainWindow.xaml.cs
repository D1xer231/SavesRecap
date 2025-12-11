using SavesRecap.Services;
using SavesRecap.ViewModels;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SavesRecap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void ShowPath_Click(object sender, RoutedEventArgs e)
        {
            string roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string erPath = System.IO.Path.Combine(roaming, "EldenRing");

            if (Directory.Exists(erPath))
            {
                foreach (var dir in Directory.GetDirectories(erPath))
                {
                    // Внутри должен быть файл сейва
                    var saves = Directory.GetFiles(dir, "*.sl2");

                    if (saves.Length > 0)
                    {
                        Console.WriteLine("Найден сейв:");
                        MessageBox.Show(saves[0]);                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Folder EldenRing not found.");
            }
        }

        private void BackUpSave_Click(object sender, RoutedEventArgs e)
        {
            InfoTexblock.Text = "Creating file";
            string savePath = SavesFinder.PathFinder();
            InfoTexblock.Text = savePath ?? "Could not find Elden Ring save";
            SavesFinder.SaveFinder(savePath);
            InfoTexblock.Text = "File created and saved at folder on mainscreen";
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
    }
}