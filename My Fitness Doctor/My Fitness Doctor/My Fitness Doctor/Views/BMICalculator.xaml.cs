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
using Microsoft.Phone.Shell;

namespace My_Fitness_Doctor.Views
{
    #region | BMICalculator Class |

    public partial class BMICalculator : PhoneApplicationPage
    {
        #region | Declaration of variables|
     
        bool I = false;
        bool M = false;
        bool InpH = false;
        bool InpW = false;
        double weight = 0;
        double height = 0;
        double BMI1 = 0;
       
        #endregion

        #region | Constructor |

        public BMICalculator()
        {
            InitializeComponent();
        }

        #endregion
 
        #region | Event Handlers |
        
        #region  | Height Increment button code |

        private void Height_inc_Click(object sender, RoutedEventArgs e)
        {
            double height = string.IsNullOrEmpty(InputHeight.Text) ? 1 : double.Parse(InputHeight.Text);

            double height1 = ++height;
            InputHeight.Text = (string.Format("{0}", height1));
            //InputHeight.Focus();
            //Calculate.Focus();
        }

        #endregion

        #region | Height decrement button code |

        private void Height_dec_Click(object sender, RoutedEventArgs e)
        {
            double height = string.IsNullOrEmpty(InputHeight.Text) ? 1 : double.Parse(InputHeight.Text);

            double height1 = height - 1;
            InputHeight.Text = (string.Format("{0}", height1));
        }

        #endregion

        #region | Weight increment button code|

        private void Weight_inc_Click(object sender, RoutedEventArgs e)
        {
            double weght = string.IsNullOrEmpty(InputWeight.Text) ? 1 : double.Parse(InputWeight.Text);
            double weight1 = ++weght;
            InputWeight.Text = (string.Format("{0}", weight1));
        }

        #endregion

        #region | Weight decrement button code |

        private void Weight_dec_Click(object sender, RoutedEventArgs e)
        {

            double weght = string.IsNullOrEmpty(InputWeight.Text) ? 1 : double.Parse(InputWeight.Text);
            double weight1 = weght - 1;
            InputWeight.Text = (string.Format("{0}", weight1));
        }

        #endregion

        #region |Toggle Switch|

        private void Units_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Units.IsChecked == true) // right - means imperial units are selected
            {
                //fk.Opacity = 0;
                //cl.Opacity = 10;
                I = true;
                M = false;
                // Converting height from cm into inches, becuz the formula uses inches
                height = height * 0.393701;
                if (InpH == true && InpW == true)
                {
                    BMI1 = 703.0 * (weight / height / height);
                }
                else
                {
                    BMI1 = 0;
                }

            }
            else
            {
                //cl.Opacity = 0;
                //fk.Opacity = 100;
                M = true;
                I = false;
                //converting height from feet into meters, becuz the formula uses meters
                height = height * 0.3048;

                if (InpH == true && InpW == true)
                {
                    BMI1 = weight / height / height;
                }
                else
                    BMI1 = 0;
            }

        }

        #endregion
            
        #region | Calculate BMI button code |

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Button source = (Button)sender;
            Image content = source.Content as Image;

            weight = string.IsNullOrEmpty(InputWeight.Text) ? 1 : double.Parse(InputWeight.Text);
            height = string.IsNullOrEmpty(InputHeight.Text) ? 1 : double.Parse(InputHeight.Text);


            if (Units.IsChecked == true)
            {
                // Converting height from cm into inches, becuz the formula uses inches
                height = height * 0.393701;
                if (InpH == true && InpW == true)
                {
                    BMI1 = 703.0 * (weight / height / height);
                }
                else
                {
                    BMI1 = 0;
                }
            }
            else
            {
                //converting height from feet into meters, becuz the formula uses meters
                height = height * 0.3048;

                if (InpH == true && InpW == true)
                {
                    BMI1 = weight / height / height;
                }
                else
                    BMI1 = 0;
            }
            if (height < 0 || weight < 0)
            {
                MessageBox.Show("Invalid input.", "Information", MessageBoxButton.OK);
                BMI1 = 0;
            }


            if (weight == 0 || height == 0)
            {
                MessageBox.Show("Results will be inaccurate. Weight/ Height is not a valid number.", "Information", MessageBoxButton.OK);
                BMI1 = 0;
            }

            if (BMI1 == 0)
            {
                Under0.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 0 && BMI1 <= 1.5)
            {
                Under1.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 1.5 && BMI1 <= 2.5)
            {
                Under2.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 2.5 && BMI1 <= 3.5)
            {
                Under3.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 3.5 && BMI1 <= 4.5)
            {
                Under4.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 4.5 && BMI1 <= 5.5)
            {
                Under5.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 5.5 && BMI1 <= 6.5)
            {
                Under6.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 6.5 && BMI1 <= 7.5)
            {
                Under7.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 7.5 && BMI1 <= 8.5)
            {
                Under8.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 8.5 && BMI1 <= 9.5)
            {
                Under9.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 9.5 && BMI1 <= 10.5)
            {
                Under10.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 10.5 && BMI1 <= 11.5)
            {
                Under11.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 11.5 && BMI1 <= 12.5)
            {
                Under12.Begin();
                Description.Text = "Underweight";
            }

            else if (BMI1 > 12.5 && BMI1 <= 13.5)
            {
                Under13.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 13.5 && BMI1 <= 14.5)
            {
                Under14.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 14.5 && BMI1 <= 15.5)
            {
                Under15.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 15.5 && BMI1 <= 16.5)
            {
                Under16.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 16.5 && BMI1 <= 17.5)
            {
                Under17.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 17.5 && BMI1 <= 18.5)
            {
                Under18.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 18.5 && BMI1 <= 19.9)
            {
                Under19.Begin();
                Description.Text = "Underweight";
            }
            else if (BMI1 > 19.9 && BMI1 <= 20.5)
            {
                Normal20.Begin();
                Description.Text = "Normal";
            }

            else if (BMI1 > 20.5 && BMI1 <= 21.5)
            {
                Normal21.Begin();
                Description.Text = "Normal";
            }
            else if (BMI1 > 21.5 && BMI1 <= 22.5)
            {
                Normal22.Begin();
                Description.Text = "Normal";
            }
            else if (BMI1 > 22.5 && BMI1 <= 23.5)
            {
                Normal23.Begin();
                Description.Text = "Normal";
            }
            else if (BMI1 > 23.5 && BMI1 <= 24.5)
            {
                Normal24.Begin();
                Description.Text = "Normal";
            }
            else if (BMI1 > 24.5 && BMI1 <= 25)
            {
                Normal25.Begin();
                Description.Text = "Normal";
            }
            else if (BMI1 > 25 && BMI1 <= 26.5)
            {
                Over26.Begin();
                Description.Text = "Overweight";
            }
            else if (BMI1 > 26.5 && BMI1 <= 27.5)
            {
                Over27.Begin();
                Description.Text = "Overweight";
            }
            else if (BMI1 > 27.5 && BMI1 <= 28.5)
            {
                Over28.Begin();
                Description.Text = "Overweight";
            }
            else if (BMI1 > 28.5 && BMI1 <= 29.8)
            {
                Over29.Begin();
                Description.Text = "Overweight";
            }
            else if (BMI1 > 29.8 && BMI1 <= 30.5)
            {
                Over30.Begin();
                Description.Text = "Overweight";
            }
            else if (BMI1 > 30.5 && BMI1 <= 31.5)
            {
                Obese31.Begin();
                Description.Text = "Obese";
            }
            else if (BMI1 > 31.5 && BMI1 <= 32.5)
            {
                Obese32.Begin();
                Description.Text = "Obese";
            }
            else if (BMI1 > 32.5 && BMI1 <= 33.5)
            {
                Obese33.Begin();
                Description.Text = "Obese";
            }
            else if (BMI1 > 33.5 && BMI1 <= 34.5)
            {
                Obese34.Begin();
                Description.Text = "Obese";
            }
            else if (BMI1 > 34.5 && BMI1 <= 35)
            {
                Obese35.Begin();
                Description.Text = "Obese";
            }
            else if (BMI1 > 35 && BMI1 <= 36.2)
            {
                cObese36.Begin();
                Description.Text = "Clinically obese";
            }
            else if (BMI1 > 36.2 && BMI1 <= 37.3)
            {
                cObese37.Begin();
                Description.Text = "Clinically obese";
            }
            else if (BMI1 > 37.3 && BMI1 <= 38.4)
            {
                cObese38.Begin();
                Description.Text = "Clinically obese";
            }
            else if (BMI1 > 38.4 && BMI1 <= 39.5)
            {
                cObese39.Begin();
                Description.Text = "Clinically obese";
            }
            else if (BMI1 > 39.5 && BMI1 <= 40)
            {
                cObese40.Begin();
                Description.Text = "Clinically obese";
            }
            else if (BMI1 > 40 && BMI1 <= 41.5)
            {
                mObese41.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 41.5 && BMI1 <= 42.5)
            {
                mObese42.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 42.5 && BMI1 <= 43.5)
            {
                mObese43.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 43.5 && BMI1 <= 44.5)
            {
                mObese44.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 44.5 && BMI1 <= 45.5)
            {
                mObese45.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 45.5 && BMI1 <= 46.5)
            {
                mObese46.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 46.5 && BMI1 <= 47.5)
            {
                mObese47.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 47.5 && BMI1 <= 48.5)
            {
                mObese48.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 > 48.5 && BMI1 <= 49.5)
            {
                mObese49.Begin();
                Description.Text = "Morbidly obese";
            }
            else if (BMI1 == 50)
            {
                mObese50.Begin();
                Description.Text = "Morbidly obese";
            }
            else
            {
                MessageBox.Show("Invalid weight or height.", "Information", MessageBoxButton.OK);
                BMI1 = 0;
            }

            Result.Text = (string.Format("{0}", BMI1));
        }
        #endregion
                
        #region | About Icon |

        private void about_Click_1(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Views/BMIAbout.xaml", UriKind.Relative));
        }
        
        #endregion

        #region | Refresh MenuItem |
    
        private void Refresh_Click_1(object sender, EventArgs e)
        {
            InputHeight.Text = "0";
            InputWeight.Text = "0";
            Description.Text = "";
            Result.Text = "0";
            Reset.Begin();
        }
       
        #endregion

        #region | Rate/Review Button (Commented) I think no need here |
        //private void Rate_Click_1(object sender, EventArgs e)
        //{
        //    Microsoft.Phone.Tasks.MarketplaceReviewTask marketplaceReviewTask = new Microsoft.Phone.Tasks.MarketplaceReviewTask();
        //    marketplaceReviewTask.Show();
        //}
        #endregion

        #region | Share Icon |

        private void Share_Click_1(object sender, EventArgs e)
        {
            ShareStatusTask shareStatusTask = new ShareStatusTask();
            shareStatusTask.Status = String.Format("My BMI is {0} and I'm {1}. using BMI Meter for Windows Phone.", Result.Text, Description.Text);
            shareStatusTask.Show();
        }

        #endregion

        #region | PinTile |

        private void Pin_Click(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "BMI Meter";

                standardTileData.BackTitle = "BMI Meter";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/BMI/BMIStartTileIcon.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/BMICalculator.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }

        #endregion

        #region | Text PropertyChanged EventHandler |

        private void InputHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            InpH = true;
        }

        private void InputWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            InpW = true;
        }

        #endregion
        
        #endregion
    }


    #endregion
}
