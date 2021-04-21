﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MADWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e)
        {
            var rootData = await WeatherClassProxy.GetWeather(43.161663, -77.62053);

            if (rootData != null)
            {
                CityTextBlock.Text = rootData.Name.ToString();
                WeatherTextBlock.Text = Convert.ToInt16(rootData.Main.Temp).ToString() + "°";
                WeatherDescriptionTextBlock.Text = rootData.Weather[0].Main.ToString();
               // WeatherImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/13d.png", UriKind.RelativeOrAbsolute));
                WeatherImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + rootData.Weather[0].Icon + ".png", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
