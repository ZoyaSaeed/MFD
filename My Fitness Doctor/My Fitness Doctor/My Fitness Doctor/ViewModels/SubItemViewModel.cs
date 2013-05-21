using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace My_Fitness_Doctor.ViewModels
{
    #region | SubItemViewModel |
   
    public class SubItemViewModel : INotifyPropertyChanged
    {
        #region | Properties |
        
        private int _itemid1;

        public int ItemId1
        {
            get
            {
                return _itemid1;
            }
            set
            {
                if (value != _itemid1)
                {
                    _itemid1 = value;
                    NotifyPropertyChanged("ItemId1");
                }
            }

        }
        private int _subitemid;

        public int SubItemId
        {
            get
            {
                return _subitemid;
            }
            set
            {
                if (value != _subitemid)
                {
                    _subitemid = value;
                    NotifyPropertyChanged("SubItemId");
                }
            }

        }


        private string _subitemname;

        public string SubItemName
        {
            get
            {
                return _subitemname;
            }
            set
            {
                if (value != _subitemname)
                {
                    _subitemname = value;
                    NotifyPropertyChanged("SubItemName");
                }
            }

        }
        private string calories;

        public string Calories
        {
            get
            {
                return calories;
            }
            set
            {
                if (value != calories)
                {
                    calories = value;
                    NotifyPropertyChanged("Calories");
                }
            }

        }
        private string totalfat;

        public string TotalFat
        {
            get
            {
                return totalfat;
            }
            set
            {
                if (value != totalfat)
                {
                    totalfat = value;
                    NotifyPropertyChanged("TotalFat");
                }
            }
        }

        private string cholestrol;

        public string Cholestrol
        {
            get
            {
                return cholestrol;
            }
            set
            {
                if (value != cholestrol)
                {
                    cholestrol = value;
                    NotifyPropertyChanged("Cholestrol");
                }
            }
        }

        private string sodium;

        public string Sodium
        {
            get
            {
                return sodium;
            }
            set
            {
                if (value != sodium)
                {
                    sodium = value;
                    NotifyPropertyChanged("Sodium");
                }
            }
        }

        private string totalcarbs;

        public string TotalCarbs
        {
            get
            {
                return totalcarbs;
            }
            set
            {
                if (value != totalcarbs)
                {
                    totalcarbs = value;
                    NotifyPropertyChanged("TotalCarbs");
                }
            }
        }

        private string protein;

        public string Protein
        {
            get
            {
                return protein;
            }
            set
            {
                if (value != protein)
                {
                    protein = value;
                    NotifyPropertyChanged("Protein");
                }
            }
        }

        private string calcium;

        public string Calcium
        {
            get
            {
                return calcium;
            }
            set
            {
                if (value != calcium)
                {
                    calcium = value;
                    NotifyPropertyChanged("Calcium");
                }
            }
        }

        private string potassium;

        public string Potassium
        {
            get
            {
                return potassium;
            }
            set
            {
                if (value != potassium)
                {
                    potassium = value;
                    NotifyPropertyChanged("Potassium");
                }
            }
        }


        private string myColor;

        public string MyColor
        {
            get
            {
                return myColor;
            }
            set
            {
                if (value != myColor)
                {
                    myColor = value;
                    NotifyPropertyChanged("MyColor");
                }
            }
        }

        private string servingsize;

        public string ServingSize
        {
            get
            {
                return servingsize;
            }
            set
            {
                if (value != servingsize)
                {
                    servingsize = value;
                    NotifyPropertyChanged("ServingSize");
                }
            }

        }

        #endregion

        #region | PropertyChanged Event Handler |

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
  
    #endregion
}