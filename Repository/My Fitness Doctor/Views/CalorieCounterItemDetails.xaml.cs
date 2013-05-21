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
using System.Windows.Navigation;
using My_Fitness_Doctor.ViewModels;

namespace My_Fitness_Doctor.Views
{ 

    #region | CalorieCounterItemDetails Class |
    
    public partial class CalorieCounterItemDetails : PhoneApplicationPage
    {
        SubItemViewModel detailsItem = new SubItemViewModel();

        #region| Constructor |

        public CalorieCounterItemDetails()
        {
            InitializeComponent();
           
            this.DataContext = detailsItem;
        }

        #endregion

        #region | Methods |

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {

                string value = null;

                if (NavigationContext.QueryString.TryGetValue("Calories", out value))
                {
                    detailsItem.Calories = value;
                }

                if (NavigationContext.QueryString.TryGetValue("Sodium", out value))
                {
                    detailsItem.Sodium = value;
                }

                if (NavigationContext.QueryString.TryGetValue("TotalCarbs", out value))
                {
                    detailsItem.TotalCarbs = value;
                }

                if (NavigationContext.QueryString.TryGetValue("Protein", out value))
                {
                    detailsItem.Protein = value;
                }


                if (NavigationContext.QueryString.TryGetValue("Calcium", out value))
                {
                    detailsItem.Calcium = value;
                }

                if (NavigationContext.QueryString.TryGetValue("Potassium", out value))
                {
                    detailsItem.Potassium = value;
                }


                if (NavigationContext.QueryString.TryGetValue("TotalFat", out value))
                {
                    detailsItem.TotalFat = value;
                }


                if (NavigationContext.QueryString.TryGetValue("Cholestrol", out value))
                {
                    detailsItem.Cholestrol = value;
                }

                if (NavigationContext.QueryString.TryGetValue("SubItemName", out value))
                {

                    detailsItem.SubItemName = value;

                }
                if (NavigationContext.QueryString.TryGetValue("ServingSize", out value))
                {

                    detailsItem.ServingSize = value;

                }

            }

            catch (Exception ex)
            {
                //Do Nothing
            }

        }

        #endregion

        #region | Event Handlers |

        private void CalorieCounter_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/Views/CalorieCounterMultipleItems.xaml?Calories={0}&Cholestrol={1}&TotalFat={2}&Sodium={3}&TotalCarbs={4}&Protein={5}&Calcium={6}&Potassium={7}&SubItemName={8}&ServingSize={9}",
            detailsItem.Calories, detailsItem.Cholestrol, detailsItem.TotalFat, detailsItem.Sodium,
            detailsItem.TotalCarbs, detailsItem.Protein, detailsItem.Calcium, detailsItem.Potassium, detailsItem.SubItemName, detailsItem.ServingSize), UriKind.Relative));

        }

        #endregion
    }
    
      #endregion
}