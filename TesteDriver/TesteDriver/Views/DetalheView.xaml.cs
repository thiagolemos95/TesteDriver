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
    public partial class DetalheView : ContentPage
    {
        /// <summary>
        /// Variaveis e constantes 
        /// </summary>
        /// 
        #region Variaveis e constantes 
        public Veiculo veiculo { get; set; }              

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", Veiculo.freio_abs);
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", Veiculo.ar_condicionado);
            }
        }
        public string TextoMp3Player
        {
            get
            {
                return string.Format("Mp3 Player - R$ {0}", Veiculo.mp3_player);
            }
        }

        //bool temFreioABS;
        public bool TemFreioABS
        {
            get
            {
                return veiculo.TemFreioABS;
            }
            set
            {
                veiculo.TemFreioABS = value;

                //if (temFreioABS)
                //    DisplayAlert("Freio ABS", "Ligado!", "OK");
                //else
                //    DisplayAlert("Freio ABS", "Desligado!", "OK");

                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        //bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return veiculo.TemArCondicionado;
            }
            set
            {
                veiculo.TemArCondicionado = value;

                //if (temFreioABS)
                //    DisplayAlert("Freio ABS", "Ligado!", "OK");
                //else
                //    DisplayAlert("Freio ABS", "Desligado!", "OK");

                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        //bool temMp3Player;
        public bool TemMp3Player
        {
            get
            {
                return veiculo.TemMp3Player;
            }
            set
            {
                veiculo.TemMp3Player = value;

                //if (temFreioABS)
                //    DisplayAlert("Freio ABS", "Ligado!", "OK");
                //else
                //    DisplayAlert("Freio ABS", "Desligado!", "OK");

                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return veiculo.PrecoTotalFormatado;
            }
        }

        #endregion

        public DetalheView(Veiculo _veiculo)
        {
            InitializeComponent();
            this.veiculo = _veiculo;
            //this.Title = veiculo.Nome;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.veiculo));
        }
    }
}
