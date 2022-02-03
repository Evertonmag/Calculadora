using App.Calculadora.Model;
using App.Calculadora.View;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Calculadora
{
    public partial class App : Application
    {
        public List<History> ArrayHistory = new List<History>();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Calc()) { BarBackgroundColor = Color.Black };
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
