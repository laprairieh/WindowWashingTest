using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWashingTest.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindowWashingTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Confirmation : ContentPage
    {
        Booking thisBooking;
        public Confirmation(Booking booking)
        {
            thisBooking = booking;
            InitializeComponent();
            nameAndAddy.Text = "   Location: " + thisBooking.property.PropertyName + ", " + thisBooking.property.Address;
            services.Text = "   Job type: " + thisBooking.jobType;
            date.Text = "   Date: " + thisBooking.dateTime;

        }

        private async void confirm_Clicked(object sender, EventArgs e)
        {
            jobBooked job = new jobBooked();

            job.PropertyName = thisBooking.property.PropertyName;
            job.Email = thisBooking.client.Email;
            job.ThisAddress = thisBooking.property.Address;
            job.PostalCode = thisBooking.property.PostalCode;
            job.PropertyOwner = thisBooking.client.FirstName + thisBooking.client.LastName;
            job.Services = thisBooking.jobType;
            job.ServiceDate = thisBooking.dateTime;
            job.PrimaryResident = thisBooking.property.PrimaryResident;

            await App.client.GetTable<jobBooked>().InsertAsync(job);


            await Navigation.PushAsync(new Homepage());     
               }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

       
    }
}