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
    #region | CalorieCounterItemsList |

    public partial class CalorieCounterItemsList : PhoneApplicationPage
    {

        #region | Constructor |

        public CalorieCounterItemsList()
        {
            InitializeComponent();
         
            this.Loaded += new RoutedEventHandler(CalorieCounterItemsList_Loaded);
        }

        #endregion

        #region | Methods |

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                string value = null;

                if (NavigationContext.QueryString.TryGetValue("ItemId", out value))
                {
                    int index = int.Parse(value);

                    //Make sure the data is loaded for main view model (this is to ensure we get proper item when coming from Pinned Tile)
                    if (!App.ViewModel.IsDataLoaded)
                    {
                        App.ViewModel.LoadData();
                    }

                    ItemViewModel item = App.ViewModel.GetItem(index);

                    if (item != null)
                    {

                        TextBlockSelectedItemTitle.Text = item.mainitems;

                        ImageSourceConverter imgS = new ImageSourceConverter();
                        ImageSelectedItem.Source = (ImageSource)imgS.ConvertFromString(item.ItemImage);

                        if (!App.SubviewModel.IsDataLoaded)
                        {
                            App.SubviewModel.LoadData();
                        }

                        foreach (SubItemViewModel subItem in App.SubviewModel.SubItems)
                        {

                            subItem.MyColor = item.Color;

                        }

                        SubItemsListBox.ItemsSource = from SubItems in App.SubviewModel.SubItems
                                                      where SubItems.ItemId1 == index
                                                      select SubItems;
                    }


                }
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        protected static Color GetColorFromHexString(string s)
        {
            // remove artifacts     
            s = s.Trim().TrimStart('#');
            // only 8 (with alpha channel) or 6 symbols are allowed     
            if (s.Length != 8 && s.Length != 6)
                throw new ArgumentException("Unknown string format!");
            int startParseIndex = 0;
            bool alphaChannelExists = s.Length == 8;
            // check if alpha canal exists                
            // read alpha channel value    
            byte a = 255;
            if (alphaChannelExists)
            {
                a = System.Convert.ToByte(s.Substring(0, 2), 16);
                startParseIndex += 2;
            }
            // read r value  
            byte r = System.Convert.ToByte(s.Substring(startParseIndex, 2), 16);
            startParseIndex += 2;
            // read g value   
            byte g = System.Convert.ToByte(s.Substring(startParseIndex, 2), 16);
            startParseIndex += 2;
            // read b value    
            byte b = System.Convert.ToByte(s.Substring(startParseIndex, 2), 16);
            return Color.FromArgb(a, r, g, b);
        }
               
        private void CalorieCounterItemsList_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

    

    #endregion
     
        #region | Event Handler |

        private void SubItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (SubItemsListBox.SelectedIndex == -1)
                return;

            SubItemViewModel detailsItem = (SubItemViewModel)SubItemsListBox.SelectedItem;

            NavigationService.Navigate(new Uri(string.Format("/Views/CalorieCounterItemDetails.xaml?Calories={0}&Cholestrol={1}&TotalFat={2}&Sodium={3}&TotalCarbs={4}&Protein={5}&Calcium={6}&Potassium={7}&SubItemName={8}&ServingSize={9}",
            detailsItem.Calories, detailsItem.Cholestrol, detailsItem.TotalFat, detailsItem.Sodium,
            detailsItem.TotalCarbs, detailsItem.Protein, detailsItem.Calcium, detailsItem.Potassium, detailsItem.SubItemName, detailsItem.ServingSize), UriKind.Relative));

            SubItemsListBox.SelectedIndex = -1;
        }

        #endregion

    }

    #endregion
}

