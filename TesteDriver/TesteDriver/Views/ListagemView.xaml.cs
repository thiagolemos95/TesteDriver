using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDriver.Models;
using Xamarin.Forms;

namespace TesteDriver.Views
{
    public partial class ListagemView : ContentPage
    {
        /// <summary>
        /// Criando uma lista de veiculos para mostrar no grid
        /// </summary>
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new ListagemVeiculos().Veiculos;

            this.BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            //DisplayAlert("TesteDriver", string.Format("Você tocou no modelo {0} que custa {1}", veiculo.Nome, veiculo.PrecoFormatado),"OK");

            Navigation.PushAsync(new DetalheView(veiculo));

        }
    }
}
