using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SrezProj.Pages;

namespace SrezProj
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new AutorizPage());
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
