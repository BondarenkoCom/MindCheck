using MindCheck.Views;

namespace MindCheck
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Используем SplashPage при старте приложения
            MainPage = new NavigationPage(new SplashPage());
        }
    }
} 
