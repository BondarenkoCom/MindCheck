using MindCheck.Models;
using MindCheck.ViewModels;
using Microsoft.Maui.Controls;
using System;

namespace MindCheck.Views
{
    public partial class NewSurveyPage : ContentPage
    {
        private SurveyViewModel _viewModel;

        public NewSurveyPage(TestCardModel test)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent(); // Ensure this method is defined in the corresponding XAML file
            Console.WriteLine("NewSurveyPage constructor started.");

            _viewModel = new SurveyViewModel(test.id);
            BindingContext = _viewModel;

            Device.BeginInvokeOnMainThread(async () =>
            {
                Console.WriteLine("BeginInvokeOnMainThread started.");
                await _viewModel.InitializeAsync(test.id);
                Console.WriteLine("InitializeAsync completed.");
            });

            Console.WriteLine("NewSurveyPage constructor completed.");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
