using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDriver.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDriver.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        /// <summary>
        /// Variaveis e constantes 
        /// </summary>
        /// 
        #region Variaveis e constantes

        public Agendamento Agendamento { get; set; }

        public Veiculo Veiculo
        {
            get
            {
                return Agendamento.Veiculo;
            }

            set
            {
                Agendamento.Veiculo = value;
            }
        }

        public string Nome
        {
            get
            {
                return Agendamento.Nome;
            }

            set
            {
                Agendamento.Nome = value;
            }
        }
        public string Fone
        {
            get
            {
                return Agendamento.Fone;
            }

            set
            {
                Agendamento.Fone = value;
            }
        }
        public string Email
        {
            get
            {
                return Agendamento.Email;
            }

            set
            {
                Agendamento.Email = value;
            }
        }

        public DateTime DataAgendamento
        {
            get
            {
                return Agendamento.dataAgendamento;
            }
            set
            {
                Agendamento.dataAgendamento = value;
            }
        }

        public TimeSpan HoraAgendamento
        {
            get
            {
                return Agendamento.HoraAgendamento;
            }
            set
            {
                Agendamento.HoraAgendamento = value;
            }
        }

        #endregion
        public AgendamentoView(Veiculo _veiculo)
        {
            InitializeComponent();
            this.Agendamento = new Agendamento();
            Agendamento.Veiculo = _veiculo;
            //this.Title = veiculo.Nome;

            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
               string.Format(
@"Veiculo: {0}
Nome: {1}
Fone: {2}
E-Mail: {3}
Data Agendamento: {4}
Hora Agendamento: {5}"
                            , Veiculo.Nome, Nome, Fone, Email, DataAgendamento.ToString("dd/MM/yyyy"), HoraAgendamento)
                , "OK");
        }
    }
}
