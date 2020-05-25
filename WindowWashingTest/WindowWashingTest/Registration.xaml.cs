using Newtonsoft.Json;
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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void createAcct_Clicked(object sender, EventArgs e)
        {
            bool isFirstName = !string.IsNullOrEmpty(firstName.Text);
            bool isLastName = !string.IsNullOrEmpty(lastName.Text);
            bool notNullEmail = !string.IsNullOrEmpty(firstName.Text);
            bool notNullPhone = !string.IsNullOrEmpty(lastName.Text);
            bool notNullPassword = !string.IsNullOrEmpty(firstName.Text);
            bool notNullRetype = !string.IsNullOrEmpty(retypePassword.Text);
            bool notNullAddress = !string.IsNullOrEmpty(addy.Text);

            Users user = new Users();
            UserProperty userProperty = new UserProperty();
            if (isFirstName)
            {
                if (isLastName)
                {
                    if (notNullEmail & user.GoodEmail(email.Text))
                    {
                        if (notNullPhone & user.goodPhoneNumber(phoneNumber.Text))
                        {
                            if (notNullAddress)
                            {
                                if (userProperty.IsPostalCode(pcode.Text))
                                { 
                                    if (notNullPassword & goodPassword(password.Text))
                                    {
                                        if (notNullRetype & goodRetypePassword(password.Text, retypePassword.Text))
                                        {

                                            {
                                                user.Email = email.Text;
                                                user.FirstName = firstName.Text;
                                                user.LastName = lastName.Text;
                                                user.Passcode = password.Text;
                                                user.PhoneNumber = long.Parse(phoneNumber.Text);
                                                user.Prefix = "Mr. ";

                                                userProperty.UserID = user.Id;
                                                userProperty.PropertyName = "My Address";
                                                userProperty.Email = email.Text;
                                                userProperty.Address = addy.Text;
                                                userProperty.PostalCode = pcode.Text;
                                                userProperty.Owner = firstName.Text + lastName.Text;
                                                userProperty.PrimaryResident = userProperty.Owner;
                                            }

                                            await App.client.GetTable<Users>().InsertAsync(user);
                                            Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
                                            App.Current.Properties["UserDetail"] = JsonConvert.SerializeObject(user);
                                            App.user = user;

                                            await App.client.GetTable<UserProperty>().InsertAsync(userProperty);
                                           
                                            App.Current.Properties["UserDetail"] = JsonConvert.SerializeObject(user);
                                            App.Current.Properties["UserProperty1"] = JsonConvert.SerializeObject(userProperty);
                                            App.user = user;
                                            App.UserProperty1 = userProperty;


                                            Navigation.PushAsync(new Homepage());
                                        }
                                        else
                                        {
                                            DisplayAlert("Error", "Passwords must match", "OK");
                                        }
                                    }
                                    else
                                    {
                                    DisplayAlert("Error", "Passwords must be at least 6 characters", "OK");
                                    }
                                }
                                else
                                {
                                    DisplayAlert("Error", "Invalid Postal Code", "OK");
                                }
                            }
                            else
                            {
                                DisplayAlert("Error", "Please enter address", "OK");
                            }
                       
                        }
                        else
                        {
                            DisplayAlert("Error", "Phone number must contain only numbers and have an area code", "OK");
                        }
                    }
                    else
                    {
                        DisplayAlert("Error", "Please enter a valid email", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Last name field cannot be void", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "First name field cannot be void", "OK");
            }
           
            
            
        }
            

            public bool goodEmail(string email)
            //checks if email is valid, must contain @ and .
            {
            try
            {
                return (email.Contains($"@") & email.Contains($"."));
            } 
            catch (ArgumentNullException)
            {
                return false;
            }
            }

            bool goodPhoneNumber(string number)
            //checks if phone nummmber is valid, must be at least 10 characters long
            {

                try
                {
                    long result = long.Parse(number);
                    if (result >= 1000000000)
                    {
                        
                        return true;
                    }
                }
                catch (FormatException)
                {
                    return false;
                }
                return true;
            }

            bool goodPassword(string password) 
            {
                return (password.Length >= 6);
            }

            bool goodRetypePassword(string password, string retype)
            {
                return (password == retype);
            }

        void makeAccount() { 

            
            bool isFirstName = !string.IsNullOrEmpty(firstName.Text);
            bool isLastName = !string.IsNullOrEmpty(lastName.Text);
            bool notNullEmail = !string.IsNullOrEmpty(firstName.Text);
            bool notNullPhone = !string.IsNullOrEmpty(lastName.Text);
            bool notNullPassword = !string.IsNullOrEmpty(firstName.Text);
            bool notNullRetype = !string.IsNullOrEmpty(retypePassword.Text);

 //           bool isEmail = goodEmail(email.Text);
 //           bool isPhoneNumber = goodPhoneNumber(phoneNumber.Text);
 //           bool isPassword = goodPassword(password.Text);
 //           bool isRetypePassword = goodRetypePassword(password.Text, retypePassword.Text);

            if (isFirstName)
            {
                if (isLastName)
                {
                    if (notNullEmail & goodEmail(email.Text))
                    {
                        if (notNullPhone & goodPhoneNumber(phoneNumber.Text))
                        {
                            if (notNullPassword & goodPassword(password.Text))
                            {
                                if (notNullRetype & goodRetypePassword(password.Text, retypePassword.Text))
                                {
                             
                                }
                                else
                                {
                                    DisplayAlert("Error", "Passwords must match", "OK");
  
                                }
                            }
                            else
                            {
                                DisplayAlert("Error", "Passwords must be at least 6 characters", "OK");
                            }
                        }
                        else
                        {
                            DisplayAlert("Error", "Phone number contain only numbers and have an area code", "OK");
                        }
                    }
                    else
                    {
                        DisplayAlert("Error", "Please enter a valid email", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Last name field cannot be void", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "First name field cannot be void", "OK");
            }
        }

    }
}