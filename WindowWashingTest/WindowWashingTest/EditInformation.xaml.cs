using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWashingTest.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindowWashingTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditInformation : ContentPage
    {
        public EditInformation()
        {
            firstNameEntry.Text = App.user.FirstName;
            lastNameEntry.Text = App.user.LastName;
            emailEntry.Text = App.user.Email;
            phoneNumberEntry.Text = App.user.PhoneNumber.ToString();
            InitializeComponent();
        }

        private void update_Clicked(object sender, EventArgs e)

        {
           // String thisEmail = App.user.Email;
           // App.user.FirstName = firstNameEntry.Text;
          //  App.user.LastName = lastNameEntry.Text;
          //  App.user.Email = emailEntry.Text;
           // App.user.PhoneNumber = long.Parse(firstNameEntry.Text);

           // await App.client.GetTable<Users>().Where(u => u.Email == thisEmail).Update

                 }
         
        private void password_Clicked(object sender, EventArgs e)
        {

        }
    }
}