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

namespace My_Fitness_Doctor.Views
{
    #region | BMIAbout Class |
   
    public partial class BMIAbout : PhoneApplicationPage
    {
        #region | Constructor |
        
        public BMIAbout()
        {
            InitializeComponent();
        }

        #endregion

        #region | Event Handlers |
       
        private void close_Click(object sender, EventArgs e)
      
        {
            this.NavigationService.Navigate(new Uri("/Views/BMICalculator.xaml", UriKind.Relative));
        }
        
        #endregion
    }
 
    #endregion
}