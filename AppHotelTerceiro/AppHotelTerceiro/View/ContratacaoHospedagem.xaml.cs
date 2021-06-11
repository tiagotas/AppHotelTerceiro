using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppHotelTerceiro.Model;

namespace AppHotelTerceiro.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_suites.ItemsSource = PropriedadesApp.Suites;


            /**
             * Definindo as configurações iniciais de Datas
             */
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(6);

            dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
            dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6).AddDays(1);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                /*Hospedagem dados_hospedagem = new Hospedagem()
                {
                    Quarto = (Suite)pck_suites.SelectedItem,
                    DataCheckIn = dtpck_checkin.Date,
                    DataCheckOut = dtpck_checkout.Date
                };*/


                Navigation.PushAsync(new HospedagemCalculada()
                {
                    BindingContext = new Hospedagem()
                    {
                        Quarto = (Suite)pck_suites.SelectedItem,
                        DataCheckIn = dtpck_checkin.Date,
                        DataCheckOut = dtpck_checkout.Date
                    }
                });


            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }

        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;

            dtpck_checkout.MinimumDate = elemento.Date.AddDays(1);
            dtpck_checkout.MaximumDate = elemento.Date.AddMonths(6);
        }
    }
}