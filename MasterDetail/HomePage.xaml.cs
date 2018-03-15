using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class HomePage : ContentPage
    {
        void Handle_ClickedApply(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ApplyProgram());
        }

        void Chekc_ClickedApply(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CheckStatus());
        }

        public HomePage()
        {
            
            InitializeComponent();
        }


    }
}
