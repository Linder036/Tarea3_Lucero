using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_Lucero
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Habilitar navegacion entre ventanas
            MainPage = new NavigationPage (new Login());
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
