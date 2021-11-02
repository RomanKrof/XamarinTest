using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace XamarinTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("The application has started.");
            DateTime dt;
            dt = DateTime.Now;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("The application is asleep.");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("The application resumes.");
        }
    }
}
