using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using WindowWashingTest.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections;

namespace WindowWashingTest
{
    public partial class App : Application
    {
        public static string databaselocation = string.Empty;
        public static MobileServiceClient client = new MobileServiceClient("https://earlybirldapp.azurewebsites.net");
        

        public static Users user = new Users();
        public static UserProperty UserProperty1 = new UserProperty();
        public static UserProperty UserProperty2 = new UserProperty();
        public static UserProperty UserProperty3 = new UserProperty();
        public static UserProperty UserProperty4 = new UserProperty();
        public static UserProperty UserProperty5 = new UserProperty();
        public static UserProperty[] properties = new UserProperty[5] {UserProperty1, UserProperty2, UserProperty3, UserProperty4, UserProperty5 };
        //        public static ArrayList properties = new ArrayList();
        public App()
        {
            InitializeComponent();

            
            bool isLoggedIn = Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Current.Properties["IsLoggedIn"]) : false;
            if (!isLoggedIn)
            {
                //Load if Not Logged In
                MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                Users userData = Current.Properties.ContainsKey("UserDetail") ? JsonConvert.DeserializeObject<Users>(Current.Properti‌​es["UserDetail"].ToString()) : null;
                user = userData;
                UserProperty up1 = Current.Properties.ContainsKey("UserProperty1") ? JsonConvert.DeserializeObject<UserProperty>(Current.Properti‌​es["UserProperty1"].ToString()) : null;
                UserProperty1 = up1;
                UserProperty up2 = Current.Properties.ContainsKey("UserProperty2") ? JsonConvert.DeserializeObject<UserProperty>(Current.Properti‌​es["UserProperty2"].ToString()) : null;
                UserProperty2 = up2;
                UserProperty up3 = Current.Properties.ContainsKey("UserProperty3") ? JsonConvert.DeserializeObject<UserProperty>(Current.Properti‌​es["UserProperty3"].ToString()) : null;
                UserProperty3 = up3;
                UserProperty up4 = Current.Properties.ContainsKey("UserProperty4") ? JsonConvert.DeserializeObject<UserProperty>(Current.Properti‌​es["UserProperty4"].ToString()) : null;
                UserProperty4 = up4;
                UserProperty up5 = Current.Properties.ContainsKey("UserProperty5") ? JsonConvert.DeserializeObject<UserProperty>(Current.Properti‌​es["UserProperty5"].ToString()) : null;
                UserProperty5 = up5;

                MainPage = new NavigationPage(new Homepage());
            }


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}