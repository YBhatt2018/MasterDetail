using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class Confirmation_Accept : ContentPage
    {
        public Confirmation_Accept()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_exit(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
