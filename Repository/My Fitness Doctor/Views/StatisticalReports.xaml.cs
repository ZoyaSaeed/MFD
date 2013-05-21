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
    #region | StatiticalReports Class |
   
    public partial class StatisticalReports : PhoneApplicationPage
    {
        #region | Constructor |
       
        public StatisticalReports()
        {
            InitializeComponent();
        }

        #endregion

        #region|App Bar Event Handlers|

        #region | PinTile |
        
        private void Pin_Click(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "Statistical Reports";

                standardTileData.BackTitle = "Statistical Reports";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/StatisticalReports/stats.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/StatisticalReports.xaml", UriKind.Relative), standardTileData);

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