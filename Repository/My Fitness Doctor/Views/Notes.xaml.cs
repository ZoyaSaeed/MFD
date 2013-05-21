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
using System.IO;
using System.IO.IsolatedStorage;
using My_Fitness_Doctor.ViewModels;
using Microsoft.Phone.Shell;

namespace My_Fitness_Doctor.Views
{
    #region | Notes Class |
    
    public partial class Notes : PhoneApplicationPage
    {
        #region | Constructor |
        
        public Notes()
        {
            InitializeComponent();
        }
      
        #endregion
        
        #region| PhoneApplicationPage Load Event |

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            

            // Deterine the state of the application when last used
            // and restore the state.  I'll simply read the app settings
            // 'state' property and navigate acoordingly.  Each page
            // will then be responsible for retrieving settings
            // and setting the state once again.
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            
            string state = "";
            if (settings.Contains("state"))
            {
                if (settings.TryGetValue<string>("state", out state))
                {
                    if (state == "add")
                    {
                        NavigationService.Navigate(new Uri("/Views/AddNote.xaml", UriKind.Relative));
                    }
                    else if (state == "edit")
                    {
                        NavigationService.Navigate(new Uri("/Views/EditNote.xaml", UriKind.Relative));
                    }
                }
            }


            bindList();
        }

        #endregion

        #region| Methods |

        private void bindList()
        {
            var appStorage = IsolatedStorageFile.GetUserStoreForApplication();

            string[] fileList = appStorage.GetFileNames();

            List<Note> notes = new List<Note>();

            foreach (string file in fileList)
            {
                // Avoid the application settings file ... it doesn't conform
                // to the naming convention!
                if (file != "__ApplicationSettings")
                {
                    // Retrieve the file
                    string fileName = file;

                    // Pluck out the date parts
                    string year = file.Substring(0, 4);
                    string month = file.Substring(5, 2);
                    string day = file.Substring(8, 2);
                    string hour = file.Substring(11, 2);
                    string minute = file.Substring(14, 2);
                    string second = file.Substring(17, 2);
                   
                    
                    DateTime dateCreated = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day), int.Parse(hour), int.Parse(minute), int.Parse(second));
                    DateTime dateCreated1 = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day), int.Parse(hour), int.Parse(minute), int.Parse(second));
                    //var appStorage = IsolatedStorageFile.GetUserStoreForApplication();

                    string title;



                    using (var filee = appStorage.OpenFile(fileName, FileMode.Open))
                    {
                        using (StreamReader sw = new StreamReader(filee))
                        {
                            // sw.WriteLine(editTextBox.Text);
                            string titlee = sw.ReadToEnd();
                            title = titlee.Substring(0,5);
                        }
                    }

                    notes.Add(new Note() { Title = title, DateCreated = dateCreated.ToLongDateString(), DateCreated1 = dateCreated.ToLongTimeString(), FileName = fileName, });
                  //  notes.Add(new Note() { DateCreated = dateCreated.ToLongDateString(), FileName = fileName, });
                    //notes.Add(new Note() { DateCreated1 = dateCreated.ToLongTimeString(), FileName = fileName, }); 
                   
                }
            }
            noteListBox.ItemsSource = notes;
        }

        #endregion

        #region| Location Button |

        private void noteLocation_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton clickedLink = (HyperlinkButton)sender;

            string uri = String.Format("/Views/EditNote.xaml?id={0}", clickedLink.Tag);

            NavigationService.Navigate(new Uri(uri, UriKind.Relative));
        }

        #endregion

        #region| EventHandlers |

        #region | Add |

        private void AppBar_Add_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/AddNote.xaml", UriKind.Relative));

        }

        #endregion
        
        #region | PinTile |

        private void Pin_Click(object sender, EventArgs e)
        {
            try
            {
                StandardTileData standardTileData = new StandardTileData();
                standardTileData.BackgroundImage = null;
                standardTileData.Title = "Notes";

                standardTileData.BackTitle = "Notes";
                standardTileData.BackContent = "";
                standardTileData.BackBackgroundImage = new Uri("/Images/Notes/NotesStartTileIcon.png", UriKind.Relative);
                ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("MainPage.xaml"));
                if (tiletopin == null)
                {
                    ShellTile.Create(new Uri("/Views/Notes.xaml", UriKind.Relative), standardTileData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Pinned.", "Information", MessageBoxButton.OK);
            }
        }

#endregion

        #region| About |

        private void about_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NotesAbout.xaml", UriKind.Relative));

        }
        #endregion

        #endregion
    
    }

#endregion
}