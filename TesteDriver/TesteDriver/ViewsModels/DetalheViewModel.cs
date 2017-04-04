using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TesteDriver.Models;
using Xamarin.Forms;

namespace TesteDriver.ViewsModels
{
    public class DetalheViewModel : INotifyPropertyChanged
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
        public string ValorTotal
        {
            get
            {
                return veiculo.PrecoTotalFormatado;
            }
        }

        public bool TemFreioABS
        {
            get
            {
                return veiculo.TemFreioABS;
            }
            set
            {
                veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemArCondicionado
        {
            get
            {
                return veiculo.TemArCondicionado;
            }
            set
            {
                veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemMp3Player
        {
            get
            {
                return veiculo.TemMp3Player;
            }
            set
            {
                veiculo.TemMp3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }



        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public DetalheViewModel(Veiculo _veiculo)
        {
            this.veiculo = _veiculo;
            ProximoComando = new Command(() =>
            {
                MessagingCenter.Send(veiculo, "Proximo");

            });
        }

        public ICommand ProximoComando { get; set; }

    }
}
