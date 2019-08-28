using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Beux.Services;
using Beux.Views;

namespace Beux
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            // MainPage = new MainPage();
            Current.MainPage = new LoginPage();
           // MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
       
    }
}
