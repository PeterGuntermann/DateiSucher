using System.IO;
using System.Windows;
using Microsoft.Win32;
using WinForms = System.Windows.Forms;

namespace DateiSucher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Not yet implemented.
            MessageBox.Show("Not yet implemented.");
        }

        private void ChooseFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new WinForms.FolderBrowserDialog();
            dialog.ShowDialog();
            
            // OpenFileDialog openFileDialog = new OpenFileDialog();
            // if(openFileDialog.ShowDialog() == true)
            //     searchedFolder.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
