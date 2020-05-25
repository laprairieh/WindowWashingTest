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
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();

            var assembly = typeof(LogIn);

            Logo.Source = ImageSource.FromResource("WindowWashingTest.Assets.Images.LogoBurned.png", assembly);
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            
            var user = (await App.client.GetTable<Users>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();
            if (user != null)
        

            
            {
                if (user.Passcode == passwordEntry.Text)
                {
                    Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
                    App.Current.Properties["UserDetail"] = JsonConvert.SerializeObject(user);
                    App.user = user;
                    await buildPropList();
                    await Navigation.PushAsync(new Homepage());              
                }
                else 
                {
                    DisplayAlert("Error", "This password was not recognized", "OK");
                }
                
            }
            else
            {
                DisplayAlert("Error", "This username was not recognized", "OK");
            }
            
        }

        private async Task buildPropList()
        {
            var up1 = (await App.client.GetTable<UserProperty>().Where(up => up.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();
            if (up1 != null)
            {
                App.UserProperty1 = up1;
                App.Current.Properties["UserProperty1"] = JsonConvert.SerializeObject(up1);
                var up2 = (await App.client.GetTable<UserProperty>().Where(u => u.Email == emailEntry.Text).ToListAsync()).Skip(1).FirstOrDefault();
                if (up2 != null)
                {
                    App.UserProperty2 = up2;
                    App.Current.Properties["UserProperty2"] = JsonConvert.SerializeObject(up2);
                    var up3 = (await App.client.GetTable<UserProperty>().Where(u => u.Email == emailEntry.Text).ToListAsync()).Skip(2).FirstOrDefault();
                    if (up3 != null)
                    {
                        App.UserProperty3 = up3;
                        App.Current.Properties["UserProperty3"] = JsonConvert.SerializeObject(up3);
                        var up4 = (await App.client.GetTable<UserProperty>().Where(u => u.Email == emailEntry.Text).ToListAsync()).Skip(3).FirstOrDefault();
                        if (up4 != null)
                        {
                            App.UserProperty4 = up1;
                            App.Current.Properties["UserProperty4"] = JsonConvert.SerializeObject(up4);
                            var up5 = (await App.client.GetTable<UserProperty>().Where(u => u.Email == emailEntry.Text).ToListAsync()).Skip(4).FirstOrDefault();
                            if (up5 != null)
                            {
                                App.UserProperty1 = up5;
                                App.Current.Properties["UserProperty5"] = JsonConvert.SerializeObject(up5);
                            }
                        }
                    }
                }
            }
        }
    } 
}