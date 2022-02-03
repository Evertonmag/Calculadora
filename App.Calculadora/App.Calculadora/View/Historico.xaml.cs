using App.Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Calculadora.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Historico : ContentPage
    {
        App PropriedadesApp;

        public Historico()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            lst_lista_historico.ItemsSource = PropriedadesApp.ArrayHistory;
        }

        private async void RemoverItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                MenuItem i = sender as MenuItem;

                History Historico_selecionado = (History)i.BindingContext;

                bool confirm = await DisplayAlert("Tem certeza?", "Remover do Histórico?", "Sim", "Não");

                if (confirm)
                {
                    PropriedadesApp.ArrayHistory.RemoveAll(item => (item.Result == Historico_selecionado.Result));

                    lst_lista_historico.ItemsSource = new List<History>();
                    lst_lista_historico.ItemsSource = PropriedadesApp.ArrayHistory;
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}