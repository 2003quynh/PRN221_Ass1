using HotelManagementSystem.Models;
using HotelManagementSystem.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace HotelManagementSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Navigation navigation;
        private readonly PRN221_HotelManagementSystemContext context = new PRN221_HotelManagementSystemContext();
        public App()
        {
            navigation = new Navigation();
        }
        protected override void OnStartup(StartupEventArgs e)
        {

            navigation.ViewModel = new RoomManagementViewModel(navigation,context);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigation)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}

