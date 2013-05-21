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
    #region | HealthTips Class|
  
    public partial class HealthTips : PhoneApplicationPage
    {
        #region | Constructor |
        
        public HealthTips()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(HealthTips_Loaded);
        }

        #endregion 

        #region | Property |

        private void HealthTips_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        #endregion

        #region | EventHandler |

        #region | PinTile |

        private void Pin_Click(object sender, EventArgs e)
        {

            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "HealthTips";

                standardTileData.BackTitle = "HealthTips";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/HealthTips/HealthTipsStartTileIcon.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/HealthTips.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }
        
        #endregion

        #endregion
    }
    
    #endregion
}