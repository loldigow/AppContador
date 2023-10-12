
using AppFinanceiro.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFinanceiro
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new ContPage();
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
