using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private const int freio_abs = 800;
        private const int ar_condicionado = 1000;
        private const int mp3_player = 500;

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", freio_abs);
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", ar_condicionado);
            }
        }
        public string TextoMp3Player
        {
            get
            {
                return string.Format("Mp3 Player - R$ {0}", mp3_player);
            }
        }

        bool temFreioABS;
        public bool TemFreioABS
        {
            get
            {
                return temFreioABS;
            }
            set
            {
                temFreioABS = value;

                //if (temFreioABS)
                //    DisplayAlert("Freio ABS", "Ligado!", "OK");
                //else
                //    DisplayAlert("Freio ABS", "Desligado!", "OK");

                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;

                //if (temFreioABS)
                //    DisplayAlert("Freio ABS", "Ligado!", "OK");
                //else
                //    DisplayAlert("Freio ABS", "Desligado!", "OK");

                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temMp3Player;
        public bool TemMp3Player
        {
            get
            {
                return temMp3Player;
            }
            set
            {
                temMp3Player = value;

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
                return string.Format("Valor Total: R$ {0}",
                                    veiculo.Preco
                                    + (TemFreioABS ? freio_abs : 0)
                                    + (TemArCondicionado ? ar_condicionado : 0)
                                    + (TemMp3Player ? mp3_player : 0)
                                    );
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
