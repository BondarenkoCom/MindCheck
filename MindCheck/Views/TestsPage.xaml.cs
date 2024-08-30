using MindCheck.ViewModels;
using Microsoft.Maui.Controls;
using System;
using System.Diagnostics;
using System.Linq;

namespace MindCheck.Views
{
    public partial class TestsPage : ContentPage
    {
        private TestsPageViewModel _viewModel;

        public TestsPage(string categoryName)
        {
            Console.WriteLine($"TestsPage constructor called with category: {categoryName}");
            InitializeComponent();
            InitializeViewModelAsync(categoryName);
        }

        private async void InitializeViewModelAsync(string categoryName)
        {
            Console.WriteLine("Initializing TestsPage ViewModel...");
            _viewModel = new TestsPageViewModel(categoryName);
            BindingContext = _viewModel;

            await _viewModel.InitializeDataAsync();
            Console.WriteLine("TestsPage ViewModel initialized.");
        }

        private void ListView_OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                var selectedItem = e.CurrentSelection.FirstOrDefault();
                Console.WriteLine($"Item selected: {selectedItem}");
                _viewModel.ItemTappedCommand.Execute(selectedItem);
                ((CollectionView)sender).SelectedItem = null;
            }
            else
            {
                Console.WriteLine("Item selection cleared.");
            }
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
