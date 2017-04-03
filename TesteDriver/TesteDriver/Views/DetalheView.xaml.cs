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
    public partial class DetalheView : ContentPage
    {
        public Veiculo veiculo { get; set; }

        public DetalheView(Veiculo _veiculo)
        {
            InitializeComponent();
            this.veiculo = _veiculo;
            this.BindingContext = new DetalheViewModel(_veiculo);
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.veiculo));
        }
    }
}
