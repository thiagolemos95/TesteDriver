using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TesteDriver
{
    /// <summary>
    /// Criando um TB de veiculo com seus atributos
    /// </summary>
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Criando uma lista de veiculos para mostrar no grid
        /// </summary>
        public List<Veiculo> Veiculos { get; set; }

        public MainPage()
        {
            InitializeComponent();
            
            //Iniciando/preenchendo a lista de veiculos
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "Azera V6"  , Preco = 600000   },
                new Veiculo { Nome = "Fiesta 2.0", Preco = 50000    },
                new Veiculo { Nome = "HB20 S"    , Preco = 40000    }
            };

            this.BindingContext = this;
        }
    }
}
