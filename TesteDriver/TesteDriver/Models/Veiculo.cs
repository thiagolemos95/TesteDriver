using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDriver.Models
{
    /// <summary>
    /// Criando um TB de veiculo com seus atributos
    /// </summary>
    public class Veiculo
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }
        public const int freio_abs = 800;

        public const int ar_condicionado = 1000;

        public const int mp3_player = 500;

        public bool TemFreioABS { get; set; }

        public bool TemArCondicionado { get; set; }

        public bool TemMp3Player { get; set; }


        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: R$ {0}",
                                    Preco
                                    + (TemFreioABS ? freio_abs : 0)
                                    + (TemArCondicionado ? ar_condicionado : 0)
                                    + (TemMp3Player ? mp3_player : 0)
                                    );
            }
        }
    }
}
