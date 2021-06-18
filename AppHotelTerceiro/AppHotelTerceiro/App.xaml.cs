using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppHotelTerceiro.View;
using AppHotelTerceiro.Model;

using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace AppHotelTerceiro
{
    public partial class App : Application
    {

        public List<Suite> Suites = new List<Suite>()
        {
            new Suite()
            {
                Descricao = "Super Luxo",
                ValorDiariaAdulto = 95.5,
                ValorDiariaCrianca = 45.5
            },
            new Suite()
            {
                Descricao = "Luxo",
                ValorDiariaAdulto = 80,
                ValorDiariaCrianca = 40
            },
            new Suite()
            {
                Descricao = "Pobre Premium (classe média)",
                ValorDiariaAdulto = 70.5,
                ValorDiariaCrianca = 35.5
            }
        };


        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            MainPage = new NavigationPage(new ContratacaoHospedagem());
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
