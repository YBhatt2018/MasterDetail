using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class ApplicationPage : ContentPage
    {
        async void Handle_Clicked_back(object sender, System.EventArgs e)
        {
            var Home = await DisplayAlert("confirm", "Are you sure you DO NOT want to FINISH this application and END", "ok", "cancel");
            if (Home == true)
            {
                await Navigation.PopToRootAsync();
            }
            else
            {
                return;
            }
        }

        public ApplicationPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_address(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new StreetAddress());
        }

        async void Handle_Clicked_submit(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmationPage());
        }
    }
}
