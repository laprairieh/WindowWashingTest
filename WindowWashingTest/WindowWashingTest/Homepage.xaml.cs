using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWashingTest.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;

namespace WindowWashingTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            
            InitializeComponent();

            //questionable
            NameLabel.Text = "Welcome " + App.user.FirstName;
            if (App.UserProperty1 != null)
            {
                p1.Text = App.UserProperty1.PropertyName;
            }
            if (App.UserProperty2 != null)
            {
                p2.Text = App.UserProperty2.PropertyName;

            }
            if (App.UserProperty3 != null)
            {
                p3.Text = App.UserProperty3.PropertyName;

            }

            var assembly = typeof(Homepage);
           

            Logo.Source = ImageSource.FromResource("WindowWashingTest.Assets.Images.LogoBurned.png", assembly);

        }

        private void BookService_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BookService());
        }

        private void RegisterProp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertyRegistration());
        }

        private void myProp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProperties());
        }

        private void gotoProfile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }
    }
}