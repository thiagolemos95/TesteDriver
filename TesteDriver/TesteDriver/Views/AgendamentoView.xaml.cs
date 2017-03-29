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
	public partial class AgendamentoView : ContentPage
	{
        public Veiculo veiculo { get; set; }

        public AgendamentoView (Veiculo _veiculo)
		{
			InitializeComponent ();
            this.veiculo = _veiculo;
            //this.Title = veiculo.Nome;

            this.BindingContext = this;
		}
	}
}
