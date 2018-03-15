using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class Main1Page : ContentPage
    {
        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var Show = e.SelectedItem as NavigationMenu;
            await Navigation.PushAsync(new HomePage(Show));
            listView.SelectedItem = null;
        }


        public Main1Page()
        {
            InitializeComponent();




           

            listView.ItemsSource = new List<NavigationMenu>{

                new NavigationMenu { Name = "Home", ImageUrl = "/Users/ironman/Projects/MasterDetail/MasterDetail/Properties/home.png" },
                new NavigationMenu { Name = "FAQ", ImageUrl = "/Users/ironman/Projects/MasterDetail/MasterDetail/Properties/FAQ.png" },
                new NavigationMenu { Name = "ContactUS", ImageUrl = "/Users/ironman/Projects/MasterDetail/MasterDetail/Properties/phone.png"} 

            };
        }
    }
}
