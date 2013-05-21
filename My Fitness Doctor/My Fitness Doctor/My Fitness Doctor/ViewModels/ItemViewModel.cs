using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace My_Fitness_Doctor
{

    #region |ItemViewModel Class|

    public class ItemViewModel : INotifyPropertyChanged
    {
        #region | Set Properties |

        #region | CalorieCounter Properties |

        private string MainItems;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string mainitems
        {
            get
            {
                return MainItems;
            }
            set
            {
                if (value != MainItems)
                {
                    MainItems = value;
                    NotifyPropertyChanged("mainitems");
                }
            }
        }

        private string _ItemImage;
        public string ItemImage
        {
            get
            {
                return _ItemImage;
            }
            set
            {
                _ItemImage = value;
                NotifyPropertyChanged("ItemImage");
            }
        }

        private string ItemDescription;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string itemdescription
        {
            get
            {
                return ItemDescription;
            }
            set
            {
                if (value != ItemDescription)
                {
                    ItemDescription = value;
                    NotifyPropertyChanged("itemdescription");
                }
            }
        }

        private int _itemid;

        public int ItemId
        {
            get
            {
                return _itemid;
            }
            set
            {
                if (value != _itemid)
                {
                    _itemid = value;
                    NotifyPropertyChanged("ItemId");
                }
            }

        }

        private string _color;

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value != _color)
                {
                    _color = value;
                    NotifyPropertyChanged("Color");
                }
            }

        }

        #endregion

        #region | HealthTips Propert |

        private string _header;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                if (value != _header)
                {
                    _header = value;
                    NotifyPropertyChanged("Header");
                }
            }
        }

        private string _tip;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                if (value != _tip)
                {
                    _tip = value;
                    NotifyPropertyChanged("Tip");
                }
            }
        }
        private string _heartTipHeader;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string HeartTipHeader
        {
            get
            {
                return _heartTipHeader;
            }
            set
            {
                if (value != _heartTipHeader)
                {
                    _heartTipHeader = value;
                    NotifyPropertyChanged("HeartTipHeader");
                }
            }
        }

        private string _Hearttip;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string HeartTip
        {
            get
            {
                return _Hearttip;
            }
            set
            {
                if (value != _Hearttip)
                {
                    _Hearttip = value;
                    NotifyPropertyChanged("HeartTip");
                }
            }
        }

        private string _brainTipHeader;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string BrainTipHeader
        {
            get
            {
                return _brainTipHeader;
            }
            set
            {
                if (value != _brainTipHeader)
                {
                    _brainTipHeader = value;
                    NotifyPropertyChanged("BrainTipHeader");
                }
            }
        }

        private string _Braintip;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string BrainTip
        {
            get
            {
                return _Braintip;
            }
            set
            {
                if (value != _Braintip)
                {
                    _Braintip = value;
                    NotifyPropertyChanged("BrainTip");
                }
            }
        }

        private string _Skintip;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string SkinTip
        {
            get
            {
                return _Skintip;
            }
            set
            {
                if (value != _Skintip)
                {
                    _Skintip = value;
                    NotifyPropertyChanged("SkinTip");
                }
            }
        }

        private string _skinTipHeader;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string SkinTipHeader
        {
            get
            {
                return _skinTipHeader;
            }
            set
            {
                if (value != _skinTipHeader)
                {
                    _skinTipHeader = value;
                    NotifyPropertyChanged("SkinTipHeader");
                }
            }
        }

        #endregion

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