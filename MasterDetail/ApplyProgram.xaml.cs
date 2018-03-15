using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class ApplyProgram : ContentPage
    {
        public ApplyProgram()
        {
            InitializeComponent();
        }

         async void Handle_Clicked_TDSB(object sender, System.EventArgs e)
        {
            var TDSB = await DisplayAlert("confirm", "Are you sure you want to selct a TDSB student", "ok", "cancel");
            if (TDSB == true){
                await Navigation.PushAsync(new TDSBstudent());
            }
            else {
                return;
            }
        }


        async void Handle_Clicked_NOT(object sender, System.EventArgs e)
        {
            var NTDSB = await DisplayAlert("confirm", "Are you sure you want to selct a TDSB student", "ok", "cancel");
            if (NTDSB == true)
            {
                await Navigation.PushAsync(new NotTDSB());
            }
            else
            {
                return;
            }

        }

         void Handle_Clicked(object sender, System.EventArgs e)
        {
            var info = DisplayAlert("TDSB Student", "is a student currently attending a school at the Toronto District School Board (TDSB) and has an existing OEN (Ontario Education Number)","Ok","cancel");
        }

        void Handle_Clickedi(object sender, System.EventArgs e)
        {
            var inform = DisplayAlert("Not a TDSB Student", "is a student NOT currently attending a school at the Toronto District School Board (TDSB)", "Ok", "cancel");
        }
    }
}
