using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using System.Device.Location;
using Microsoft.Phone.Maps.Controls;
using System.Threading.Tasks;
using Microsoft.Phone.Maps.Services;
using System.IO.IsolatedStorage;

using System.Windows.Threading;
using Microsoft.Phone.Tasks;
using System.Windows.Media;

using System.IO;
using System.Windows.Media.Imaging;
using Windows.Devices.Geolocation;
using System.Windows.Shapes;

using System.Windows.Media.Animation;
using System.Windows.Input;



namespace My_Fitness_Doctor.Views
{
    #region | Tracker Class |

    public partial class Tracker : PhoneApplicationPage
    {
        private GeoCoordinateWatcher _watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
        private MapPolyline _line;
        private DispatcherTimer _timer = new DispatcherTimer();
        private long _startTime;
        private double _kilometres;
        private long _previousPositionChangeTick;
        List<GeoCoordinate> _geopositions;
        CameraCaptureTask _camerCaptureTask = new CameraCaptureTask();
        
        #region | Constructor |

        public Tracker()
        {
            InitializeComponent();
            _camerCaptureTask.Completed += _camerCaptureTask_Completed;


            SupportedOrientations = SupportedPageOrientation.Portrait | SupportedPageOrientation.Landscape;
            _line = new MapPolyline();
            _line.StrokeColor = Colors.Red;
            _line.StrokeThickness = 15;
            map.MapElements.Add(_line);
            map.CartographicMode = Microsoft.Phone.Maps.Controls.MapCartographicMode.Road;
            _watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(Watcher_PositionChanged);
            _geopositions = new List<GeoCoordinate>();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;



            // Sample code to localize the ApplicationBar
            // BuildLocalizedApplicationBar();
            this.Loaded += Tracker_Loaded;

        }

        #endregion

        #region | Timer |

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan runTime = TimeSpan.FromMilliseconds(System.Environment.TickCount - _startTime);
            Duration.Text = runTime.ToString(@"hh\:mm\:ss");
        }

        #endregion
        
        #region| Methods |


        async void Tracker_Loaded(object sender, RoutedEventArgs e)
        {
            Geolocator locater = new Geolocator();
            Geoposition position = await locater.GetGeopositionAsync();
          //  map.Center = position.Coordinate.ToGeoCoordinate();
            locater.DesiredAccuracyInMeters = 5;
            locater.DesiredAccuracy = PositionAccuracy.High;
            locater.MovementThreshold = 100;

        }

        private void Watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            var coord = new GeoCoordinate(e.Position.Location.Latitude, e.Position.Location.Longitude);



            if (_line.Path.Count > 0)
            {
                // find the previos point and measure the distance travelled
                var previousPoint = _line.Path.Last();
                var distance = coord.GetDistanceTo(previousPoint);

                // compute pace
                var millisPerKilometer = (1000.0 / distance) * (System.Environment.TickCount - _previousPositionChangeTick);

                // compute total distance travelled
                _kilometres += distance / 1000.0;

                SpeedValue.Text = TimeSpan.FromMilliseconds(millisPerKilometer).ToString(@"mm\:ss");
                DistanceValue.Text = string.Format("{0:f2} ", _kilometres);
                EnergyValue.Text = string.Format("{0:f0}", _kilometres * 65);
            }


            map.Center = coord;

            _line.Path.Add(coord);
            _previousPositionChangeTick = System.Environment.TickCount;


        }
#endregion

        #region|Event Handlers|

        #region | SartStop |

        private void Start_Click(object sender, RoutedEventArgs e)
        {

            if (_timer.IsEnabled)
            {
                _watcher.Stop();
                _timer.Stop();
                Start.Content = "Restart";
                PauseImage.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                _watcher.Start();
                _timer.Start();
                _startTime = System.Environment.TickCount;
                Start.Content = "Pause";
                PauseImage.Visibility = System.Windows.Visibility.Visible;
            }


        }

        #endregion

        #region | Stop |

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            Start.Content = "Start";
            PauseImage.Visibility = System.Windows.Visibility.Collapsed;
            Duration.Text = "00:00:00";
            _watcher.Stop();
        }

        #endregion

        #region|Map Modes|

        private void aerial_Click_1(object sender, RoutedEventArgs e)
        {
            map.CartographicMode = MapCartographicMode.Aerial;
            Settings2.Visibility = System.Windows.Visibility.Collapsed;

        }

        private void road_Click_2(object sender, RoutedEventArgs e)
        {
            map.CartographicMode = MapCartographicMode.Road;
            Settings2.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void hybrid_Click_2(object sender, RoutedEventArgs e)
        {
            map.CartographicMode = MapCartographicMode.Hybrid;
            Settings2.Visibility = System.Windows.Visibility.Collapsed;

        }

        private void terrain_Click_2(object sender, RoutedEventArgs e)
        {
            map.CartographicMode = MapCartographicMode.Terrain;
            Settings2.Visibility = System.Windows.Visibility.Collapsed;
        }

        #endregion

        #region| Map ZoomLevel |

        private void ZoomIn_Click_1(object sender, RoutedEventArgs e)
        {
            map.ZoomLevel = Math.Min(map.ZoomLevel + 1, 20);
        }

        private void ZoomOut_Click_1(object sender, RoutedEventArgs e)
        {
            map.ZoomLevel = Math.Max(map.ZoomLevel - 1, 1);
        }

        #endregion

        #region| Map Expand feature|

        BitmapImage imgexpand = new BitmapImage(new Uri("/Images/Tracker/Expand.png", UriKind.Relative));

        BitmapImage imgcontract = new BitmapImage(new Uri("/Images/Tracker/Contract.png", UriKind.Relative));

        private void Contract_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            double height = map.Height;
            double from, to;

            // animate from 150 to 800, or vice versa
            if (height == 264)
            {
                from = 264;
                to = 800;
                Contract.Source = imgexpand;
            }
            else
            {
                from = 800;
                to = 264;
                Contract.Source = imgcontract;
            }

            Storyboard sb = new Storyboard();
            DoubleAnimation fillHeightAnimation = new DoubleAnimation();
            fillHeightAnimation.From = from;
            fillHeightAnimation.To = to;
            fillHeightAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.1));

            Storyboard.SetTarget(fillHeightAnimation, map);
            Storyboard.SetTargetProperty(fillHeightAnimation, new PropertyPath("Height"));

            sb.Children.Add(fillHeightAnimation);
            sb.Begin();


        }

        #endregion

        #region| Map Color Modes|

        private void ColorMode_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {


            map.ColorMode = MapColorMode.Dark;
            Light.Visibility = System.Windows.Visibility.Visible;

        }

        
        private void Light_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {

            map.ColorMode = MapColorMode.Light;
            Light.Visibility = System.Windows.Visibility.Collapsed;
            ColorMode.Visibility = System.Windows.Visibility.Visible;


        }

        #endregion
    
        #region | camera |

        private void Camera_Click_1(object sender, EventArgs e)
        {
            _camerCaptureTask.Show();
        }

        
        void _camerCaptureTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                SaveToIsolatedStorage(e.ChosenPhoto, "image1.jpg");
            }
            MessageBox.Show("Image has been saved in the isolated storage successfully!!!");
        }

        #endregion

        #region | Save Picture |

        private void SaveToIsolatedStorage(Stream imageStream, string fileName)
        {
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (myIsolatedStorage.FileExists(fileName))
                {
                    myIsolatedStorage.DeleteFile(fileName);
                }

                IsolatedStorageFileStream fileStream = myIsolatedStorage.CreateFile(fileName);
                BitmapImage bitmap = new BitmapImage();
                bitmap.SetSource(imageStream);

                WriteableBitmap wb = new WriteableBitmap(bitmap);
                wb.SaveJpeg(fileStream, wb.PixelWidth, wb.PixelHeight, 0, 85);
                fileStream.Close();
            }
        }

        #endregion

        #region | Pin |

        private void Pin_Click_1(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "Tracker";

                standardTileData.BackTitle = "Tracker";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/Tracker/TrackerStartTileLogo.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/Tracker.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }

        #endregion

        #region| PushPin |

        async void Map_Click_1(object sender, EventArgs e)
        {
            Geolocator locater = new Geolocator();
            Geoposition position = await locater.GetGeopositionAsync();
          //  UserLocationMarker marker = (UserLocationMarker)this.FindName("UserLocationMarker");

          //  marker.GeoCoordinate = position.Coordinate.ToGeoCoordinate();

          //  Pushpin pushpin = (Pushpin)this.FindName("MyPushpin");
           // pushpin.GeoCoordinate = position.Coordinate.ToGeoCoordinate();
           // pushpin.Visibility = System.Windows.Visibility.Visible;

        }

        #endregion

        #region| Settings |

        private void Settings1_Click_1(object sender, EventArgs e)
        {
            Settings2.Visibility = System.Windows.Visibility.Visible;
        }

        private void LayoutRoot_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Settings2.Visibility = System.Windows.Visibility.Collapsed;
        }

        #endregion

        #endregion
    }

    #endregion
}
   
    