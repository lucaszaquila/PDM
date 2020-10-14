using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
            RestService _restService;

            public MainPage()
            {
                InitializeComponent();
                _restService = new RestService();
            }

            async void OnButtonClicked(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(cityEntry.Text))
                {
                    WeatherData weatherData = await _restService.GetWeatherDataAsync(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
                    BindingContext = weatherData;

                    DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    
                    DateTime DTsunrise = time.AddSeconds((double)Sys.Sunrise + weatherData.Timezone);
                    DateTime DTsunset = time.AddSeconds((double)Sys.Sunset + weatherData.Timezone);

                    sunrise.Text = DTsunrise.ToString();
                    sunset.Text = DTsunset.ToString();
                }
            }

            string GenerateRequestUri(string endpoint)
            {
                string requestUri = endpoint;
                requestUri += $"?zip={cityEntry.Text}";
                requestUri += ",us&units=imperial";
                requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
                return requestUri;
            }
    }
}
