using MindCheck.ViewModels;
using Microsoft.Maui.Controls;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
using CommunityToolkit.Maui.Views;

namespace MindCheck.Views
{
    public partial class NewFinalResultsPage : ContentPage
    {
        public NewFinalResultsPage(string resultText)
        {
            InitializeComponent();
            BindingContext = new FinalResultsViewModel(resultText);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("NewFinalResultsPage appearing");
            await ShowVideoAdPopup();
        }

        private async Task ShowVideoAdPopup()
        {
            try
            {
                Debug.WriteLine("Attempting to show video ad popup");
                var videoAdPage = new VideoAdPopupPage();
                await this.ShowPopupAsync(videoAdPage);
                Debug.WriteLine("Video ad popup shown successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to show video ad popup: {ex.Message}");
            }
        }
    }
}
