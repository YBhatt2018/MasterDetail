using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class OfferPage : ContentPage 
    {
        //var first_name;
        public OfferPage()
        {
            
            InitializeComponent();

        }
        async void Handle_Clicked_Placement(object sender, System.EventArgs e)
        {
            //var contact = new OfferPage
            //{

            //      first_name = fname.Text,
            //    //last_name = lname.Text,
            //    //oen = Convert.ToInt32(oen.Text),
            //    //dob = dob.Text

            //};

            //var secondPage = new PlacementPage();
            //secondPage.BindingContext = contact;
            await Navigation.PushAsync(new PlacementPage());

        }


        async void Handle_Clicked_Email(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeEmail());
        }

        async void Handle_Clicked_Exit(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}
