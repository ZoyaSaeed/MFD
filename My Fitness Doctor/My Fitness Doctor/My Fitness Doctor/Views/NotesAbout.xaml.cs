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

namespace My_Fitness_Doctor.Views
{
    #region | Notes About Class|
    
    public partial class NotesAbout : PhoneApplicationPage
    {
        #region | Constructor |
        
        public NotesAbout()
        {
            InitializeComponent();
        }

        #endregion

        #region| Close EventHandler |

        private void close_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        #endregion
    }

    #endregion
}