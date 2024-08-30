using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MindCheck.Views
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);

            await Navigation.PushAsync(new NewTestSelectionPage());
        }
    }
}
