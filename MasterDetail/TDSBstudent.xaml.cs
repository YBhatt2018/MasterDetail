using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class TDSBstudent : ContentPage
    {
        public TDSBstudent()
        {
            InitializeComponent();
        }

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

        async void Handle_Clicked_next (object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ApplicationPage());
        }
    }
}
