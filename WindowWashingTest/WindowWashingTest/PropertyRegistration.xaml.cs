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
    public partial class PropertyRegistration : ContentPage
    {
        public PropertyRegistration()
        {

            InitializeComponent();
        }


        private async void RegProp_Clicked(object sender, EventArgs e)
        {
            string PS;
            string owner;
            string primaryResident;
            string propertyName = PropertyName.Text;

            bool isAddress = !string.IsNullOrEmpty(Address.Text);
            bool isPostalCode = IsPostalCode(postalCode.Text);
            bool hasOwner;


            owner = App.user.FirstName + App.user.LastName;
            primaryResident = null;
            if (ImResident.IsChecked)
            {
                hasOwner = true;
                primaryResident = owner;

            }
            else
            {
                if (!string.IsNullOrEmpty(otherResident.Text))
                {
                    hasOwner = true;
                    primaryResident = otherResident.Text;
                }
                else
                {
                    hasOwner = false;

                }
            }

            bool IsPostalCode(string p)
            {
                if (string.IsNullOrEmpty(p))
                {
                    return false;
                }

                try
                {
                    if (p.Length == 6)
                    {
                        PS = p;
                        return true;
                    }
                    if (p.Length == 7)
                    {
                        string str = p.Substring(0, 3);
                        string str2 = p.Substring(p.Length - 3);
                        PS = str + " " + str2;
                        return true;
                    }
                    else { return false; }



                }
                catch (FormatException)
                {
                    return false;
                }
                return false;
            }

            //this isn't checking all condition TODO
            if (isAddress)
            {
                if (isPostalCode)
                {
                    if (hasOwner)
                    {

                        UserProperty userProperty = new UserProperty();
                        {
                            userProperty.UserID = App.user.Id;
                            userProperty.PropertyName = propertyName;
                            userProperty.Email = App.user.Email;
                            userProperty.PostalCode = postalCode.Text;
                            userProperty.Owner = owner;
                            userProperty.PrimaryResident = primaryResident;
                        }

                        await App.client.GetTable<UserProperty>().InsertAsync(userProperty);
                        AddNewProperty(userProperty);
                        //     App.properties.Add(userProperty);
                        //     App.Current.Properties["UserPropertyDetail"] = JsonConvert.SerializeObject(App.properties);
                        Navigation.PushAsync(new Homepage());
                    }
                    else
                    {
                        DisplayAlert("Error", "Please enter primary resident", "OK");
                    }

                }
                else
                {
                    DisplayAlert("Error", "Please enter a valid postal code", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Please enter an address", "OK");
            }

            async void AddNewProperty(UserProperty up)
            {
                if (App.UserProperty1 == null)
                {
                    App.UserProperty1 = up;
                    App.Current.Properties["UserProperty1"] = JsonConvert.SerializeObject(up);
                    await App.client.GetTable<UserProperty>().InsertAsync(up);
                }
                else
                {
                    if (App.UserProperty2 == null)
                    {
                        App.UserProperty2 = up;
                        App.Current.Properties["UserProperty2"] = JsonConvert.SerializeObject(up);
                        await App.client.GetTable<UserProperty>().InsertAsync(up);
                    }
                    else
                    {
                        if (App.UserProperty3 == null)
                        {
                            App.UserProperty3 = up;
                            App.Current.Properties["UserProperty3"] = JsonConvert.SerializeObject(up);
                            await App.client.GetTable<UserProperty>().InsertAsync(up);
                        }
                        else
                        {
                            if (App.UserProperty4 == null)
                            {
                                App.UserProperty4 = up;
                                App.Current.Properties["UserProperty4"] = JsonConvert.SerializeObject(up);
                                await App.client.GetTable<UserProperty>().InsertAsync(up);
                            }
                            else
                            {
                                if (App.UserProperty5 == null)
                                {
                                    App.UserProperty5 = up;
                                    App.Current.Properties["UserProperty5"] = JsonConvert.SerializeObject(up);
                                    await App.client.GetTable<UserProperty>().InsertAsync(up);
                                }
                                else
                                {
                                    DisplayAlert("Error", "No more than 5 properties can be registered on the app at this time", "OK");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}