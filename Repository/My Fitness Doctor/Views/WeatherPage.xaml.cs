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

        #region | Page Load Event |
      
        private void WeatherPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }

        }

        #endregion

        #region | Getweather Button |

        private void Getweather_Click_1(object sender, RoutedEventArgs e)
        {
            WeatherTodayAPI.WeatherSoapClient obj1 = new WeatherTodayAPI.WeatherSoapClient();
            // int postalcode = 0;
            //postalcode = zipcode.Text;
            //// API2 function
            //obj1.GetCityForecastByZIPAsync();
            //obj1.GetCityForecastByZIPCompleted += obj1_GetCityForecastByZIPCompleted;
        }

        #endregion
       
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


        #endregion

        #region | Methods |


        // Function of 2nd API
        void obj1_GetCityForecastByZIPCompleted(object sender, WeatherTodayAPI.GetCityForecastByZIPCompletedEventArgs e)
        {

        }

        #endregion
               
    }

    #endregion
}

