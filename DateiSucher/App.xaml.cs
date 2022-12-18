using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace DateiSucher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IFileService, FileService>();
            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider();
        }
        
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}