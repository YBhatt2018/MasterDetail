using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class ConfirmationNonTDSB : ContentPage
    {
        public ConfirmationNonTDSB()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_Modify(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Handle_Clicked_Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ApplicationNonTDSB());
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
    }
}
