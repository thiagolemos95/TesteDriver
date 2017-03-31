using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDriver.Models
{
    public class ListagemVeiculos
    {
        /// <summary>
        /// Criando uma lista de veiculos para mostrar no grid
        /// </summary>
        public List<Veiculo> Veiculos { get; set; }

        public ListagemVeiculos()
        {
            //Iniciando/preenchendo a lista de veiculos
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "Azera V6"  , Preco = 60000    },
                new Veiculo { Nome = "Fiesta 2.0", Preco = 50000    },
                new Veiculo { Nome = "HB20 S"    , Preco = 40000    }
            };
        }
    }
}
