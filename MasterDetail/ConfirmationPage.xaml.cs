using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class ConfirmationPage : ContentPage
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_email(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeEmail());
        }

        async void Handle_Clicked_exit(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
