using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDriver.Models;
using TesteDriver.ViewsModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDriver.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo _veiculo)
        {
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(_veiculo);
            this.BindingContext = this.ViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
               string.Format(
@"
Veiculo: {0}
Nome: {1}
Fone: {2}
E-Mail: {3}
Data Agendamento: {4}
Hora Agendamento: {5}",
                        ViewModel.Agendamento.Veiculo.Nome,
                        ViewModel.Agendamento.Nome,
                        ViewModel.Agendamento.Fone,
                        ViewModel.Agendamento.Email,
                        ViewModel.Agendamento.DataAgendamento.ToString("dd/MM/yyyy"),
                        ViewModel.Agendamento.HoraAgendamento)
                , "OK");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento", (msg) =>
                {
                    DisplayAlert("Agendamento",
                    string.Format(
                    @"
 Veiculo: {0}
 Nome: {1}
 Fone: {2}
 E-Mail: {3}
 Data Agendamento: {4}
 Hora Agendamento: {5}",
                                ViewModel.Agendamento.Veiculo.Nome,
                                ViewModel.Agendamento.Nome,
                                ViewModel.Agendamento.Fone,
                                ViewModel.Agendamento.Email,
                                ViewModel.Agendamento.DataAgendamento.ToString("dd/MM/yyyy"),
                                ViewModel.Agendamento.HoraAgendamento)
                                , "OK"
                                );
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
        }
    }
}
