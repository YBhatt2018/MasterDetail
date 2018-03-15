using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class CheckStatus : ContentPage
    {
        public CheckStatus()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_OEN(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OENPage());
        }

        async void Handle_Clicked_REF(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new REFPage());
        }

        async void Handle_Clicked_NEXT(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OfferPage());
        }



    }
}
