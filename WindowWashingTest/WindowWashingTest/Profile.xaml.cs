using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindowWashingTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
           

            InitializeComponent();

            firstNameField.Text = "First Name: " + App.user.FirstName;
            lastNameField.Text = "Last Name: " + App.user.LastName;
            emailField.Text = "Email: " + App.user.Email;
            phoneNumberField.Text = "Phone Number: " + App.user.PhoneNumber;

        }

        private void logout_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["IsLoggedIn"] = Boolean.FalseString;
            Navigation.PushAsync(new MainPage());
        }

        private void myProp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProperties());
        }

        private void edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditInformation());
        }
    }
}