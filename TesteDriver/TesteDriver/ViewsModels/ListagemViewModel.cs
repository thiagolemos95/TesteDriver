using System;
using System.Collections.Generic;
using System.Text;
using TesteDriver.Models;

namespace TesteDriver.ViewsModels
{
    public class ListagemViewModel
    {
        /// <summary>
        /// Criando uma lista de veiculos para mostrar no grid
        /// </summary>
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
