using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();


        }

        async void NovaPagina(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };


            var detalhe = new NOVAPAGINA();
            detalhe.BindingContext = contato;
            await Navigation.PushAsync(detalhe);

        }

    }
  }
