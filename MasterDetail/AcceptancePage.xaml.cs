using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class AcceptancePage : ContentPage
    {
        public AcceptancePage()
        {
            InitializeComponent();
        }
        async void Handle_Clicked_Email(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeEmail());
        }

        async void Handle_Clicked_Exit(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void Handle_Clicked_accept(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Confirmation_Accept() );
        }
    }
    }

