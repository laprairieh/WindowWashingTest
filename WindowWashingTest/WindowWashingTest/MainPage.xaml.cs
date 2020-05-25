using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WindowWashingTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            Logo.Source = ImageSource.FromResource("WindowWashingTest.Assets.Images.LogoBurned.png", assembly);
        }
       
        private void LogInButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogIn());
        }

        private void RegisterAcct_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registration());
        }

    }
}
