using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstiloDinamico : ContentPage
	{
        public EstiloDinamico()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);

            InitializeComponent();
        }

        private void btnAlterar_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Color randomColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            labelClock.TextColor = randomColor;
        }

        public async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        bool OnTimerTick()
        {
            labelClock.Text = DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss");
            return true;
        }
    }
}
