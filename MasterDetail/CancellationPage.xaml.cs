using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class CancellationPage : ContentPage
    {
        public CancellationPage()
        {
            InitializeComponent();
        }

         void Handle_Clicked_Cancel(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ReasonPage());
        }
    }
}
