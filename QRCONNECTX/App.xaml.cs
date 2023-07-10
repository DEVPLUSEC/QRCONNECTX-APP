using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRCONNECTX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new paginas.inicio_sesion());
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
