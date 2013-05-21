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
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Threading;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
using My_Fitness_Doctor.Views;
using Microsoft.Phone.Shell;

namespace My_Fitness_Doctor
{
    #region | MainPage Class |
   
    public partial class MainPage : PhoneApplicationPage
    {
                       
        #region | Constructor |

        public MainPage()
        {
            InitializeComponent();
           
        }
       #endregion

        #region | Event Handlers |

        private void TrackerTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/Tracker.xaml", UriKind.Relative));
        }

        private void WhetherTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/WeatherPage.xaml", UriKind.Relative));
        }

        private void BMITile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/BMICalculator.xaml", UriKind.Relative));
        }

        private void HealthTipsTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/HealthTips.xaml", UriKind.Relative));
        }

        private void StopwatchTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/StopWatchPage.xaml", UriKind.Relative));
        }

        private void CalorieCounterTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/CalorieCounter.xaml", UriKind.Relative));
        }

        private void NotesTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/Notes.xaml", UriKind.Relative));
        }

        private void StatisticalReportsTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/StatisticalReports.xaml", UriKind.Relative));
        }


        #region | Pin |

        private void Pin_Click(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "MyFitnessDoctor";

                standardTileData.BackTitle = "MyFitnessDoctor";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/CommonImages/StartTileLogo.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/MainPage.xaml", UriKind.Relative), standardTileData);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }

        }


        #endregion

        #region | About |

        private void About_Click_1(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/AppAbout.xaml", UriKind.Relative));
        }

        #endregion

        #endregion
    }
   
    #endregion
}