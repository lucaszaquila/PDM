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
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent ();
		}
        
        async void ParaEstiloPadrao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloPadrao());
        }
        async void ParaEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloDinamico());
        }
        async void ParaTrigger(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TriggersView());
        }
        async void ParaListViewSimples(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewSimples());
        }
        async void ParaHome(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new Home());
         }
        
    }
}