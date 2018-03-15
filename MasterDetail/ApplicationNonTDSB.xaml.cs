using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class ApplicationNonTDSB : ContentPage
    {
        public ApplicationNonTDSB()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_Back(object sender, System.EventArgs e)
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

        async void Handle_Clicked_Submit(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PrintNonTDSB());
        }

        async void Handle_Clicked_Address(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new StreetAddress());
        }
    }
}
