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
            if (SearchedFolder.Text != string.Empty)
                dialog.SelectedPath = SearchedFolder.Text;

            var dialogResult = dialog.ShowDialog();

            if (dialogResult == WinForms.DialogResult.OK)
                SearchedFolder.Text = dialog.SelectedPath;
        }
    }
}