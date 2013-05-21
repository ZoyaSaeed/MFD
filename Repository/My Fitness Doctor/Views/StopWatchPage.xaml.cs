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
using System.Threading;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using Microsoft.Phone.Shell;

namespace My_Fitness_Doctor.Views
{
    #region | StopWatch Class |
  
  public partial class StopWatchPage : PhoneApplicationPage
    {
 
        #region | Constructor |
      
        public StopWatchPage()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
           
        }

        #endregion

        #region | Application Bar|

        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBar.BackgroundColor = Color.FromArgb(255, 7, 4, 25);
            ApplicationBar.ForegroundColor = Color.FromArgb(255, 255, 255, 255); ;

            #region | Pin Tile AppBar Icon |

            ApplicationBarIconButton PinTile = new ApplicationBarIconButton(new Uri("/Icons/Dark/Pin.png", UriKind.Relative));
            PinTile.Text = "Pin";
            ApplicationBar.Buttons.Add(PinTile);
            PinTile.Click += new EventHandler(PinTile_Click);

            #endregion

            #region | StartStop appBarIcon|

            ApplicationBarIconButton PlayPause = new ApplicationBarIconButton(new Uri("/Icons/Dark/transport.play.png", UriKind.Relative));
            PlayPause.Text = "Start";
            ApplicationBar.Buttons.Add(PlayPause);
            PlayPause.Click += new EventHandler(PlayPause_Click);

            #endregion

            #region | Settings appBarIcon|

            ApplicationBarIconButton Settings = new ApplicationBarIconButton(new Uri("/Icons/Dark/appbar.feature.settings.rest.png", UriKind.Relative));
            Settings.Text = "Settings";
            ApplicationBar.Buttons.Add(Settings);
            Settings.Click += new EventHandler(Settings_Click);

            #endregion
           
        }

      #endregion

        #region | Class Level Variables |

        static Boolean stopped = true;
        static long hrs = 0, min = 0, sec = 0, milisec = 0;
        static Stopwatch Stopwatch1 = new Stopwatch();
        Timer timer;
        
        #endregion
       
        #region | Properties |

        public object TimerDisplay { get; set; }

        #endregion

        #region | Methods [static] |

        void updateDispaly(object displayBlock)
        {
           milisec = Stopwatch1.ElapsedMilliseconds;

            sec = milisec / 1000; milisec = milisec % 1000;
            min = sec / 60; sec = sec % 60;
            hrs = min / 60; min = min % 60;

            Hours.Dispatcher.BeginInvoke(delegate
            {
                Hours.Text = hrs.ToString("00") ;
            });

            MilliSeconds.Dispatcher.BeginInvoke(delegate
            {
                MilliSeconds.Text = milisec.ToString("000");
            });

            Seconds.Dispatcher.BeginInvoke(delegate
            {
                Seconds.Text = sec.ToString("00") ;
            });

            Minutes.Dispatcher.BeginInvoke(delegate
            {
                Minutes.Text = min.ToString("00") ;
            });
        }

        #endregion
        
        #region | Event Handlers |

        #region| PinTile |

        void PinTile_Click(object sender, EventArgs e)
        {
            
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "StopWatch";

                standardTileData.BackTitle = "StopWatch";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/StopWatch/StopWatchStartTileLogo.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/StopWatchPage.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }

        #endregion

        #region | StartStop|

        private void PlayPause_Click(object sender, EventArgs e)
        {
            ApplicationBarIconButton appbarIcon = (ApplicationBarIconButton)ApplicationBar.Buttons[1];

            if (stopped)
            {
                stopped = false;
                appbarIcon.IconUri = new Uri("/Icons/Dark/transport.pause.png", UriKind.Relative);
                appbarIcon.Text = "Stop";
                timer = new Timer(new TimerCallback(updateDispaly), TimerDisplay, 0, 100);
                Stopwatch1.Start();

            }
            else 
            {
                stopped = true;
                appbarIcon.IconUri = new Uri("/Icons/Dark/transport.play.png", UriKind.Relative);
                appbarIcon.Text = "Start";
                timer.Dispose();
                Stopwatch1.Stop();

            }
        }

        #endregion

        #region | Settings |

        private void Settings_Click(object sender, EventArgs e)
        {           
            // do nothing
        }

        #endregion

        #region| Lap Count |

        private int lapCount;
        
        private void Lap_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                lapCount++;
                string lapStr1 = Stopwatch1.Elapsed.ToString();
                string lapStr2 = lapStr1.Substring(0, 12);
                string lapStr = string.Format("  " + "Lap{0}", lapCount.ToString() + "   " + lapStr2);
                LapListBox.Items.Add(lapStr);

            }

            catch (Exception ex)

            { 
            //do nothing
            }
         
        }

        #endregion

        #region | Reset |

        private void Reset1_Click(object sender, RoutedEventArgs e)
        {
           Stopwatch1.Reset();
           LapListBox.Items.Clear();
           Stopwatch1.Stop();
           MilliSeconds.Text = "000";
           Seconds.Text = "00";
           Minutes.Text = "00";
           Hours.Text = "00";
        }

        #endregion

        #endregion

    }

    #endregion
    
} 

