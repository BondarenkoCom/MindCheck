using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using System;

namespace MindCheck.Views
{
    public partial class VideoAdPopupPage : Popup
    {
        public VideoAdPopupPage()
        {
            InitializeComponent();
            Console.WriteLine("VideoAdPopupPage initialized");
        }

        private async void OnCloseButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Close button clicked");
            await CloseAsync();
        }
    }
}
