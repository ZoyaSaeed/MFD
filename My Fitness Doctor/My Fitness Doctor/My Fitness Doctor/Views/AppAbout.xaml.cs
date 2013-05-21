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
using Microsoft.Phone.Tasks;

namespace My_Fitness_Doctor.Views
{
    #region | About Class |
   
    public partial class AppAbout : PhoneApplicationPage
    {
        
        #region | Constructor |
       
        public AppAbout()
        {
            InitializeComponent();
        }

#endregion

        #region | EventHandlers |
       
        private void close_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Review_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void email_Click(object sender, EventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.To = "moatterjamil@hotmail.com";
            emailComposeTask.Subject = "Contact Developer: Diet Planner";
            emailComposeTask.Body = "Contact for a feature request.";
            emailComposeTask.Show();
        }
      
        #endregion

    }
    #endregion

}