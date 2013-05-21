using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace My_Fitness_Doctor.Views
{
    #region | Weather Class|
   
    public partial class WeatherPage : PhoneApplicationPage
    {
        #region | Constructor |
        
        public WeatherPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(WeatherPage_Loaded);
        }

        #endregion

        #region | EventHandler | 

        private void WeatherPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }

            WeatherAPI.Service1SoapClient obj = new WeatherAPI.Service1SoapClient();

            //obj.UTCDateAsync();
            //obj.UTCDateCompleted += obj_UTCDateCompleted;
            obj.DailyrainAsync();
            obj.DailyrainCompleted += obj_DailyrainCompleted;

            obj.AirDensityAsync();
            obj.AirDensityCompleted += obj_AirDensityCompleted;

            obj.HighhumidityAsync();
            obj.HighhumidityCompleted += obj_HighhumidityCompleted;
        }

        void obj_HighhumidityCompleted(object sender, WeatherAPI.HighhumidityCompletedEventArgs e)
        {
            Humidity.Text = e.Result;
        }

        void obj_AirDensityCompleted(object sender, WeatherAPI.AirDensityCompletedEventArgs e)
        {
            AirDensity.Text = e.Result;
        }


        void obj_DailyrainCompleted(object sender, WeatherAPI.DailyrainCompletedEventArgs e)
        {
            RainRate.Text = e.Result;
        }

        #region | Pintile |

        private void Pintile_Click(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "Weather";

                standardTileData.BackTitle = "Weather";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/Weather/WeatherStartTileLogo.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/WeatherPage.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }

        #endregion
        
        //void obj_UTCDateCompleted(object sender, SR1.UTCDateCompletedEventArgs e)
        //{
        //    Report.Text = e.Result;
        //    MessageBox.Show(e.Result);
        //}

        #endregion
    }

    #endregion
}
    
