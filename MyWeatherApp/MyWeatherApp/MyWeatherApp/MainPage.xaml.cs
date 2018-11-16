using MyWeatherApp.Models;
using MyWeatherApp.Repository;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWeatherApp
{
    public partial class MainPage : ContentPage
    { 

        IWeatherService weatherService;
    
        public MainPage()
        {
            InitializeComponent();
            if (weatherService == null)
                weatherService = new WeatherService();
        }

        

        public Task<GetCurrentWeatherResult> GetCurrentWeatherAsync(string cityName)
        {
            throw new NotImplementedException();
        }

        public Task<GetForecastWeatherResult> GetFiveDayForecastAsync(string cityName)
        {
            throw new NotImplementedException();
        }

        public WeatherCondition GetWeatherCondition(WeatherConditionType type)
        {
            throw new NotImplementedException();
        }

        private async void GetWeather_Clicked(object sender, EventArgs e)
        {
            var weather = await weatherService.GetCurrentWeatherAsync(cityname.Text);
           // await DisplayAlert("MyWeatherApp", "looking up weather for: " + cityname.Text, "Ok");
           if (weather == null)
            {
                await DisplayAlert("MyWeatherApp", "Could not get Weather, please", "OK");
            }
        }
    }
}
