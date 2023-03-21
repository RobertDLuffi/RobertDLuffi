using RobertDLuffi.ForDemostration;
using RobertDLuffi.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace RobertDLuffi
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            // MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new PageSQLcon());
            MainPage = new NavigationPage(new MainP());
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
