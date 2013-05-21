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
using System.IO.IsolatedStorage;
using System.IO;
using System.Text;

namespace My_Fitness_Doctor.Views
{
    #region | Add Note Class |
    
    public partial class AddNote : PhoneApplicationPage
    {
        private IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

        #region | Constructor |

        public AddNote()
        {
            InitializeComponent();
        }

        #endregion

        #region | Method |

        private void navigateBack()
        {
            // Reset the application state ... used to ensure
            // that the application re-opens in the correct
            // state.
            settings["state"] = "";
            settings["value"] = "";

            NavigationService.Navigate(new Uri("/Views/Notes.xaml", UriKind.Relative));
        }

        #endregion
     
        #region | EventHnadler |

        #region | Cancel |

        private void AppBar_Cancel_Click(object sender, EventArgs e)
        {
            navigateBack();
        }

        #endregion

        #region | Save |
       
        private void AppBar_Save_Click(object sender, EventArgs e)
        {
            // Save the new note


            // Construct the name of the file.
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Year);
            sb.Append("_");
            sb.Append(String.Format("{0:00}", DateTime.Now.Month));
            sb.Append("_");
            sb.Append(String.Format("{0:00}", DateTime.Now.Day));
            sb.Append("_");
            sb.Append(String.Format("{0:00}", DateTime.Now.Hour));
            sb.Append("_");
            sb.Append(String.Format("{0:00}", DateTime.Now.Minute));
            sb.Append("_");
            sb.Append(String.Format("{0:00}", DateTime.Now.Second));
            sb.Append("_");


            sb.Append(".txt");

            // Now we have everthing we need ... write the file
            // to IsolatedStorage.
            var appStorage = IsolatedStorageFile.GetUserStoreForApplication();

            using (var fileStream = appStorage.OpenFile(sb.ToString(), System.IO.FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.WriteLine(editTextBox.Text);
                }
            }

            // Finished.  Navigate back to MainPage.
            navigateBack();
        }

        #endregion 
        
        #region| PhoneApplicationPage LoadEvent |
      
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            // First, check to make sure we're note returning
            // from an interrupted session, redirected from
            // MainPage.xaml.  We'll check IsolatedStorageSettings.


            string state = "";
            if (settings.Contains("state"))
            {
                if (settings.TryGetValue<string>("state", out state))
                {
                    if (state == "add")
                    {
                        string value = "";
                        if (settings.Contains("value"))
                        {
                            if (settings.TryGetValue<string>("value", out value))
                            {
                                editTextBox.Text = value;
                            }
                        }
                    }
                }
            }

            settings["state"] = "add";
            settings["value"] = editTextBox.Text;
            editTextBox.Focus();
            editTextBox.SelectionStart = editTextBox.Text.Length;
        }

        #endregion

        #region | TextChanged Property EventHandler|

        private void editTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            settings["value"] = editTextBox.Text;
        }
        #endregion
     
        #endregion

    }
  
    #endregion
}