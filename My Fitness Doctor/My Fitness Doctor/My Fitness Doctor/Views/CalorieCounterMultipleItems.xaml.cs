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

namespace My_Fitness_Doctor.Views
{
    #region| CalorieCounter MultipleItems Class | 
   
    public partial class CalorieCounterMultipleItems : PhoneApplicationPage
    {
        #region | variables |

        string variable;
        string variable1;
        string variable2;
        string variable3;
        string variable4;
        string variable5;
        string variable6;
        string variable7;

        #endregion

        #region| Constructor |

        public CalorieCounterMultipleItems()
        {
            
            InitializeComponent();
            InputQuantity.IsReadOnly = true;
            InputQuantity.Text = "0";
            sodium.Text = "0";
            totalfat.Text = "0";
            Calories.Text = "0";
            cholestrol.Text = "0";
            totalcarbohydrates.Text = "0";
            protein.Text = "0";
            calcium.Text = "0";
            potassium.Text = "0";
        }

        #endregion

        #region | Methods |

        void calulate(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            try
            {
                Double value = Convert.ToDouble(a);
                int quantity = Int32.Parse(InputQuantity.Text);
                Double product = value * quantity;

                Calories.Text = product.ToString();


                Double value1 = Convert.ToDouble(b);
                int quantity1 = Int32.Parse(InputQuantity.Text);
                Double product1 = value1 * quantity;
                totalfat.Text = product1.ToString();


                Double value2 = Convert.ToDouble(c);
                int quantity2 = Int32.Parse(InputQuantity.Text);
                Double product2 = value2 * quantity;
                cholestrol.Text = product2.ToString();

                Double value3 = Convert.ToDouble(d);
                int quantity3 = Int32.Parse(InputQuantity.Text);
                Double product3 = value3 * quantity;
                sodium.Text = product3.ToString();

                Double value4 = Convert.ToDouble(e);
                int quantity4 = Int32.Parse(InputQuantity.Text);
                Double product4 = value4 * quantity;
                totalcarbohydrates.Text = product4.ToString();

                Double value5 = Convert.ToDouble(f);
                int quantity5 = Int32.Parse(InputQuantity.Text);
                Double product5 = value5 * quantity;
                protein.Text = product5.ToString();

                Double value6 = Convert.ToDouble(g);
                int quantity6 = Int32.Parse(InputQuantity.Text);
                Double product6 = value6 * quantity;
                calcium.Text = product6.ToString();

                Double value7 = Convert.ToDouble(h);
                int quantity7 = Int32.Parse(InputQuantity.Text);
                Double product7 = value7 * quantity;
                potassium.Text = product7.ToString();

            }
            catch (Exception ex)
            {
                //Do Nothing
                ex.Message.ToString();
            }

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {

                base.OnNavigatedTo(e);

                NavigationContext.QueryString.TryGetValue("Calories", out variable);



                NavigationContext.QueryString.TryGetValue("Sodium", out variable3);



                NavigationContext.QueryString.TryGetValue("TotalCarbs", out variable4);



                NavigationContext.QueryString.TryGetValue("Protein", out variable5);



                NavigationContext.QueryString.TryGetValue("Calcium", out variable6);



                NavigationContext.QueryString.TryGetValue("Potassium", out variable7);



                NavigationContext.QueryString.TryGetValue("TotalFat", out variable1);



                NavigationContext.QueryString.TryGetValue("Cholestrol", out variable2);

            }

            catch (Exception ex)
            { 
            //do nothing
            }

            //string value = null;

            //if (NavigationContext.QueryString.TryGetValue("SubItemName", out value))
            //{
            //    ServingSize.Text = value;
            //}


            //string value1 = null;
           
            //if (NavigationContext.QueryString.TryGetValue("ServingSize", out value1)) ;
           
            //{
            //    SubItemNamee.Text = value1;
            //}

        }
                
        #endregion

        #region | Event Handlers |

        private void StackPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int quantity = Int32.Parse(InputQuantity.Text);
            if (quantity < 0)
            {
                MessageBox.Show("Invalid input.", "Alert", MessageBoxButton.OK);
            }
            else
            {
                calulate(variable, variable1, variable2, variable3, variable4, variable5, variable6, variable7);
            }
           
        }

        private void quantity_inc_Click(object sender, RoutedEventArgs e)
        {
            double quantity = string.IsNullOrEmpty(InputQuantity.Text) ? 1 : double.Parse(InputQuantity.Text);

            double quantity1 = ++quantity;
            InputQuantity.Text = (string.Format("{0}", quantity1));
        }

        private void quantity_dec_Click(object sender, RoutedEventArgs e)
        {
            double quantity = string.IsNullOrEmpty(InputQuantity.Text) ? 1 : double.Parse(InputQuantity.Text);

            double quantity1 = quantity - 1;
            InputQuantity.Text = (string.Format("{0}", quantity1));
        }


        #endregion      
    }
  
    #endregion
}

   
