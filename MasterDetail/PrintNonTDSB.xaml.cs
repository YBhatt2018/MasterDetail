using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class PrintNonTDSB : ContentPage
    {
        public PrintNonTDSB()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_Profile(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NotTDSB());
        }

        async void Handle_Clicked_Exit(object sender, System.EventArgs e)
        {

            await Navigation.PopToRootAsync();

        }
    }
}
