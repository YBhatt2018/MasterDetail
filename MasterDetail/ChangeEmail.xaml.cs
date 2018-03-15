using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class ChangeEmail : ContentPage
    {
        async void Handle_Clicked_save(object sender, System.EventArgs e)
        {
            var sEmail = await DisplayAlert("confrim","Are you sure you want to save address here","ok","cancel");
            if (sEmail == true)
            {
               
                hello.Text = "Your E-mail Address is Saved Successfully";


            }
            else{
                return;
            }
        }

        public ChangeEmail()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_cancel(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
