using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class NotTDSB : ContentPage
    {
        public NotTDSB()
        {
            InitializeComponent();
        }


         void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            city.IsVisible = true;
            cityname.IsVisible = true;
            province.IsVisible = true;
            provincename.IsVisible = true;
            country.IsVisible = true;
            countryname.IsVisible = true;


        }

        async void Handle_ClickedExit(object sender, System.EventArgs e)
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


        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConfirmationNonTDSB());
        }
    }
}
