using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class PlacementPage : ContentPage
    {
        

        public PlacementPage()
        {

            //test.Text = offer.first_name;




            InitializeComponent();


           

            }

      


        async void Handle_Clicked_Next(object sender, System.EventArgs e)
        {
            var xyz = picker_accept.SelectedItem.ToString();

            if (xyz == "Proceed with this placement")
            {
                await Navigation.PushAsync(new AcceptancePage());
            }
            else{
                await Navigation.PushAsync(new CancellationPage());
            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
           
        }






    }
}
