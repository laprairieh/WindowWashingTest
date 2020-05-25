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
    public partial class BookService : ContentPage
    {

        public BookService()
        {
            InitializeComponent();

            if (App.UserProperty1 != null)
            {
                P1SL.IsVisible = true;
                P1Label.Text = App.UserProperty1.PropertyName + ", ";
                P1Addy.Text = App.UserProperty1.Address;
            }
            if (App.UserProperty2 != null)
            {
                P2SL.IsVisible = true;
                P2Label.Text = App.UserProperty2.PropertyName + ", ";
                P2Addy.Text = App.UserProperty1.Address;
            }
            if (App.UserProperty3 != null)
            {
                P3SL.IsVisible = true;
                P3Label.Text = App.UserProperty3.PropertyName + ", ";
                P3Addy.Text = App.UserProperty1.Address;
            }
            if (App.UserProperty4 != null)
            {
                P4SL.IsVisible = true;
                P4Label.Text = App.UserProperty4.PropertyName + ", ";
                P4Addy.Text = App.UserProperty1.Address;
            }
            if (App.UserProperty5 != null)
            {
                P5SL.IsVisible = true;
                P5Label.Text = App.UserProperty5.PropertyName + ", ";
                P5Addy.Text = App.UserProperty1.Address;
            }
            if (App.UserProperty1 == null & App.UserProperty2 == null & App.UserProperty3 == null & App.UserProperty4 == null & App.UserProperty5 == null)
            {
                DisplayAlert("Error", "You must register a property to book a service", "OK");
                Navigation.PushAsync(new Homepage());
            }
        }

        private UserProperty whichProperty()
        {
            if (P1.IsChecked ^ P2.IsChecked ^ P3.IsChecked ^ P4.IsChecked ^ P5.IsChecked)
            {
                if (P1.IsChecked)
                {
                    return App.UserProperty1;
                }
                if (P2.IsChecked)
                {
                    return App.UserProperty2;
                }
                if (P3.IsChecked)
                {
                    return App.UserProperty3;
                }
                if (P4.IsChecked)
                {
                    return App.UserProperty4;
                }
                if (P5.IsChecked)
                {
                    return App.UserProperty5;
                }
                return null;
            }

            else
                return null;

        }

        private void reqService_Clicked(object sender, EventArgs e)
        {
            //this button would send a message to a company representative
            //And company would reply us through some portal or web/mobile
          //exactly
                //Could we contract you to build this in app functionality as well as a simple web app?
                //Yes! as long as web app is converned, I'm willing to do, since I don't have experience in mobile

                //ok perfect, I'll pay you though fiverr?
                //whatever you prefer, I'm open for any method!
                //Ok, I just paid through Fiverr, thanks again
                //Thank you so much for that. But can you please give me detailed requirements.
                 //I need for web app. Do you have schema and other stuff ready?
                 //It only needs to be very simple, we just need to be able to see all of the contacts of people who are communicating with us
                 //and be able to view their user information (email, property address, phone, postal code and name) as well as send messages back and forth to them.
                 //We need to integrate web app in here?
                 //No the web app would be a different solution, all I would need added to this solution would be the code to send and receive messages
                 //If the solution in differen then will they interact through Http Service or some kind of API?
            //Through the HTTP service, unless you have a better way you think it can be done in whcich case that would work too
            //HTTP Service would work best, will also be used as API.
            //The contacts/users and details are pre added in this solution? 
            //yes, in Model folder. You can assume that there will always be a user and userProperty
            //Okay. Sure. and this method (we are having conversation in) would be used for send/ receive messages?
            //This method is the action/event for the send button, does signalR have some sort of listener for receiving messages? 

            //Because I'd imagine that there would be another method that is triggered when data is received
            //Yes SignalR have a 'Hub' which trigger listeners/clients/connections with the hub. Hub triggers listener in Client Side Code and that code is responsible to live changing in front side view (html/xml).
            //Ok nice, xamarin uses XAML which is very similar to XML, so maybe you can make a method and leave a comment on it so I'll know to refactor it
            //Sure. Thats great. 
            //One last thing. Can you please tell me what should web app / page display, what would be the information there for what purpose messagning took place? 
            //And do web app knows about these Users which are sending messages to web? because both of the apps are different and can't usually share database.

            //Hi, sorry to interpting this conversation. can you please all the mentioned details in Fiverr inbox. I need to leave now. I'll get all the information from there and will start work on that.
            //Is that okay for you?
            //Yep, no worries I'll put it all there.
            //Thanks. have a good day!
            //Hi there!
        }


    }
}