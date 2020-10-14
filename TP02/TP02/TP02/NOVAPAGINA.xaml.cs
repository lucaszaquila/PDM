using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Model;
using TP02.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NOVAPAGINA : ContentPage
    {
        public NOVAPAGINA()
        {
            InitializeComponent();          
        }


        async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}