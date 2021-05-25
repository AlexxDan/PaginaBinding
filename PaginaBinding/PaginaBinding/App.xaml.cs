using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginaBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new Views.ListNumeroColoresView();
            MainPage = new MenuPrincipal();
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
