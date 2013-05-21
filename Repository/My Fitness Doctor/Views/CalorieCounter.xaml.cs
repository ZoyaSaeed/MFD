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
using My_Fitness_Doctor.ViewModels;
using System.Windows.Navigation;
using Microsoft.Phone.Shell;

namespace My_Fitness_Doctor.Views
{
    #region | CalorieCounter Class |

    public partial class CalorieCounter : PhoneApplicationPage
    {
        #region | Constructor |

        public CalorieCounter()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(CalorieCounter_Loaded);

        }

        #endregion

        #region | Fields |

        private void MainItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {


                if (MainItemsListBox.SelectedIndex == -1)

                    return;

                ItemViewModel selectedItemViewModel = (ItemViewModel)MainItemsListBox.SelectedItem;

                //App.SelectedMainItem = selectedItemViewModel;

                NavigationService.Navigate(new Uri(string.Format("/Views/CalorieCounterItemsList.xaml?ItemId={0}", selectedItemViewModel.ItemId), UriKind.Relative));

                MainItemsListBox.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                //Do Nothing
            }

        }


        private void CalorieCounter_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }


        #endregion

        #region | Event Hnadlers |

        #region| About |

        private void about_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/CalorieCounterAbout.xaml", UriKind.Relative));
        }

        #endregion

        #region| PinTile |

        private void Pin_Click(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "Calorie Counter";

                standardTileData.BackTitle = "Calorie Counter";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/CalorieCounter/CalorieCOunterStartTileLogo.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/CalorieCounter.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }

        #endregion

        #region | MainItemPin |

        private void MainItemPin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MenuItem menuitem = (MenuItem)sender;
                int itemId = (int)menuitem.CommandParameter;
                ItemViewModel item = App.ViewModel.GetItem(itemId);

                if (item != null)
                {
                    string tileparameter = string.Format("ItemId={0}", item.ItemId);
                    ShellTile tile = CheckIfTileExist(tileparameter);
                    if (tile == null)
                    {
                        StandardTileData secondarytile = new StandardTileData

                        {
                            BackBackgroundImage = new Uri("/Images/CalorieCounter/CalorieCOunterStartTileLogo.png", UriKind.Relative),
                            Title = item.mainitems,
                            BackgroundImage = new Uri(item.ItemImage, UriKind.Relative),
                            BackTitle = "Calorie Counter",
                            BackContent = item.mainitems
                        };

                        ShellTile.Create(new Uri("/Views/CalorieCounterItemsList.xaml?" + tileparameter, UriKind.Relative), secondarytile);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occurred during processing. we apologize for inconvenience.", "error", MessageBoxButton.OK);
            }

        }

        private ShellTile CheckIfTileExist(string tileUri)
        {
            ShellTile shellTile = ShellTile.ActiveTiles.FirstOrDefault(
                    tile => tile.NavigationUri.ToString().Contains(tileUri));
            return shellTile;
        }

        #endregion

        #endregion
    }

    #endregion
}