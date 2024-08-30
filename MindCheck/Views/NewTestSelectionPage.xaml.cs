using MindCheck.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; // Add this namespace for Preferences
using System;
using System.Linq;

namespace MindCheck.Views
{
    public partial class NewTestSelectionPage : ContentPage
    {
        private NewTestSelectionViewModel _viewModel;

        public NewTestSelectionPage()
        {
            InitializeComponent();

            _viewModel = new NewTestSelectionViewModel();
            _viewModel.Navigation = Navigation;
            BindingContext = _viewModel;
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new TestsPage("null"));
            return true;
        }

        private async void OnItemTapped(object sender, SelectionChangedEventArgs e)
        {
            var selectedTestType = e.CurrentSelection.FirstOrDefault() as TestType;

            if (selectedTestType != null)
            {
                await Navigation.PushAsync(new TestsPage(selectedTestType.Name));

                ((CollectionView)sender).SelectedItem = null;

                // Using Preferences to store the selected test name
                Preferences.Set("selectedTestName", selectedTestType.Name);

                System.Diagnostics.Debug.WriteLine($"Selected Test Name: {selectedTestType.Name}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("OnItemTapped was triggered but no valid TestType was selected.");
            }
        }
    }
}
