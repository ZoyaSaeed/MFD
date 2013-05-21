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
using System.Collections.ObjectModel;

namespace My_Fitness_Doctor.ViewModels
{
    #region | SubMainViewModel Class |
   
    public class SubMainViewModel : INotifyPropertyChanged
    {

        public SubMainViewModel()
        {
            this.SubItems = new ObservableCollection<SubItemViewModel>();
        }

        public ObservableCollection<SubItemViewModel> SubItems { get; private set; }
        private string _sampleProperty = "Sample Runtime Property Value";

        #region | Properties |
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        #endregion

        #region | SampleData |
        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            #region | Fruits |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 1,
                ServingSize="cup,pieces(5.8 oz)",
                SubItemName = "Mangos, raw ",
                Calories = "99",
                TotalFat = "0.6",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "25.7",
                Protein = "1.4",
                Calcium = "16.5",
                Potassium = "277.2"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 2,
                ServingSize="cup",
                SubItemName = "Brooks Tropicals Papaya ",
                Calories = "55",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "4",
                TotalCarbs = "0",
                Protein = "0.9",
                Calcium = "0",
                Potassium = "0"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 3,
                ServingSize="cup",
                SubItemName = "Brooks Tropicals Boniato ",
                Calories = "140",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "17",
                TotalCarbs = "32.3",
                Protein = "2.2",
                Calcium = "0",
                Potassium = "0"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 4,
                ServingSize="cup",
                SubItemName = "Brooks Tropicals Calabaza ",
                Calories = "10",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "2",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 5,
                ServingSize="cup",
                SubItemName = "Brooks Tropicals Plantain",
                Calories = "180",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "6",
                TotalCarbs = "47.2",
                Protein = "1.9",
                Calcium = "0",
                Potassium = "0"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 6,
                ServingSize="cup",
                SubItemName = "Brooks Tropicals Key Lime",
                Calories = "37",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "7",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 7,
                ServingSize="cup,shredded",
                SubItemName = "Brooks Tropicals Coconut",
                Calories = "283",
                TotalFat = "26.8",
                Cholestrol = "0",
                Sodium = "16",
                TotalCarbs = "12.2",
                Protein = "2.7",
                Calcium = "0",
                Potassium = "0"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 8,
                ServingSize="medium apple(6.4 oz)",
                SubItemName = "Grapple Grape Flavoured Apple",
                Calories = "95",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "25",
                Protein = "0",
                Calcium = "10",
                Potassium = "0"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 9,
                ServingSize="stick",
                SubItemName = "Brooks Tropicals Sugar Cane",
                Calories = "40",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "10",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 10,
                ServingSize="cup,pieces(5.8 oz)",
                SubItemName = "Apples, unsweetened, frozen",
                Calories = "83",
                TotalFat = "0.6",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "21.3",
                Protein = "0.5",
                Calcium = "6.9",
                Potassium = "133.2"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 11,
                ServingSize="cup(8.5 oz)",
                SubItemName = "Apricots, sweetened, frozen",
                Calories = "237",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "10",
                TotalCarbs = "60.7",
                Protein = "1.7",
                Calcium = "24.2",
                Potassium = "554.2"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 12,
                ServingSize="cup,unthawed(5.3 oz)",
                SubItemName = "Blackberries, unsweetened, frozen",
                Calories = "97",
                TotalFat = "0.6",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "23.7",
                Protein = "1.8",
                Calcium = "43.8",
                Potassium = "211.4"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 13,
                ServingSize="cup,unthawed(8.1 oz)",
                SubItemName = "Blueberries, sweetened, frozen",
                Calories = "79",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "18.9",
                Protein = "0.7",
                Calcium = "12.4",
                Potassium = "83.7"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 14,
                ServingSize="cup,unthawed(4.7 oz)",
                SubItemName = "Boysenberries, unsweetened, frozen",
                Calories = "66",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "16.1",
                Protein = "1.5",
                Calcium = "35.6",
                Potassium = "183.5"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 15,
                ServingSize="cup,unthawed(5.2 oz)",
                SubItemName = "Loganberries, frozen",
                Calories = "81",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "19.1",
                Protein = "2.2",
                Calcium = "38.2",
                Potassium = "213.2"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 16,
                ServingSize="cup,unthawed(6.1 oz)",
                SubItemName = "Melon Balls, frozen",
                Calories = "57",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "54",
                TotalCarbs = "13.7",
                Protein = "1.5",
                Calcium = "17.3",
                Potassium = "484.4"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 17,
                ServingSize="cup,unthawed(8.8 oz)",
                SubItemName = "Mixed Fruit, sweetened, frozen",
                Calories = "245",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "8",
                TotalCarbs = "60.6",
                Protein = "3.6",
                Calcium = "17.5",
                Potassium = "327.5"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 18,
                ServingSize="slice(0.5 oz)",
                SubItemName = "Peaches, sweetened, frozen",
                Calories = "15",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "3.7",
                Protein = "0.1",
                Calcium = "0.5",
                Potassium = "20.2"


            });  this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 19,
                ServingSize="cup,unthawed(8.8 oz)",
                SubItemName = "Raspberries, sweetened, frozen",
                Calories = "258",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "65.5",
                Protein = "1.8",
                Calcium = "5",
                Potassium = "285"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 20,
                ServingSize="cup,thawed(9 oz)",
                SubItemName = "Strawberries, sweetened, sliced, frozen",
                Calories = "245",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "8",
                TotalCarbs = "66.1",
                Protein = "1.4",
                Calcium = "28.1",
                Potassium = "249.9"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 21,
                ServingSize="cup,thawed(9 oz)",
                SubItemName = "Strawberries, sweetened, whole, frozen",
                Calories = "199",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "53.6",
                Protein = "1.3",
                Calcium = "28.1",
                Potassium = "249.9"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 22,
                ServingSize="berry(0.4 oz)",
                SubItemName = "Strawberries, unsweetened, frozen",
                Calories = "4",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "1",
                Protein = "0.1",
                Calcium = "1.7",
                Potassium = "15.7"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 23,
                ServingSize="fruit(0.2 oz)",
                SubItemName = "Acerola (West Indian Cherry), raw",
                Calories = "2",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.4",
                Protein = "0.1",
                Calcium = "0.6",
                Potassium = "7"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 24,
                ServingSize="extra small[4 oz with refuse,2.5\" dia](3.6 oz)",
                SubItemName = "Apples, raw, with Skin",
                Calories = "53",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "14.1",
                Protein = "0.3",
                Calcium = "6.1",
                Potassium = "109.1"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 25,
                ServingSize="cup,sliced(3.9 oz)",
                SubItemName = "Apples, raw, without skin",
                Calories = "53",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "14",
                Protein = "0.3",
                Calcium = "5.5",
                Potassium = "99"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 26,
                ServingSize="fruit[1.3 oz with refuse](1.2 oz)",
                SubItemName = "Apricots, raw",
                Calories = "17",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "3.9",
                Protein = "0.5",
                Calcium = "0.4",
                Potassium = "90.7"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 27,
                ServingSize="fruit[7.2 oz with refuse](4.8 oz)",
                SubItemName = "Avocados, Californian, raw ",
                Calories = "227",
                TotalFat = "21",
                Cholestrol = "0",
                Sodium = "11",
                TotalCarbs = "11.8",
                Protein = "2.7",
                Calcium = "17.7",
                Potassium = "689.5"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 28,
                ServingSize="cup,pureed(8.1 oz)",
                SubItemName = "Avocados, Florida, raw",
                Calories = "276",
                TotalFat = "23.1",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "18.4",
                Protein = "5.1",
                Calcium = "2.3",
                Potassium = "807.3"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 29,
                ServingSize="cup,sliced(5.1 oz)",
                SubItemName = "Avocados, average all varieties, raw",
                Calories = "234",
                TotalFat = "21.4",
                Cholestrol = "0",
                Sodium = "10",
                TotalCarbs = "12.5",
                Protein = "2.9",
                Calcium = "17.5",
                Potassium = "708.1"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 30,
                ServingSize="extra small[4.5 oz with refuse,5\" long](2.9 oz)",
                SubItemName = "Bananas, raw",
                Calories = "73",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "18.7",
                Protein = "0.9",
                Calcium = "4.1",
                Potassium = "293.6"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 31,
                ServingSize="berry",
                SubItemName = "Blueberries, raw",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.2",
                Protein = "0.1",
                Calcium = "0.1",
                Potassium = "1"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 32,
                ServingSize="cup(7.8 oz)",
                SubItemName = "Breadfruit, raw",
                Calories = "227",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "4",
                TotalCarbs = "59.7",
                Protein = "2.4",
                Calcium = "37.4",
                Potassium = "1078"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 33,
                ServingSize="wedge[3.2 oz with rind,1/8 of 4.25\" dia melon](1.9 oz)",
                SubItemName = "Cantaloupe Melons, raw",
                Calories = "19",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "4.8",
                Protein = "0.5",
                Calcium = "5",
                Potassium = "146.9"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 34,
                ServingSize="whole[2.7 oz with refuse,3\" long](2.5 oz)",
                SubItemName = "Carambola (Starfruit), raw",
                Calories = "22",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "4.7",
                Protein = "0.7",
                Calcium = "0",
                Potassium = "93.1"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 35,
                ServingSize="fruit[0.8 oz withrefuse](0.7 oz)",
                SubItemName = "Carissa (Natal-Plum), raw",
                Calories = "12",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "2.7",
                Protein = "0.1",
                Calcium = "2.2",
                Potassium = "52"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 36,
                ServingSize="cup,cubes(6 oz)",
                SubItemName = "Casaba Melons, raw",
                Calories = "48",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "15",
                TotalCarbs = "11.2",
                Protein = "1.9",
                Calcium = "18.7",
                Potassium = "309.4"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 37,
                ServingSize="cup[4 oz with pits],yields(3.6 oz)",
                SubItemName = "Red Sour Cherries, raw",
                Calories = "52",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "12.5",
                Protein = "1",
                Calcium = "16.5",
                Potassium = "178.2"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 38,
                ServingSize="cherry(0.3 oz)",
                SubItemName = "Sweet Cherries, raw",
                Calories = "5",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "1.3",
                Protein = "0.1",
                Calcium = "1.1",
                Potassium = "18.2"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 39,
                ServingSize="fruit[3.4 oz with refuse](2.6 oz)",
                SubItemName = "Clementines, raw",
                Calories = "35",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "8.9",
                Protein = "0.6",
                Calcium = "22.2",
                Potassium = "131"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 40,
                ServingSize="cup(3.2 oz)",
                SubItemName = "Concord Grapes, raw",
                Calories = "62",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "15.8",
                Protein = "0.6",
                Calcium = "12.9",
                Potassium = "175.7"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 41,
                ServingSize="cup,sliced(3.9 oz)",
                SubItemName = "Crabapples, raw",
                Calories = "84",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "21.9",
                Protein = "0.4",
                Calcium = "19.8",
                Potassium = "213.4"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 42,
                ServingSize="cup,whole(3.5 oz)",
                SubItemName = "Cranberries, raw ",
                Calories = "46",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "12.2",
                Protein = "0.4",
                Calcium = "8",
                Potassium = "85"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 43,
                ServingSize="cup(4 oz)",
                SubItemName = "Currants, European Black, raw",
                Calories = "71",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "17.2",
                Protein = "1.6",
                Calcium = "61.6",
                Potassium = "360.6"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 44,
                ServingSize="cup(4 oz)",
                SubItemName = "Red or White Currants, raw",
                Calories = "63",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "15.5",
                Protein = "1.6",
                Calcium = "37",
                Potassium = "308"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 45,
                ServingSize="fruit[14.3 oz with refuse](8.3 oz)",
                SubItemName = "Bullock's Heart Custard Apple, raw",
                Calories = "237",
                TotalFat = "1.4",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "59.2",
                Protein = "4",
                Calcium = "70.5",
                Potassium = "897.7"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 46,
                ServingSize="cup,chopped or diced(8.6 oz)",
                SubItemName = "Durian, raw",
                Calories = "357",
                TotalFat = "13",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "65.8",
                Protein = "3.6",
                Calcium = "14.6",
                Potassium = "1059.5"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 47,
                ServingSize="cup,pieces(5.6 oz)",
                SubItemName = "Cherimoya Custard Apple, raw",
                Calories = "118",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "6",
                TotalCarbs = "28.3",
                Protein = "2.6",
                Calcium = "12.8",
                Potassium = "430.4"


            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 48,
                ServingSize="date[0.3 oz with pits](0.3 oz)",
                SubItemName = "Deglet Noor Dates",
                Calories = "20",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "5.3",
                Protein = "0.2",
                Calcium = "2.8",
                Potassium = "46.6"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 49,
                ServingSize="date,pitted(0.8 oz)",
                SubItemName = "Medjool Dates",
                Calories = "66",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "18",
                Protein = "0.4",
                Calcium = "15.4",
                Potassium = "167"


            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 1,
                SubItemId = 50,
                ServingSize="cup(5.1 oz)",
                SubItemName = "Elderberries, raw",
                Calories = "106",
                TotalFat = "0.7",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "26.7",
                Protein = "1",
                Calcium = "55.1",
                Potassium = "406"


            });

            #endregion

            #region | Vegetables |

            this.SubItems.Add(new SubItemViewModel()
            {

                ItemId1 = 2,
                SubItemId = 1,
                ServingSize="tablespoon(0.1 oz)",
                SubItemName = "Alfalfa Sprouts, raw  ",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.1",
                Protein = "0.1",
                Calcium = "1",
                Potassium = "2.4"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 2,
                ServingSize="medium(4.2 oz)",
                SubItemName = "Globe or French Artichokes, boiled ",
                Calories = "64",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "72",
                TotalCarbs = "14.3",
                Protein = "3.5",
                Calcium = "25.2",
                Potassium = "343.2"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 3,
                ServingSize="medium[11 oz as purchased](4.4 oz)",
                SubItemName = "Globe or French Artichokes, raw",
                Calories = "59",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "118",
                TotalCarbs = "13.1",
                Protein = "4.1",
                Calcium = "55",
                Potassium = "462.5"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 4,
                ServingSize="leaf(0.1 oz)",
                SubItemName = "Arugula (Rocket, Roquette), raw ",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "0.1",
                Protein = "0.1",
                Calcium = "3.2",
                Potassium = "7.4"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 5,
                ServingSize="spear,0.5\" base dia.(0.5 oz)",
                SubItemName = "Asparagus, boiled",
                Calories = "3",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "0.6",
                Protein = "0.4",
                Calcium = "3.5",
                Potassium = "33.6"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 6,
                ServingSize="spear tip,2\" long(0.1 oz)",
                SubItemName = "Asparagus, raw",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.1",
                Protein = "0.1",
                Calcium = "0.8",
                Potassium = "7.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 7,
                ServingSize="cup,0.5\" slices(4.2 oz)",
                SubItemName = "Bamboo Shoots, boiled ",
                Calories = "14",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "2.3",
                Protein = "1.8",
                Calcium = "14.4",
                Potassium = "639.6"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 8,
                ServingSize="cup,0.5\" slices(5.3 oz)",
                SubItemName = "Bamboo Shoots, raw",
                Calories = "41",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "6",
                TotalCarbs = "7.9",
                Protein = "3.9",
                Calcium = "19.6",
                Potassium = "804.8"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 9,
                ServingSize="cup,1\" pieces(5.1 oz)",
                SubItemName = "Beet Greens, boiled",
                Calories = "39",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "34",
                TotalCarbs = "7.9",
                Protein = "3.7",
                Calcium = "164.2",
                Potassium = "1309"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 10,
                ServingSize="leaf(1.1 oz)",
                SubItemName = "Beet Greens, raw",
                Calories = "7",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "72",
                TotalCarbs = "1.4",
                Protein = "0.7",
                Calcium = "37.4",
                Potassium = "243.8",                                       
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 11,
                ServingSize="beet[4.5 oz as purchased,2\" dia.](1.8 oz)",
                SubItemName = "Beets, boiled",
                Calories = "22",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "39",
                TotalCarbs = "5",
                Protein = "0.8",
                Calcium = "8",
                Potassium = "152.5"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 12,
                ServingSize="medium(0.1 oz)",
                SubItemName = "Enoki Mushrooms, raw",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.2",
                Protein = "0.1",
                Calcium = "0",
                Potassium = "10.8"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 13,
                ServingSize="beet[4.5 oz as purchased,2\" dia.](3 oz)",
                SubItemName = "Beets, raw",
                Calories = "37",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "67",
                TotalCarbs = "8.2",
                Protein = "1.4",
                Calcium = "13.7",
                Potassium = "277.9g"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 14,
                ServingSize="cup,0.5\" pieces(4.4 oz)",
                SubItemName = "Bitter Melon (Bitter Gourd, Balsam-Pear), boiled",
                Calories = "24",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "7",
                TotalCarbs = "5.4",
                Protein = "1",
                Calcium = "11.2",
                Potassium = "395.6"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 15,
                ServingSize="pod,3\" long(0.4 oz)",
                SubItemName = "Okra (Lady's Fingers), boiled",
                Calories = "24",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "7",
                TotalCarbs = "5.4",
                Protein = "1",
                Calcium = "11.2",
                Potassium = "395.6"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 16,
                ServingSize="cup,1\" pieces(3.3 oz)",
                SubItemName = "Bitter Melon (Bitter Gourd, Balsam-Pear), raw ",
                Calories = "2",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "0.5",
                Protein = "0.2",
                Calcium = "0.8",
                Potassium = "14.3"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 17,
                ServingSize="cup(2 oz)",
                SubItemName = "Bitter Melon Leafy Tips (Bitter Gourd, Balsam-Pear), boiled ",
                Calories = "20",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "8",
                TotalCarbs = "3.99",
                Protein = "2.1",
                Calcium = "24.4",
                Potassium = "349.2"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 18,
                ServingSize="leaf(0.1 oz)",
                SubItemName = "Bitter Melon Leafy Tips (Bitter Gourd, Balsam-Pear), raw ",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.1",
                Protein = "0.2",
                Calcium = "3.4",
                Potassium = "24.3"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 19,
                ServingSize="pod(0.2 oz)",
                SubItemName = "Broad Beans (Fava), in pod, raw",
                Calories = "5",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "1.1",
                Protein = "0.5",
                Calcium = "2.3",
                Potassium = "20.3"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 20,
                ServingSize="serving,1/2 cup(1 oz)",
                SubItemName = "Brocco Sprouts, raw",
                Calories = "16",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "1.9",
                Protein = "1.4",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 21,
                ServingSize="bunch(15.4 oz)",
                SubItemName = "Broccoli Raab (Rapini), cooked",
                Calories = "144",
                TotalFat = "2.3",
                Cholestrol = "0",
                Sodium = "245",
                TotalCarbs = "14.9",
                Protein = "16.7",
                Calcium = "515.7",
                Potassium = "1498.9"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 22,
                ServingSize="stalk(0.7 oz)",
                SubItemName = "Broccoli Raab (Rapini), raw ",
                Calories = "4",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "6",
                TotalCarbs = "0.6",
                Protein = "0.6",
                Calcium = "2.1",
                Potassium = "37.2"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 23,
                ServingSize="floweret(0.4 oz)",
                SubItemName = "Broccoli Flower Clusters, raw",
                Calories = "3",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "0.6",
                Protein = "0.3",
                Calcium = "5.3",
                Potassium = "35.8"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 24,
                ServingSize="quantity(3.5 oz)",
                SubItemName = "Broccoli Leaves, raw",
                Calories = "28",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "27",
                TotalCarbs = "5.2",
                Protein = "3",
                Calcium = "48",
                Potassium = "325"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 25,
                ServingSize="stalk(4 oz)",
                SubItemName = "Broccoli Stalks, raw ",
                Calories = "32",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "31",
                TotalCarbs = "6",
                Protein = "3.4",
                Calcium = "54.7",
                Potassium = "370.5"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 26,
                ServingSize="cup,chopped(5.5 oz)",
                SubItemName = "Broccoli, boiled",
                Calories = "55",
                TotalFat = "0.6",
                Cholestrol = "0",
                Sodium = "64",
                TotalCarbs = "11.2",
                Protein = "3.7",
                Calcium = "62.4",
                Potassium = "457.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 27,
                ServingSize="cup,diced(3.1 oz)",
                SubItemName = "Broccoli, raw",
                Calories = "30",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "29",
                TotalCarbs = "5.8",
                Protein = "2.5",
                Calcium = "41.4",
                Potassium = "278.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 28,
                ServingSize="sprout(0.7 oz)",
                SubItemName = "Brussels Sprouts, boiled",
                Calories = "8",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "4",
                TotalCarbs = "1.5",
                Protein = "0.5",
                Calcium = "7.6",
                Potassium = "66.6"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 29,
                ServingSize="sprout(0.7 oz)",
                SubItemName = "Brussels Sprouts, raw",
                Calories = "8",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "1.7",
                Protein = "0.6",
                Calcium = "8",
                Potassium = "73.9"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 2,
                SubItemId = 30,
                ServingSize="cup,shredded(5.3 oz)",
                SubItemName = "Cabbage, boiled",
                Calories = "33",
                TotalFat = "0.6",
                Cholestrol = "0",
                Sodium = "12",
                TotalCarbs = "7.2",
                Protein = "1.5",
                Calcium = "4.5",
                Potassium = "145.5"
            });
           
          

           
            #endregion

            #region | Poultry |

            this.SubItems.Add(new SubItemViewModel()
            {

                ItemId1 = 3,
                SubItemId = 1,
                ServingSize="serving, 1 strip bacon + large egg(1.9 oz)",
                SubItemName = "Bacon (strip) and Fried Egg, cooked",
                Calories = "136",
                TotalFat = "10.4",
                Cholestrol = "219",
                Sodium = "279",
                TotalCarbs = "0.5",
                Protein = "9.2",
                Calcium = "0",
                Potassium = "0"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 2,
                ServingSize="serving, 1/2 egg",
                SubItemName = "Deviled Egg (large egg), cooked",
                Calories = "64",
                TotalFat = "5.4",
                Cholestrol = "107",
                Sodium = "74",
                TotalCarbs = "0.3",
                Protein = "3.1",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 3,
                ServingSize="serving",
                SubItemName = "Florentine (toast or muffin), cooked",
                Calories = "890",
                TotalFat = "59",
                Cholestrol = "420",
                Sodium = "0",
                TotalCarbs = "25",
                Protein = "65",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 4,
                ServingSize="meal",
                SubItemName = "Ham and 1 large fried egg",
                Calories = "183",
                TotalFat = "11.8",
                Cholestrol = "242",
                Sodium = "824",
                TotalCarbs = "2.4",
                Protein = "15.6",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 5,
                ServingSize="meal",
                SubItemName = "Omelet 1 large egg and 1 tsp fat, cooked",
                Calories = "133",
                TotalFat = "11.8",
                Cholestrol = "217",
                Sodium = "98",
                TotalCarbs = "0.4",
                Protein = "6.5",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 6,
                ServingSize="meal",
                SubItemName = "Omelet w. 1 large egg, 1/2 oz cheese and 1/2 oz ham, cooked",
                Calories = "154",
                TotalFat = "10.9",
                Cholestrol = "235",
                Sodium = "341",
                TotalCarbs = "1.1",
                Protein = "12.1",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 7,
                ServingSize="meal",
                SubItemName = "Omelet w. 1 large egg, 1/2 oz cheese, 1 tsp fat, cooked",
                Calories = "171",
                TotalFat = "14.2",
                Cholestrol = "227",
                Sodium = "158",
                TotalCarbs = "0.6",
                Protein = "9.8",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 8,
                ServingSize="tablespoon(0.5 oz)",
                SubItemName = "Omelet, cooked, without added fat",
                Calories = "23",
                TotalFat = "1.8",
                Cholestrol = "53",
                Sodium = "24",
                TotalCarbs = "0.1",
                Protein = "1.6",
                Calcium = "7.1",
                Potassium = "17.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 9,
                ServingSize="large egg",
                SubItemName = "Scotch Egg, cooked",
                Calories = "300",
                TotalFat = "21",
                Cholestrol = "16",
                Sodium = "0",
                TotalCarbs = "16",
                Protein = "12",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 10,
                ServingSize="meal",
                SubItemName = "Scrambled Eggs, 1 large egg w. 1 tbsp milk and 1 tsp fat",
                Calories = "123",
                TotalFat = "10",
                Cholestrol = "214",
                Sodium = "76",
                TotalCarbs = "1.1",
                Protein = "7",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 11,
                ServingSize="meal",
                SubItemName = "Scrambled Eggs, 1 large egg w. 1 tbsp non-fat milk, no added fat",
                Calories = "80",
                TotalFat = "5",
                Cholestrol = "212",
                Sodium = "78",
                TotalCarbs = "1.2",
                Protein = "7.1",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 12,
                ServingSize="meal",
                SubItemName = "Scrambled Eggs, 2 large eggs w. 1 tbsp milk and 1 tsp fat",
                Calories = "197",
                TotalFat = "15",
                Cholestrol = "426",
                Sodium = "146",
                TotalCarbs = "1.5",
                Protein = "13.5",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 13,
                ServingSize="meal",
                SubItemName = "Scrambled Eggs, 2 large eggs w. 1 tbsp non-fat milk, no added fat",
                Calories = "154",
                TotalFat = "10",
                Cholestrol = "424",
                Sodium = "148",
                TotalCarbs = "1.6",
                Protein = "13.6",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 14,
                ServingSize="cup(8 fl.oz)",
                SubItemName = "Eggnog ",
                Calories = "344",
                TotalFat = "19",
                Cholestrol = "150",
                Sodium = "137",
                TotalCarbs = "34.5",
                Protein = "9.7",
                Calcium = "331",
                Potassium = "420.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 15,
                ServingSize="cup(8 fl.oz)",
                SubItemName = "Eggnog-Flavor Drink, dry powder, prepared with whole milk",
                Calories = "258",
                TotalFat = "8.2",
                Cholestrol = "30",
                Sodium = "150",
                TotalCarbs = "38.6",
                Protein = "8",
                Calcium = "250.2",
                Potassium = "329.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 16,
                ServingSize="tablespoon(0.5 oz)",
                SubItemName = "Fat-Free Liquid or Frozen Egg Substitute",
                Calories = "7",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "30",
                TotalCarbs = "0.3",
                Protein = "1.5",
                Calcium = "11",
                Potassium = "32"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 17,
                ServingSize="tablespoon(0.3 oz)",
                SubItemName = "Egg-Substitute Powder, dry",
                Calories = "44",
                TotalFat = "1.3",
                Cholestrol = "57",
                Sodium = "79",
                TotalCarbs = "2.2",
                Protein = "5.5",
                Calcium = "32.3",
                Potassium = "73.7"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 18,
                ServingSize="egg[2.8 oz with shell](2.5 oz)",
                SubItemName = "Duck Egg, raw, fresh",
                Calories = "130",
                TotalFat = "9.6",
                Cholestrol = "619",
                Sodium = "102",
                TotalCarbs = "1",
                Protein = "9",
                Calcium = "44.8",
                Potassium = "155.4"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 19,
                ServingSize="egg[5.8 oz with shell](5.1 oz)",
                SubItemName = "Goose Egg, raw, fresh",
                Calories = "266",
                TotalFat = "19.1",
                Cholestrol = "1227",
                Sodium = "199",
                TotalCarbs = "1.9",
                Protein = "20",
                Calcium = "86.4",
                Potassium = "302.4"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 20,
                ServingSize="large egg",
                SubItemName = "Pickled Egg, cooked",
                Calories = "80",
                TotalFat = "5.5",
                Cholestrol = "210",
                Sodium = "0",
                TotalCarbs = "0",
                Protein = "7.5",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 21,
                ServingSize="egg(0.3 oz)",
                SubItemName = "Quail Egg, fresh, raw",
                Calories = "14",
                TotalFat = "1",
                Cholestrol = "76",
                Sodium = "13",
                TotalCarbs = "0.1",
                Protein = "1.2",
                Calcium = "5.8",
                Potassium = "11.9"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 22,
                ServingSize="egg[3.2 oz with shell](2.8 oz)",
                SubItemName = "Turkey Egg, raw, fresh",
                Calories = "135",
                TotalFat = "9.4",
                Cholestrol = "737",
                Sodium = "119",
                TotalCarbs = "0.9",
                Protein = "10.8",
                Calcium = "78.2",
                Potassium = "112.2"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 23,
                ServingSize="large(1.2 oz)",
                SubItemName = "Egg White, cooked, without added fat",
                Calories = "17",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "55",
                TotalCarbs = "0.2",
                Protein = "3.6",
                Calcium = "2.3",
                Potassium = "53.8"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 24,
                ServingSize="tablespoon(0.5 oz)",
                SubItemName = "Egg White, dry powder, glucose reduced",
                Calories = "53",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "173",
                TotalCarbs = "0.6",
                Protein = "11.5",
                Calcium = "12.5",
                Potassium = "156.2"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 25,
                ServingSize="large egg",
                SubItemName = "Egg White, hard-boiled",
                Calories = "17",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "50",
                TotalCarbs = "0.2",
                Protein = "3.6",
                Calcium = "0",
                Potassium = "51"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 26,
                ServingSize="large(1.2 oz)",
                SubItemName = "Egg White, raw",
                Calories = "17",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "55",
                TotalCarbs = "0.2",
                Protein = "3.6",
                Calcium = "2.3",
                Potassium = "53.8"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 3,
                SubItemId = 27,
                ServingSize="portion(3.5 oz)",
                SubItemName = "Egg White, raw, frozen",
                Calories = "47",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "158",
                TotalCarbs = "1.1",
                Protein = "9.8",
                Calcium = "7",
                Potassium = "136"
            });
            #endregion

            #region | Chicken |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 1,
                ServingSize="wing[2.3 oz with bone](0.7 oz)",
                SubItemName = "Roasted Chicken Wing, without skin",
                Calories = "43",
                TotalFat = "1.7",
                Cholestrol = "18",
                Sodium = "19",
                TotalCarbs = "0",
                Protein = "6.4",
                Calcium = "3.4",
                Potassium = "44.1"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 2,
                ServingSize="portion(4 oz)",
                SubItemName = "Batter-dipped and Fried Chicken Breast, with skin",
                Calories = "294",
                TotalFat = "14.9",
                Cholestrol = "96",
                Sodium = "311",
                TotalCarbs = "10.2",
                Protein = "28.1",
                Calcium = "22.6",
                Potassium = "227.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 3,
                ServingSize="single breast[4.2 oz with bone](3.5 oz)",
                SubItemName = "Flour-coated and Fried Chicken Breast, with skin",
                Calories = "218",
                TotalFat = "8.7",
                Cholestrol = "87",
                Sodium = "74",
                TotalCarbs = "1.6",
                Protein = "31.2",
                Calcium = "15.7",
                Potassium = "253.8"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 4,
                ServingSize="portion(4 oz)",
                SubItemName = "Breast, with skin, raw",
                Calories = "194",
                TotalFat = "10.5",
                Cholestrol = "72",
                Sodium = "71",
                TotalCarbs = "0",
                Protein = "23.6",
                Calcium = "12.4",
                Potassium = "248.6"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 5,
                ServingSize="single breast[4.3 oz with bone](3.5 oz)",
                SubItemName = "Roasted Chicken Breast, with skin",
                Calories = "193",
                TotalFat = "7.6",
                Cholestrol = "82",
                Sodium = "70",
                TotalCarbs = "0",
                Protein = "29.2",
                Calcium = "13.7",
                Potassium = "240.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 6,
                ServingSize="breast(12.1 oz)",
                SubItemName = "Rotisserie Chicken Breast, with skin, with original seasoning",
                Calories = "631",
                TotalFat = "28.1",
                Cholestrol = "329",
                Sodium = "1190",
                TotalCarbs = "0.1",
                Protein = "94.3",
                Calcium = "51.5",
                Potassium = "991.3"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 7,
                ServingSize="single breast[4.7 oz with bone](3.9 oz)",
                SubItemName = "stewed Chicken Breast, with skin",
                Calories = "202",
                TotalFat = "8.2",
                Cholestrol = "83",
                Sodium = "68",
                TotalCarbs = "0",
                Protein = "30.1",
                Calcium = "14.3",
                Potassium = "195.8"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 8,
                ServingSize="portion(4 oz)",
                SubItemName = "Chicken Breast, without skin, raw",
                Calories = "124",
                TotalFat = "1.4",
                Cholestrol = "66",
                Sodium = "73",
                TotalCarbs = "0",
                Protein = "26.1",
                Calcium = "12.4",
                Potassium = "288.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 9,
                ServingSize="breast(12.2 oz)",
                SubItemName = "Rotisserie Chicken Breast, without skin, with original seasoning",
                Calories = "142",
                TotalFat = "3.1",
                Cholestrol = "73",
                Sodium = "64",
                TotalCarbs = "0",
                Protein = "26.7",
                Calcium = "12.9",
                Potassium = "220.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 10,
                ServingSize="single breast[4.8 oz with bone and skin](3.4 oz)",
                SubItemName = "Stewed Chicken Breast, without skin",
                Calories = "143",
                TotalFat = "2.9",
                Cholestrol = "73",
                Sodium = "60",
                TotalCarbs = "0",
                Protein = "27.5",
                Calcium = "12.4",
                Potassium = "177.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 11,
                ServingSize="serving (2 oz)",
                SubItemName = " Boar's Head Breast, Hickory Smoked",
                Calories = "60",
                TotalFat = "0.5",
                Cholestrol = "35",
                Sodium = "360",
                TotalCarbs = "0",
                Protein = "13",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 12,
                ServingSize="portion(4 oz)",
                SubItemName = "Roasted Capons, with skin",
                Calories = "259",
                TotalFat = "13.2",
                Cholestrol = "97",
                Sodium = "55",
                TotalCarbs = "0",
                Protein = "32.7",
                Calcium = "15.8",
                Potassium = "288.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 13,
                ServingSize="portion(4 oz)",
                SubItemName = "Batter-dipped and Fried Chicken Dark Meat, with skin",
                Calories = "337",
                TotalFat = "21.1",
                Cholestrol = "101",
                Sodium = "333",
                TotalCarbs = "10.6",
                Protein = "24.7",
                Calcium = "23.7",
                Potassium = "209.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 14,
                ServingSize="portion(4 oz)",
                SubItemName = "Flour-coated and Fried Chicken Dark Meat, with skin",
                Calories = "322",
                TotalFat = "19.1",
                Cholestrol = "104",
                Sodium = "101",
                TotalCarbs = "4.6",
                Protein = "30.8",
                Calcium = "19.2",
                Potassium = "259.9"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 15,
                ServingSize="portion(4 oz)",
                SubItemName = "Chicken Dark Meat, with skin, raw",
                Calories = "268",
                TotalFat = "20.7",
                Cholestrol = "92",
                Sodium = "82",
                TotalCarbs = "0",
                Protein = "18.9",
                Calcium = "12.4",
                Potassium = "201.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 16,
                ServingSize="portion(4 oz)",
                SubItemName = "Roasted Chicken Dark Meat, with skin",
                Calories = "286",
                TotalFat = "17.8",
                Cholestrol = "103",
                Sodium = "98",
                TotalCarbs = "0",
                Protein = "29.3",
                Calcium = "17",
                Potassium = "248.6"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 17,
                ServingSize="portion(4 oz)",
                SubItemName = "Stewed Chicken Dark Meat, with skin",
                Calories = "263",
                TotalFat = "16.6",
                Cholestrol = "93",
                Sodium = "79",
                TotalCarbs = "0",
                Protein = "26.6",
                Calcium = "15.8",
                Potassium = "187.6"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 18,
                ServingSize="portion (4 oz)",
                SubItemName = "Chicken Dark Meat, without skin, raw",
                Calories = "141",
                TotalFat = "4.9",
                Cholestrol = "90",
                Sodium = "96",
                TotalCarbs = "0",
                Protein = "22.7",
                Calcium = "13.6",
                Potassium = "250.9"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 19,
                ServingSize="portion (4 oz)",
                SubItemName = "Roasted Chicken Dark Meat, without skin",
                Calories = "232",
                TotalFat = "11",
                Cholestrol = "105",
                Sodium = "205",
                TotalCarbs = "0",
                Protein = "30.9",
                Calcium = "17",
                Potassium = "271.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 20,
                ServingSize="portion(4 oz)",
                SubItemName = "Stewed Chicken Dark Meat, without skin",
                Calories = "217",
                TotalFat = "10.1",
                Cholestrol = "99",
                Sodium = "84",
                TotalCarbs = "0",
                Protein = "29.3",
                Calcium = "15.8",
                Potassium = "204.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 21,
                ServingSize="portion (4 oz)",
                SubItemName = "Batter-dipped and Fried Chicken Dark Meat, with skin",
                Calories = "337",
                TotalFat = "21.1",
                Cholestrol = "101",
                Sodium = "333",
                TotalCarbs = "10.6",
                Protein = "24.7",
                Calcium = "23.7",
                Potassium = "209.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 22,
                ServingSize="portion(4 oz)",
                SubItemName = "Flour-coated and Fried Chicken Dark Meat, with skin",
                Calories = "322",
                TotalFat = "19.1",
                Cholestrol = "104",
                Sodium = "101",
                TotalCarbs = "4.6",
                Protein = "30.8",
                Calcium = "19.2",
                Potassium = "259.9"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 23,
                ServingSize="drumstick[3.8 oz with bone](2.6 oz)",
                SubItemName = "Drumstick, with skin, raw",
                Calories = "118",
                TotalFat = "6.3",
                Cholestrol = "59",
                Sodium = "61",
                TotalCarbs = "0",
                Protein = "14.1",
                Calcium = "8",
                Potassium = "150.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 24,
                ServingSize="portion (4 oz)",
                SubItemName = "Roasted Chicken Leg, without skin",
                Calories = "216",
                TotalFat = "9.5",
                Cholestrol = "106",
                Sodium = "103",
                TotalCarbs = "0",
                Protein = "30.5",
                Calcium = "13.6",
                Potassium = "273.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 25,
                ServingSize="drumstick[3.8 oz with bone and skin](2.2 oz)",
                SubItemName = "Stewed Chicken Drumstick, with skin",
                Calories = "116",
                TotalFat = "6.1",
                Cholestrol = "47",
                Sodium = "43",
                TotalCarbs = "0",
                Protein = "14.4",
                Calcium = "6.3",
                Potassium = "104.9"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 4,
                SubItemId = 25,
                ServingSize="drumstick[3.8 oz with bone andskin](2.2 oz)",
                SubItemName = "Chicken Drumstick, without skin, raw",
                Calories = "74",
                TotalFat = "2.1",
                Cholestrol = "48",
                Sodium = "55",
                TotalCarbs = "0",
                Protein = "12.8",
                Calcium = "6.8",
                Potassium = "140.1"

            }); 

            #endregion

            #region | Sausages |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 1,
                ServingSize="sausage(1.5 oz)",
                SubItemName = "Smoked Cured Beef Sausage",
                Calories = "134",
                TotalFat = "11.6",
                Cholestrol = "29",
                Sodium = "486",
                TotalCarbs = "1",
                Protein = "6.1",
                Calcium = "3",
                Potassium = "75.7"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 2,
                ServingSize="sausage(1.5 oz)",
                SubItemName = "Fresh Beef Sausage, cooked",
                Calories = "143",
                TotalFat = "12",
                Cholestrol = "35",
                Sodium = "280",
                TotalCarbs = "0.2",
                Protein = "7.8",
                Calcium = "4.7",
                Potassium = "110.9"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 3,
                ServingSize="sausage(1.7 oz)",
                SubItemName = "Pre-cooked Beef Sausage",
                Calories = "194",
                TotalFat = "18",
                Cholestrol = "40",
                Sodium = "437",
                TotalCarbs = "0.1",
                Protein = "7.4",
                Calcium = "7.2",
                Potassium = "112.3"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 4,
                ServingSize="slice(0.9 oz)",
                SubItemName = "Blood Sausage",
                Calories = "95",
                TotalFat = "396",
                Cholestrol = "30",
                Sodium = "170",
                TotalCarbs = "0.3",
                Protein = "3.7",
                Calcium = "1.5",
                Potassium = "9.5"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 5,
                ServingSize="sausage(3.2 oz)",
                SubItemName = " Pork or Veal Bockwurst, raw",
                Calories = "253",
                TotalFat = "23.5",
                Cholestrol = "85",
                Sodium = "452",
                TotalCarbs = "0.5",
                Protein = "9.9",
                Calcium = "37.3",
                Potassium = "207.5"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 6,
                ServingSize="link(1.5 oz)",
                SubItemName = "Pork or Beef Cheese Smokie Cheesefurter",
                Calories = "141",
                TotalFat = "12.5",
                Cholestrol = "29",
                Sodium = "465",
                TotalCarbs = "0.6",
                Protein = "6.1",
                Calcium = "24.9",
                Potassium = "88.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 7,
                ServingSize="link,4\" long(2.1 oz)",
                SubItemName = "Pork and Beef Chorizo",
                Calories = "273",
                TotalFat = "23",
                Cholestrol = "53",
                Sodium = "741",
                TotalCarbs = "1.1",
                Protein = "14.5",
                Calcium = "4.8",
                Potassium = "238.8"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 8,
                ServingSize="frankfurter,5\" longx0.75\"dia(1.8 oz)",
                SubItemName = "Beef Frankfurter",
                Calories = "165",
                TotalFat = "14.8",
                Cholestrol = "27",
                Sodium = "570",
                TotalCarbs = "2",
                Protein = "6",
                Calcium = "7",
                Potassium = "78"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 9,
                ServingSize="frankfurter(1.6 oz)",
                SubItemName = "Beef and Pork Frankfurter",
                Calories = "137",
                TotalFat = "12.4",
                Cholestrol = "23",
                Sodium = "504",
                TotalCarbs = "0.8",
                Protein = "5.2",
                Calcium = "5",
                Potassium = "75.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 10,
                ServingSize="frankfurter(1.6 oz)",
                SubItemName = "Chicken Frankfurter ",
                Calories = "116",
                TotalFat = "8.8",
                Cholestrol = "45",
                Sodium = "617",
                TotalCarbs = "3.1",
                Protein = "5.8",
                Calcium = "42.8",
                Potassium = "37.8"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 11,
                ServingSize="frankfurter(1.6 oz)",
                SubItemName = "Turkey Frankfurter",
                Calories = "102",
                TotalFat = "8",
                Cholestrol = "48",
                Sodium = "642",
                TotalCarbs = "0.7",
                Protein = "6.4",
                Calcium = "47.7",
                Potassium = "80.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 12,
                ServingSize="slice,4\" diax0.13\"thick(0.8 oz)",
                SubItemName = "Beef Honey Roll Sausage",
                Calories = "42",
                TotalFat = "2.4",
                Cholestrol = "12",
                Sodium = "304",
                TotalCarbs = "0.5",
                Protein = "4.3",
                Calcium = "2.1",
                Potassium = "66.9"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 13,
                ServingSize="link(2.4 oz)",
                SubItemName = "Italian Pork Sausage, cooked ",
                Calories = "230",
                TotalFat = "18.3",
                Cholestrol = "38",
                Sodium = "809",
                TotalCarbs = "2.9",
                Protein = "12.8",
                Calcium = "14.1",
                Potassium = "203.7"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 14,
                ServingSize="link(3.2 oz)",
                SubItemName = "Italian Pork Sausage, raw",
                Calories = "315",
                TotalFat = "28.5",
                Cholestrol = "69",
                Sodium = "665",
                TotalCarbs = "0.6",
                Protein = "13",
                Calcium = "16.4",
                Potassium = "230.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 15,
                ServingSize="slice(0.4 oz)",
                SubItemName = "Smoked Turkey and Beef Polish Kielbasa",
                Calories = "23",
                TotalFat = "1.8",
                Cholestrol = "7",
                Sodium = "120",
                TotalCarbs = "0.4",
                Protein = "1.3",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 16,
                ServingSize="slice,2.5\"dia x 0.25\"thick(0.6 oz)",
                SubItemName = "Pork Liverwurst (Liver Sausage)",
                Calories = "59",
                TotalFat = "5.1",
                Cholestrol = "28",
                Sodium = "155",
                TotalCarbs = "0.4",
                Protein = "2.5",
                Calcium = "4.7",
                Potassium = "30.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 17,
                ServingSize="sausage,10\" long x 1.25\" dia(8 oz)",
                SubItemName = "Polish Pork Sausage",
                Calories = "740",
                TotalFat = "65.2",
                Cholestrol = "159",
                Sodium = "1989",
                TotalCarbs = "3.7",
                Protein = "32",
                Calcium = "27.2",
                Potassium = "538"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 18,
                ServingSize="slice,4\" dia x 0.1\" thick(0.8 oz)",
                SubItemName = "Pork and Beef Luncheon Sausage ",
                Calories = "60",
                TotalFat = "4.8",
                Cholestrol = "15",
                Sodium = "272",
                TotalCarbs = "0.4",
                Protein = "3.5",
                Calcium = "3",
                Potassium = "56.4"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 19,
                ServingSize="link[raw:4\" long x 0.9\" dia](0.5 oz)",
                SubItemName = "Pork and Beef Sausage, fresh, cooked",
                Calories = "51",
                TotalFat = "4.7",
                Cholestrol = "9",
                Sodium = "105",
                TotalCarbs = "0.4",
                Protein = "1.8",
                Calcium = "1.3",
                Potassium = "24.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 5,
                SubItemId = 20,
                ServingSize="piece,4\" long x 1.1\" dia(2.4 oz)",
                SubItemName = "Smoked Pork and Beef Sausage",
                Calories = "218",
                TotalFat = "19.5",
                Cholestrol = "39",
                Sodium = "619",
                TotalCarbs = "1.6",
                Protein = "8.2",
                Calcium = "8.2",
                Potassium = "121.7"
            }); 
            #endregion

            #region | Seafoods |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,                 
                SubItemId = 1,
                ServingSize="anchovy(0.1 oz)",
                SubItemName = "Anchovy, canned in oil, drained ",
                Calories = "8",
                TotalFat = "0.4",
                Cholestrol = "3",
                Sodium = "147",
                TotalCarbs = "0",
                Protein = "1.2",
                Calcium = "9.3",
                Potassium = "21.8"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 2,  
                ServingSize="can(3 oz)",              
                SubItemName = "Cod, Atlantic, canned",
                Calories = "89",
                TotalFat = "0.7",
                Cholestrol = "47",
                Sodium = "185",
                TotalCarbs = "0",
                Protein = "448.8",
                Calcium = "17.9",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 3,
                ServingSize="cube,1\"(0.6 oz)",
                SubItemName = "Pacific or Jack Mackerel, cooked with dry heat",
                Calories = "34",
                TotalFat = "1.7",
                Cholestrol = "10",
                Sodium = "19",
                TotalCarbs = "0",
                Protein = "4.4",
                Calcium = "4.9",
                Potassium = "88.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 4,
                ServingSize="can,drained(13 oz)",
                SubItemName = "Salmon,Chum, with bone,canned, without salt",
                Calories = "520",
                TotalFat = "20.3",
                Cholestrol = "144",
                Sodium = "277",
                TotalCarbs = "0",
                Protein = "79.1",
                Calcium = "918.8",
                Potassium = "1107"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 5,
                ServingSize="can,drained(4 oz)",
                SubItemName = "Salmon, King(Chinook), smoked and canned ",
                Calories = "170",
                TotalFat = "6.7",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "1.1",
                Protein = "26.2",
                Calcium = "67.8",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 6,
                ServingSize="can,drained(11.1 oz)",
                SubItemName = "Salmon, Pink, canned, drained",
                Calories = "428",
                TotalFat = "15.2",
                Cholestrol = "258",
                Sodium = "1257",
                TotalCarbs = "3.2",
                Protein = "72.1",
                Calcium = "872.6",
                Potassium = "979.7"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 7,
                ServingSize="can(14.5 oz)",
                SubItemName = "Salmon, Pink, canned, undrained",
                Calories = "571",
                TotalFat = "24.9",
                Cholestrol = "226",
                Sodium = "2277",
                TotalCarbs = "0",
                Protein = "81.3",
                Calcium = "87.5",
                Potassium = "1339.9"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 8,
                ServingSize="can(11.9 oz)",
                SubItemName = "Salmon, Red (Sockeye),canned,drained ",
                Calories = "559",
                TotalFat = "24.6",
                Cholestrol = "148",
                Sodium = "1213",
                TotalCarbs = "0",
                Protein = "78.6",
                Calcium = "744.8",
                Potassium = "970.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 9,
                ServingSize="can(13 oz)",
                SubItemName = "Red Salmon (Sockeye), with bone, canned, without salt, drained",
                Calories = "565",
                TotalFat = "27",
                Cholestrol = "162",
                Sodium = "277",
                TotalCarbs = "0",
                Protein = "75.5",
                Calcium = "881.9",
                Potassium = "1391.1"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 10,
                ServingSize="sardine,2.6\"x0.5\"x0.25\"(0.4 oz)",
                SubItemName = " Sardines, with bone, canned in oil, drained",
                Calories = "25",
                TotalFat = "1.4",
                Cholestrol = "17",
                Sodium = "61",
                TotalCarbs = "0",
                Protein = "3",
                Calcium = "45.8",
                Potassium = "47.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 11,
                ServingSize="can(6.3 oz)",
                SubItemName = " White Tuna (Albacore), canned in oil, drained",
                Calories = "331",
                TotalFat = "14.4",
                Cholestrol = "55",
                Sodium = "705",
                TotalCarbs = "0",
                Protein = "47.2",
                Calcium = "7.1",
                Potassium = "592.7"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 12,
                ServingSize="cup(5.6 oz)",
                SubItemName = "Clam, canned, liquid only",
                Calories = "5",
                TotalFat = "0.1",
                Cholestrol = "7",
                Sodium = "516",
                TotalCarbs = "0.2",
                Protein = "1",
                Calcium = "31.2",
                Potassium = "357.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 13,
                ServingSize="can[6.5 oz], drained(4.4 oz)",
                SubItemName = "Crab, Blue, canned ",
                Calories = "124",
                TotalFat = "1.5",
                Cholestrol = "111",
                Sodium = "416",
                TotalCarbs = "0",
                Protein = "25.7",
                Calcium = "126.3",
                Potassium = "467.5"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 14,
                ServingSize="shrimp (0.1 oz)",
                SubItemName = "Shrimp, canned",
                Calories = "3",
                TotalFat = "0.1",
                Cholestrol = "8",
                Sodium = "25",
                TotalCarbs = "0",
                Protein = "0.7",
                Calcium = "4.6",
                Potassium = "2.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 15,
                ServingSize="serving(4 oz)",
                SubItemName = "Bass, Sea, raw",
                Calories = "110",
                TotalFat = "2.3",
                Cholestrol = "46",
                Sodium = "77",
                TotalCarbs = "0",
                Protein = "20.8",
                Calcium = "11.3",
                Potassium = "289.3"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 16,
                ServingSize="serving(4 oz)",
                SubItemName = "Bluefish, cooked with dry heat ",
                Calories = "180",
                TotalFat = "6.1",
                Cholestrol = "86",
                Sodium = "87",
                TotalCarbs = "0",
                Protein = "29",
                Calcium = "10.2",
                Potassium = "539"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 17,
                ServingSize="fillet(1.1 oz)",
                SubItemName = "Butterfish, raw",
                Calories = "47",
                TotalFat = "2.6",
                Cholestrol = "21",
                Sodium = "28",
                TotalCarbs = "0",
                Protein = "5.5",
                Calcium = "7",
                Potassium = "120"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 18,
                ServingSize="serving(4 oz)",
                SubItemName = "Carp, cooked with dry heat",
                Calories = "183",
                TotalFat = "8.1",
                Cholestrol = "95",
                Sodium = "71",
                TotalCarbs ="0",
                Protein = "25.8",
                Calcium = "58.8",
                Potassium = "482.5"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 19,
                 ServingSize="serving(4 oz)",
                SubItemName = "Carp, raw ",
                Calories = "144",
                TotalFat = "6.3",
                Cholestrol = "75",
                Sodium = "55",
                TotalCarbs = "0",
                Protein = "20.1",
                Calcium = "46.3",
                Potassium = "376.3"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 6,
                SubItemId = 20,
                 ServingSize="serving(4 oz)",
                SubItemName = "Catfish, Wild, cooked with dry heat ",
                Calories = "119",
                TotalFat = "3.2",
                Cholestrol = "81",
                Sodium = "57",
                TotalCarbs = "0",
                Protein = "20.9",
                Calcium = "12.4",
                Potassium = "473.5"
            }); 
            #endregion

            #region| Cakes |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 1,
                ServingSize="serving(0.9 oz)",
                SubItemName = "Arrowhead Mills Bake With Me Organic Brownie Mix, dry",
                Calories = "90",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "45",
                TotalCarbs = "21",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"
            
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 2,
                ServingSize="brownie",
                SubItemName = "Arrowhead Mills Bake With Me Organic Brownie Mix, prepared as directed",
                Calories = "150",
                TotalFat = "7.5",
                Cholestrol = "20",
                Sodium = "60",
                TotalCarbs = "21",
                Protein = "2",
                Calcium = "20",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 3,
                ServingSize="serving (1.2 oz)",
                SubItemName = "Arrowhead Mills Bake With Me Gluten Free Chocolate Cupcake Mix, dry",
                Calories = "120",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "120",
                TotalCarbs = "27",
                Protein = "2",
                Calcium = "40",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 4,
                ServingSize="cupcake",
                SubItemName = "Arrowhead Mills Bake With Me Gluten Free Chocolate Cupcake Mix, prepared as directed",
                Calories = "180",
                TotalFat = "7",
                Cholestrol = "15",
                Sodium = "130",
                TotalCarbs = "27",
                Protein = "2",
                Calcium = "60",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 5,
                ServingSize="serving(1.1 oz)",
                SubItemName = "Arrowhead Mills Bake With Me Organic Cupcake Mix, dry",
                Calories = "120",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "110",
                TotalCarbs = "27",
                Protein = "2",
                Calcium = "40",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 6,
                ServingSize="serving(0.9 oz)",
                SubItemName = "Arrowhead Mills Gluten Free Brownie Mix, dry",
                Calories = "110",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "40",
                TotalCarbs = "21",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 7,
                ServingSize="serving(1.6 oz)",
                SubItemName = "Arrowhead Mills Organic Chocolate Cake Mix, dry",
                Calories = "160",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "190",
                TotalCarbs = "37",
                Protein = "3",
                Calcium = "40",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 8,
                ServingSize="slice,1/12 cake",
                SubItemName = "Arrowhead Mills Organic Chocolate Cake Mix, prepared as directed",
                Calories = "260",
                TotalFat = "11",
                Cholestrol = "35",
                Sodium = "225",
                TotalCarbs = "38",
                Protein = "3",
                Calcium = "80",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 9,
                ServingSize="serving(1.5 oz)",
                SubItemName = "Arrowhead Mills Organic Vanilla Cake Mix, dry",
                Calories = "160",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "140",
                TotalCarbs = "37",
                Protein = "2",
                Calcium = "40",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 10,
                ServingSize="serving, 1/12 package(1.3 oz)",
                SubItemName = "Betty Crocker Angel Food White Cake Mix, dry",
                Calories = "140",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "310",
                TotalCarbs = "32",
                Protein = "2",
                Calcium = "40",
                Potassium = "35"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 11,
                ServingSize="serving, 1/16 package(1.2 oz)",
                SubItemName = " Betty Crocker Supreme Bars Cookie Brownie Mix, dry",
                Calories = "140",
                TotalFat = "2.5",
                Cholestrol = "0",
                Sodium = "130",
                TotalCarbs = "28",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 12,
                ServingSize="serving, 1/10 package(1.5 oz)",
                SubItemName = " Betty Crocker SuperMoist Carrot Cake Mix, dry",
                Calories = "160",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "310",
                TotalCarbs = "35",
                Protein = "2",
                Calcium = "100",
                Potassium = "25"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 13,
                ServingSize="serving, 1/10 package(1.5 oz)",
                SubItemName = "Betty Crocker SuperMoist Butter Recipe Chocolate Cake Mix, prepared as directed",
                Calories = "240",
                TotalFat = "9",
                Cholestrol = "60",
                Sodium = "420",
                TotalCarbs = "35",
                Protein = "4",
                Calcium = "80",
                Potassium = "120"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 14,
                ServingSize="bowl(3.1 oz)",
                SubItemName = " Betty Crocker Warm Delights Creamy Milk Chocolate Cake Mix, dry",
                Calories = "340",
                TotalFat = "10",
                Cholestrol = "0",
                Sodium = "450",
                TotalCarbs = "59",
                Protein = "5",
                Calcium = "100",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 15,
                ServingSize="bowl(1.2 oz)",
                SubItemName = "Betty Crocker Warm Delights Mini Molten Caramel Cake Mix, dry",
                Calories = "150",
                TotalFat = "4",
                Cholestrol = "0",
                Sodium = "180",
                TotalCarbs = "26",
                Protein = "2",
                Calcium = "20",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 16,
                ServingSize="serving, dry mix(1 oz)",
                SubItemName = "Doctor's CarbRite Diet Brownies with Chocolate Chips, dry mix",
                Calories = "88",
                TotalFat = "3",
                Cholestrol = "2",
                Sodium = "36",
                TotalCarbs = "19.5",
                Protein = "3",
                Calcium = "50",
                Potassium = "136"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 7,
                SubItemId = 17,
                ServingSize="serving, 1/12 package(1.4 oz)",
                SubItemName = " Dr Oetker Organic Marble Cake Mix, dry",
                Calories = "140",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "290",
                TotalCarbs = "33",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"

            }); 
            #endregion

            #region | Meats |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 1,
                ServingSize="oz raw meat with refuse, yeild (0.7 oz)",
                SubItemName = "Brisket, lean and 1/8 fat, braised",
                Calories = "68",
                TotalFat = "5",
                Cholestrol = "19",
                Sodium = "13",
                TotalCarbs = "0",
                Protein = "5.3",
                Calcium = "1.4",
                Potassium = "51.7"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 2,
                ServingSize="oz raw meat with refuse, yeild (0.6 oz)",
                SubItemName = "Brisket, lean only, braised",
                Calories = "39",
                TotalFat = "1.4",
                Cholestrol = "19",
                Sodium = "8",
                TotalCarbs = "0",
                Protein = "6.2",
                Calcium = "1.3",
                Potassium = "50.3"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 3,
                ServingSize="oz raw meat, yeild (0.5 oz)",
                SubItemName = "Beef Chuck Arm Pot Roast, lean and 1/8\" fat, braised ",
                Calories = "50",
                TotalFat = "3.2",
                Cholestrol = "13",
                Sodium = "8",
                TotalCarbs = "0",
                Protein = "4.9",
                Calcium = "2.6",
                Potassium = "38.8"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 4,
                ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Beef Chuck, Arm Pot Roast,lean only,braised",
                Calories = "43",
                TotalFat = "1.6",
                Cholestrol = "15",
                Sodium = "11",
                TotalCarbs = "0",
                Protein = "6.8",
                Calcium = "2.8",
                Potassium = "53.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 5,
                ServingSize="oz raw meat with bone, yeild (0.5 oz)",
                SubItemName = "Beef Chuck Blade Roast, lean and 1/8\", fat, braised ",
                Calories = "53",
                TotalFat = "3.9",
                Cholestrol = "16",
                Sodium = "10",
                TotalCarbs = "0",
                Protein = "4.1",
                Calcium = "2",
                Potassium = "35.9"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 6,
                ServingSize="oz raw meat with refuse, yeild (0.4 oz)",
                SubItemName = "Beef Chuck, Blade Roast, lean only, braised",
                Calories = "30",
                TotalFat = "1.6",
                Cholestrol = "13",
                Sodium = "8",
                TotalCarbs = "0",
                Protein = "3.7",
                Calcium = "1.5",
                Potassium = "31.3"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 7,
                 ServingSize="oz raw meat with refuse, yeild (0.5 oz)",
                SubItemName = "Beef Flank Steak, lean only, braised",
                Calories = "36",
                TotalFat = "2g",
                Cholestrol = "11",
                Sodium = "11",
                TotalCarbs = "0",
                Protein = "4.3",
                Calcium = "0.9",
                Potassium = "54.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 8,
                 ServingSize="serving (4 oz)",
                SubItemName = "Beef Flank Steak, lean only, broiled",
                Calories = "219",
                TotalFat = "9.4",
                Cholestrol = "62",
                Sodium = "63",
                TotalCarbs = "0",
                Protein = "31.4",
                Calcium = "17",
                Potassium = "381.9"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 9,
                ServingSize="oz raw meat, yeild (0.6 oz)",
                SubItemName = "Ground Beef, 70% lean 30% fat, pan-browned",
                Calories = "47",
                TotalFat = "3.1",
                Cholestrol = "15",
                Sodium = "17",
                TotalCarbs = "0",
                Protein = "4.4",
                Calcium = "7.1",
                Potassium = "57.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 10,
                 ServingSize="patty(2.5 oz)",
                SubItemName = "Ground Beef patty, 70% lean 30% fat, broiled",
                Calories = "191",
                TotalFat = "12.8",
                Cholestrol = "57",
                Sodium = "57",
                TotalCarbs = "0",
                Protein = "17.8",
                Calcium = "24.5",
                Potassium = "192.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 11,
                ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Ground Beef, 80% lean 20% fat, pan-browned",
                Calories = "51",
                TotalFat = "3.2",
                Cholestrol = "17",
                Sodium = "17",
                TotalCarbs = "0",
                Protein = "5",
                Calcium = "5.2",
                Potassium = "70.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 12,
                 ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Ground Beef patty, 80% lean 20% fat, broiled",
                Calories = "52",
                TotalFat = "3.4",
                Cholestrol = "18",
                Sodium = "14",
                TotalCarbs = "0",
                Protein = "5g",
                Calcium = "4.6",
                Potassium = "58.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 13,
                 ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Ground, 85% lean 15% fat, pan-browned",
                Calories = "48",
                TotalFat = "2.8",
                Cholestrol = "17",
                Sodium = "17",
                TotalCarbs = "0",
                Protein = "5.2",
                Calcium = "4.1",
                Potassium = "75.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 14,
                 ServingSize="serving (4 oz)",
                SubItemName = "Ground Beef, 85% lean 15% fat, raw",
                Calories = "243",
                TotalFat = "17",
                Cholestrol = "77",
                Sodium = "75",
                TotalCarbs = "0",
                Protein = "21",
                Calcium = "17",
                Potassium = "333.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 15,
                 ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Ground Beef, 95% lean 5% fat, pan-browned",
                Calories = "37",
                TotalFat = "1.5",
                Cholestrol = "17",
                Sodium = "16",
                TotalCarbs = "0",
                Protein = "5.6",
                Calcium = "1.7",
                Potassium = "88.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 16,
                 ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Ground Beef patty, 95% lean 5% fat, broiled",
                Calories = "35",
                TotalFat = "1.3",
                Cholestrol = "16",
                Sodium = "13",
                TotalCarbs = "0",
                Protein = "5.4",
                Calcium = "1.4",
                Potassium = "71.3"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 17,
                 ServingSize="oz raw meat, yeild (0.7 oz)",
                SubItemName = "Ground, Patties, frozen, broiled",
                Calories = "55",
                TotalFat = "3.9",
                Cholestrol = "18",
                Sodium = "15",
                TotalCarbs = "0",
                Protein = "4.8",
                Calcium = "2.2",
                Potassium = "57.6"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 18,
                 ServingSize="oz raw meat with refuse, yeild (0.6 oz)",
                SubItemName = "Beef Porterhouse Steak, lean and 1/8\" fat,broiled",
                Calories = "53",
                TotalFat = "3.9",
                Cholestrol = "13",
                Sodium = "11",
                TotalCarbs = "0",
                Protein = "4.2",
                Calcium = "1.4",
                Potassium = "57.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 19,
                 ServingSize="serving (4 oz)",
                SubItemName = "Beef Porterhouse Steak, lean only, broiled",
                Calories = "219",
                TotalFat = "10",
                Cholestrol = "66",
                Sodium = "78",
                TotalCarbs = "0",
                Protein = "30.4",
                Calcium = "6.8",
                Potassium = "414.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 20,
                ServingSize="oz raw meat with bone, yeild (0.6 oz)",
                SubItemName = "Beef Rib (ribs 6-12), lean and 1/4\" fat, roasted",
                Calories = "64",
                TotalFat = "5.1",
                Cholestrol = "15",
                Sodium = "12",
                TotalCarbs = "0",
                Protein = "4.1",
                Calcium = "2",
                Potassium = "55.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 8,
                SubItemId = 21,
                ServingSize="oz raw meat with refuse, yeild (0.5 oz)",
                SubItemName = "Rib (ribs 6-12), lean only, roasted",
                Calories = "32",
                TotalFat = "1.8",
                Cholestrol = "11",
                Sodium = "10",
                TotalCarbs = "0",
                Protein = "3.7",
                Calcium = "1.1",
                Potassium = "48.2"

            });
            #endregion

            #region | Soup and Tofu |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 1,
                ServingSize="portion(1 oz)",
                SubItemName = "Bean w. Bacon, dehydrated, dry",
                Calories = "104",
                TotalFat = "2.1",
                Cholestrol = "3",
                Sodium = "917",
                TotalCarbs = "16.2",
                Protein = "5.4",
                Calcium = "54",
                Potassium = "322"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 2,
                ServingSize="cup(9.3 oz)",
                SubItemName = "Bean Soup, with Bacon, dry mix, prepared with water",
                Calories = "106",
                TotalFat = "2.1",
                Cholestrol = "3",
                Sodium = "928",
                TotalCarbs = "16.4",
                Protein = "5.5",
                Calcium = "55.7",
                Potassium = "326"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 4,
                ServingSize="cup(8.5 oz)",
                SubItemName = "Beef Broth (Bouillon), canned",
                Calories = "17",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "782",
                TotalCarbs = "0.1",
                Protein = "2.7",
                Calcium = "14.4",
                Potassium = "129.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 5,
                ServingSize="portion(0.6 oz)",
                SubItemName = "Cream of Celery, dehydrated, dry",
                Calories = "61",
                TotalFat = "1.6",
                Cholestrol = "1",
                Sodium = "818",
                TotalCarbs = "9.5",
                Protein = "2.6",
                Calcium = "34.5",
                Potassium = "105.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 6,
                ServingSize="serving,1 packet + 6 fl.oz water(6.9 oz)",
                SubItemName = "Cream of Vegetable, dehydrated, prep. w. water",
                Calories = "80",
                TotalFat = "4.3",
                Cholestrol = "0",
                Sodium = "878",
                TotalCarbs = "9.2",
                Protein = "1.4",
                Calcium = "23.4",
                Potassium = "72.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 7,
                ServingSize="envelope(0.5 oz)",
                SubItemName = " Lipton Soups Chicken Noodle Cup-a-Soup Mix, dry",
                Calories = "50",
                TotalFat = "1",
                Cholestrol = "10",
                Sodium = "540",
                TotalCarbs = "8",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 8,
                ServingSize="cup(8.7 oz)",
                SubItemName = "Condensed Onion Soup, canned ",
                Calories = "113",
                TotalFat = "3.5",
                Cholestrol = "0",
                Sodium = "211",
                TotalCarbs = "16.4",
                Protein = "7.5",
                Calcium = "54.1",
                Potassium = "137.8"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 9,
                ServingSize="packet(1.4 oz)",
                SubItemName = "Knorr Vegetable Soup Mix, dry ",
                Calories = "119",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "2779",
                TotalCarbs = "23.8",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 10,
                ServingSize="serving, 1/5 package(1.2 oz)",
                SubItemName = "Manischewitz Four Bean Soup Mix, with Seasonings, dry",
                Calories = "110",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "790",
                TotalCarbs = "20",
                Protein = "7",
                Calcium = "40",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 11,
                ServingSize="serving,1/4 package(1.5 oz)",
                SubItemName = "Manischewitz Minestrone Soup Mix, dry",
                Calories = "150",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "530",
                TotalCarbs = "27",
                Protein = "9",
                Calcium = "20",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 12,
                ServingSize="serving(0.3 oz)",
                SubItemName = "Mishima All Natural, Hot and Sour, Chinese, dry",
                Calories = "20",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "660",
                TotalCarbs = "4",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 13,
                ServingSize="container",
                SubItemName = "San-J Dark Miso, dry ",
                Calories = "40",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "1150",
                TotalCarbs = "3",
                Protein = "4",
                Calcium = "20",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 14,
                ServingSize="serving, cup prepared",
                SubItemName = " Streit's Split Pea, prep. as directed ",
                Calories = "150",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "610",
                TotalCarbs = "26",
                Protein = "10",
                Calcium = "20",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 9,
                SubItemId = 15,
                ServingSize="serving, 1/8 packet(0.7 oz)",
                SubItemName = "Vigo Chicken Noodle Bison Canyon Soups, dry",
                Calories = "70",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "680",
                TotalCarbs = "14",
                Protein = "2",
                Calcium = "20",
                Potassium = "0"
            }); 

            #endregion
           
            #region | FastFoods |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 1,
                ServingSize="order",
                SubItemName = "Applebee's Appetizer Sampler ",
                Calories = "2380",
                TotalFat = "151.5",
                Cholestrol = "0",
                Sodium = "5795",
                TotalCarbs = "170",
                Protein = "90",
                Calcium = "0",
                Potassium = "0"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 2,
                ServingSize="order",
                SubItemName = "Applebee's Boneless Buffalo Wings with Honey BBQ Sauce",
                Calories = "1250",
                TotalFat = "55",
                Cholestrol = "0",
                Sodium = "3060",
                TotalCarbs = "116",
                Protein = "71",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 3,
                ServingSize="order",
                SubItemName = "Applebee's Boneless Buffalo Wings with Classic Sauce",
                Calories = "1170",
                TotalFat = "69",
                Cholestrol = "0",
                Sodium = "3780",
                TotalCarbs = "66",
                Protein = "70",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 4,
                ServingSize = "order",
                SubItemName = "Applebee's Boneless Buffalo Wings with Hot Sauce",
                Calories = "1170",
                TotalFat = "70",
                Cholestrol = "0",
                Sodium = "3900",
                TotalCarbs = "67",
                Protein = "71",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 5,
                ServingSize="order",
                SubItemName = "Applebee's Boneless Buffalo Wings with Southern BBQ Sauce",
                Calories = "1110",
                TotalFat = "55",
                Cholestrol = "0",
                Sodium = "2780",
                TotalCarbs = "83",
                Protein = "70",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 6,
                ServingSize="order",
                SubItemName = "Applebee's Classic Wings with Southern BBQ Sauce",
                Calories = "660",
                TotalFat = "35",
                Cholestrol = "0",
                Sodium = "1060",
                TotalCarbs = "25",
                Protein = "61",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 7,
                ServingSize="order",
                SubItemName = "Applebee's Grilled Chicken Wonton Tacos ",
                Calories = "610",
                TotalFat = "27",
                Cholestrol = "0",
                Sodium = "1980",
                TotalCarbs = "58",
                Protein = "35",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 8,
                ServingSize="order",
                SubItemName = "Applebee's Potato Twisters",
                Calories = "940",
                TotalFat = "57",
                Cholestrol = "0",
                Sodium = "2820",
                TotalCarbs = "82",
                Protein = "25",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 9,
                ServingSize="order",
                SubItemName = "Applebee's Chili Cheese Nachos",
                Calories = "1600",
                TotalFat = "99",
                Cholestrol = "0",
                Sodium = "3940",
                TotalCarbs = "132",
                Protein = "48",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 10,
                ServingSize="bagel(4 oz)",
                SubItemName = "Atlanta Bread Company Asiago Bagel ",
                Calories = "390",
                TotalFat = "11",
                Cholestrol = "40",
                Sodium = "820",
                TotalCarbs = "53",
                Protein = "17",
                Calcium = "250",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 11,
                ServingSize="cookie(2.9 oz)",
                SubItemName = " Atlanta Bread Company Chocolate Toffee Cookie",
                Calories = "410",
                TotalFat = "19",
                Cholestrol = "35",
                Sodium = "160",
                TotalCarbs = "56",
                Protein = "4",
                Calcium = "40",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 12,
                ServingSize="cookie(2.9 oz)",
                SubItemName = "Atlanta Bread Company Oatmeal Raisin Cookie ",
                Calories = "370",
                TotalFat = "14",
                Cholestrol = "25",
                Sodium = "220",
                TotalCarbs = "59",
                Protein = "5",
                Calcium = "20",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 13,
                ServingSize="cookie(2.8 oz)",
                SubItemName = "Atlanta Bread Company Toffee Chocolate Chunk Cookie",
                Calories = "460",
                TotalFat = "23",
                Cholestrol = "35",
                Sodium = "250",
                TotalCarbs = "59",
                Protein = "4",
                Calcium = "40",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 14,
                ServingSize="croissant(4.4 oz)",
                SubItemName = "Atlanta Bread Company Cheese Croissant",
                Calories = "360",
                TotalFat = "19",
                Cholestrol = "25",
                Sodium = "320",
                TotalCarbs = "38",
                Protein = "6",
                Calcium = "40",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 15,
                ServingSize="muffin top(2.5 oz)",
                SubItemName = "Atlanta Bread Company Banana Nut Muffin Top",
                Calories = "420",
                TotalFat = "26",
                Cholestrol = "60",
                Sodium = "200",
                TotalCarbs = "39",
                Protein = "7",
                Calcium = "40",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 16,
                ServingSize="slice(5.5 oz)",
                SubItemName = "Atlanta Bread Company Key Lime Pie",
                Calories = "520",
                TotalFat = "26",
                Cholestrol = "195",
                Sodium = "190",
                TotalCarbs = "65",
                Protein = "9",
                Calcium = "200",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 17,
                ServingSize="sandwitch(3.3 oz)",
                SubItemName = " 7-Eleven Sausage Biscuit Breakfast Sandwich ",
                Calories = "330",
                TotalFat = "22",
                Cholestrol = "20",
                Sodium = "840",
                TotalCarbs = "28",
                Protein = "8",
                Calcium = "60",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 18,
                ServingSize="biscuit(5.6 oz)",
                SubItemName = "Arby's Bacon, Egg and Cheese Biscuit",
                Calories = "450",
                TotalFat = "26",
                Cholestrol = "160",
                Sodium = "1430",
                TotalCarbs = "34",
                Protein = "19",
                Calcium = "250",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 10,
                SubItemId = 19,
                ServingSize="croissant(6.1 oz)",
                SubItemName = "Arby's Sausage, Egg and Cheese Croissant",
                Calories = "540",
                TotalFat = "40",
                Cholestrol = "205",
                Sodium = "1150",
                TotalCarbs = "26",
                Protein = "18",
                Calcium = "300",
                Potassium = "0"
            });
            
            #endregion
          
            #region | Desserts and Pies |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 1,
                ServingSize="apple w.liquid",
                SubItemName = "Apple, baked w. sugar ",
                Calories = "135",
                TotalFat = "2.1",
                Cholestrol = "5",
                Sodium = "3",
                TotalCarbs = "31.8",
                Protein = "0.6",
                Calcium = "0",
                Potassium = "0"

            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 2,
                ServingSize="apple w.liquid",
                SubItemName = "Apple, baked, unsweetened ",
                Calories = "127",
                TotalFat = "2.1",
                Cholestrol = "5",
                Sodium = "3",
                TotalCarbs = "29.7",
                Protein = "0.6",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 3,
                ServingSize="portion, make 1 cup(1.5 oz)",
                SubItemName = " Caramel Custard Flan, dry mix ",
                Calories = "146",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "181",
                TotalCarbs = "38.5",
                Protein = "0",
                Calcium = "10.1",
                Potassium = "64.3"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 4,
                ServingSize="serving(3.5 oz)",
                SubItemName = " Caramel Custard Flan, dry mix, prepared with 2% milk",
                Calories = "103",
                TotalFat = "1.7",
                Cholestrol = "7",
                Sodium = "113",
                TotalCarbs = "18.8",
                Protein = "3",
                Calcium = "113",
                Potassium = "163"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 5,
                ServingSize="portion, make 1 cup(1.5 oz)",
                SubItemName = "Egg Custard, dry mix ",
                Calories = "172",
                TotalFat = "2.7",
                Cholestrol = "108",
                Sodium = "118",
                TotalCarbs = "34.8",
                Protein = "2.9",
                Calcium = "95.8",
                Potassium = "226.8"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 6,
                ServingSize="serving(3.5 oz)",
                SubItemName = "Vanilla Rennin, dry mix, prepared with whole milk",
                Calories = "89",
                TotalFat = "3.1",
                Cholestrol = "13",
                Sodium = "46",
                TotalCarbs ="12.2",
                Protein = "3",
                Calcium = "119",
                Potassium = "140"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 7,
                ServingSize="tablespoon(0.4 oz)",
                SubItemName = " Vanilla Rennin, dry mix ",
                Calories = "41",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "10.7",
                Protein = "0",
                Calcium = "12.6",
                Potassium = "0.3"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 8,
                ServingSize="package(0.3 oz)",
                SubItemName = "Unsweetened Rennin Tablets ",
                Calories = "8",
                TotalFat = "<0.1",
                Cholestrol = "0",
                Sodium = "2579",
                TotalCarbs = "2",
                Protein = "0.1",
                Calcium = "369.6",
                Potassium = "28.9"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 9,
                ServingSize="serving, 2 shells(1.1 oz)",
                SubItemName = " Meringue Shell ",
                Calories = "120",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "40",
                TotalCarbs = "29",
                Protein = "1",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 10,
                ServingSize="serving(3.5 oz)",
                SubItemName = " Chocolate Rennin, dry mix, prepared w. milk ",
                Calories = "85",
                TotalFat = "2.1",
                Cholestrol = "7",
                Sodium = "52",
                TotalCarbs = "13.5",
                Protein = "3.2",
                Calcium = "126",
                Potassium = "182"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 11,
                ServingSize="cup(9.9 oz)",
                SubItemName = "Baked Egg Custard, prepared from recipe ",
                Calories = "296",
                TotalFat = "12.9",
                Cholestrol = "237",
                Sodium = "172",
                TotalCarbs = "31",
                Protein = "14.2",
                Calcium = "31",
                Potassium = "417.4"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 12,
                ServingSize="cup(14.3 oz)",
                SubItemName = "Chocolate Mousse, prepared from recipe ",
                Calories = "909",
                TotalFat = "64.6",
                Cholestrol = "566",
                Sodium = "154",
                TotalCarbs = "64.9",
                Protein = "16.7",
                Calcium = "387.8",
                Potassium = "577.7"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 13,
                ServingSize="serving, 3 pieces",
                SubItemName = " Alessi Glazed Puff Pastry Sfogliatine ",
                Calories = "150",
                TotalFat = "8",
                Cholestrol = "8",
                Sodium = "75",
                TotalCarbs = "18",
                Protein = "2",
                Calcium = "20",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 14,
                ServingSize="serving, 1/2 pie(4 oz)",
                SubItemName = " Amy's Apple Pie, frozen",
                Calories = "230",
                TotalFat = "8",
                Cholestrol = "25",
                Sodium = "135",
                TotalCarbs = "37",
                Protein = "2",
                Calcium = "20",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 11,
                SubItemId = 15,
                ServingSize="slice, 1/6 cake(1.8 oz)",
                SubItemName = " Amy's Chocolate Cake, frozen ",
                Calories = "170",
                TotalFat = "6",
                Cholestrol = "0",
                Sodium = "210",
                TotalCarbs = "27",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"

            });


            #endregion

            #region | Alcoholic Drinks |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 1,
                ServingSize="can or bottle(12 fl.oz)",
                SubItemName = "Light Beer (3.1% alc.)",
                Calories = "103",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "14",
                TotalCarbs = "5.8",
                Protein = "0.9",
                Calcium = "14.2",
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 2,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Regular Beer (~5% alc.)",
                Calories = "153",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "14",
                TotalCarbs = "12.6",
                Protein = "1.6",
                Calcium = "14.2",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 3,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Low Alcohol (2.3% alc.)",
                Calories = "75",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "25",
                TotalCarbs = "16.3",
                Protein = "0",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 4,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Amstel Light Pale Lager(3.5% alc.)",
                Calories = "95",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "5",
                Protein = "1",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 5,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Anchor Brewing Co. Steam(4.9% alc.)",
                Calories = "155",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "16",
                Protein = "0",
                Calcium = "13",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 6,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Arrogant Bastard Ale (7.2%)",
                Calories = "187",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "11.8",
                Protein = "0.5",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 7,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Asahi Brewmaster's SelectAmber(4.7% alc.)",
                Calories = "140",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "10.7",
                Protein = "0.7",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 8,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Aspen Edge Low Carb (4.1% alc)",
                Calories = "94",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "18",
                TotalCarbs = "2.6",
                Protein = "0.7",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 9,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Augsburger Bock (4.9% alc.)",
                Calories = "168",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "16.8",
                Protein = "1",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 10,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Beck's Dark (4.8% alc)",
                Calories = "142",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "10",
                Protein = "1",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 11,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Budweiser American Ale (5.3% alc.)",
                Calories = "182",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "18.1",
                Protein = "1.8",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 12,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Budweiser Light and Clamato Chelada(4.2% alc)",
                Calories = "151",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "15.6",
                Protein = "1.9",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 13,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Budweiser Ice Pale Lager (5.9% alc.)",
                Calories = "136",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "1.2",
                Protein = "0.3",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 14,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "Budweiser Light Lager (4.2% alc.)",
                Calories = "110",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "6.6",
                Protein = "0.9",
                Calcium = "0",
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 12,
                SubItemId = 15,
                ServingSize = "can or bottle(12 fl.oz)",
                SubItemName = "HardCore Crisp Hard Cider (6% alc.)",
                Calories = "190",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "15",
                TotalCarbs = "21",
                Protein = "0",
                Calcium = "0",
            }); 
            #endregion

            #region| Bread Products |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 1,
                ServingSize="dough, 2.5\" dia(1,5 oz)",
                SubItemName = "Plain/Buttermilk Biscuit refrigerated",
                Calories = "138",
                TotalFat = "5.9",
                Cholestrol = "0",
                Sodium = "430",
                TotalCarbs = "18.6",
                Protein = "2.9",
                Calcium = "21.9",
                Potassium = "69.7"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 2,
                ServingSize="cup(3.8 oz)",
                SubItemName = "Bread Crumbs, Plain, dry Serving Size:",
                Calories = "427",
                TotalFat = "5.7",
                Cholestrol = "0",
                Sodium = "791",
                TotalCarbs = "77.7",
                Protein = "14.4",
                Calcium = "197",
                Potassium = "211.7"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 3,
                ServingSize="serving,2/3 cup(1.2 oz)",
                SubItemName = " Aunt Millie's Plain Croutons",
                Calories = "80",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "125",
                TotalCarbs = "16",
                Protein = "3",
                Calcium = "20",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 4,
                ServingSize="biscuit, 2\" dia(0.8 oz)",
                SubItemName = "Plain or Buttermilk Biscuit, lower fat, refrigerated dough",
                Calories = "95",
                TotalFat = "5",
                Cholestrol = "0",
                Sodium = "292",
                TotalCarbs = "12.6",
                Protein = "2",
                Calcium = "14.6",
                Potassium = "47.8"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 5,
                ServingSize="package(6 oz)",
                SubItemName = "Bread Stuffing, dry mix",
                Calories = "656",
                TotalFat = "5.8",
                Cholestrol = "2",
                Sodium = "2703",
                TotalCarbs = "129.5",
                Protein = "18.7",
                Calcium = "164.9",
                Potassium = "418.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 6,
                ServingSize="serving,1/10 package dry(0.4 oz)",
                SubItemName = "Dixie Diners' Club Bun and Roll, dry",
                Calories = "23",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "197",
                TotalCarbs = "4",
                Protein = "4",
                Calcium = "30",
                Potassium = "174"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 7,
                ServingSize="serving, 2 tablespoons(1 oz)",
                SubItemName = "Coating Mixes, seasoned",
                Calories = "135",
                TotalFat = "3.4",
                Cholestrol = "0",
                Sodium = "406",
                TotalCarbs = "17.6",
                Protein = "1.4",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 8,
                ServingSize="cup(1.1 oz)",
                SubItemName = "Croutons, Plains",
                Calories = "122",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "209",
                TotalCarbs = "22.1",
                Protein = "3.6",
                Calcium = "22.8",
                Potassium = "37.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 9,
                ServingSize="serving, 1/4 cup(1 oz)",
                SubItemName = "Progresso Plain Bread Crumbs",
                Calories = "110",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "200",
                TotalCarbs = "20",
                Protein = "4",
                Calcium = "40",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 10,
                ServingSize="wrapper(0.3 oz)",
                SubItemName = "Fortune Brand Won Ton Wrapper",
                Calories = "20",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "40",
                TotalCarbs = "4.3",
                Protein = "0.3",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 11,
                ServingSize="serving, 1/8 crust(2 oz)",
                SubItemName = "Dough, Pizza Dough, Whole Wheat ",
                Calories = "130",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "240",
                TotalCarbs = "24",
                Protein = "4",
                Calcium = "20",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 12,
                ServingSize="miniature, 3\" dia (0.2 oz)",
                SubItemName = "Taco Shells, baked ",
                Calories = "23",
                TotalFat = "1.2",
                Cholestrol = "0",
                Sodium = "19",
                TotalCarbs = "3.1",
                Protein = "0.4",
                Calcium = "5.1",
                Potassium = "11.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 13,
                ServingSize="serving, 1/2 sheet (0.8 oz)",
                SubItemName = "Mrs Olson's Lefse, plain",
                Calories = "60",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "140",
                TotalCarbs = "11",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 14,
                ServingSize="enchilada(0.7 oz)",
                SubItemName = "Corn Tortillas, ready to bake or fry ",
                Calories = "41",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "8.5",
                Protein = "1.1",
                Calcium = "15.4",
                Potassium = "35.3"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 15,
                ServingSize="totilla, 6 inch(1 oz)",
                SubItemName = "Chi's Fajita Style Flour Tortilla ",
                Calories = "80",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "260",
                TotalCarbs = "14",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 16,
                ServingSize="stick, 4.5\" long(0.2 oz)",
                SubItemName = "Bread Sticks",
                Calories = "21",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "33",
                TotalCarbs = "3.4",
                Protein = "0.6",
                Calcium = "1.1",
                Potassium = "6.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 17,
                ServingSize="roll(4 oz)",
                SubItemName = "Ciabatta Roll",
                Calories = "250",
                TotalFat = "2.5",
                Cholestrol = "0",
                Sodium = "730",
                TotalCarbs = "48",
                Protein = "9",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 18,
                ServingSize="roll,2\" squarex2\" high(0.9 oz)",
                SubItemName = "Dinner Roll, Plain",
                Calories = "78",
                TotalFat = "1.6",
                Cholestrol = "1",
                Sodium = "134",
                TotalCarbs = "13",
                Protein = "2.7",
                Calcium = "44.5",
                Potassium = "34.8"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 19,
                ServingSize="roll(1 oz)",
                SubItemName = "Wheat Dinner Roll ",
                Calories = "0",
                TotalFat = "1.8",
                Cholestrol = "0",
                Sodium = "95",
                TotalCarbs = "12.9",
                Protein = "2.4",
                Calcium = "49.3",
                Potassium = "32.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 20,
                ServingSize="muffin(2.3 oz)",
                SubItemName = "Mixed Grain English Muffin",
                Calories = "155",
                TotalFat = "1.2",
                Cholestrol = "0",
                Sodium = "275",
                TotalCarbs = "30.6",
                Protein = "6",
                Calcium = "129.4",
                Potassium = "103"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 21,
                ServingSize="muffin(2 oz)",
                SubItemName = "English Muffin, Plain",
                Calories = "134",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "264",
                TotalCarbs = "26.2",
                Protein = "4.4",
                Calcium = "29.6",
                Potassium = "74.7"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 22,
                ServingSize="muffin(2 oz)",
                SubItemName = "Raisin Cinnamon English Muffin",
                Calories = "137",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "189",
                TotalCarbs = "27.4",
                Protein = "4.5",
                Calcium = "65",
                Potassium = "98.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 23,
                ServingSize="muffin(2 oz)",
                SubItemName = "Wheat English Muffin",
                Calories = "127",
                TotalFat = "1.1",
                Cholestrol = "0",
                Sodium = "218",
                TotalCarbs = "25.5",
                Protein = "5",
                Calcium = "101.5",
                Potassium = "106"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 24,
                ServingSize="muffin(2.3 oz)",
                SubItemName = "Whole Wheat English Muffin",
                Calories = "134",
                TotalFat = "1.4",
                Cholestrol = "0",
                Sodium = "420",
                TotalCarbs = "26.7",
                Protein = "5.8",
                Calcium = "174.9",
                Potassium = "138.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 25,
                ServingSize="serving(2 oz)",
                SubItemName = "Foccacia, unfilled",
                Calories = "150",
                TotalFat = "5",
                Cholestrol = "5",
                Sodium = "300",
                TotalCarbs = "21",
                Protein = "5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 26,
                ServingSize="medium slice(2 oz)",
                SubItemName = "French Batard",
                Calories = "156",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "350",
                TotalCarbs = "34.3",
                Protein = "5.2",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 27,
                ServingSize="roll(1.3 oz)",
                SubItemName = "French Roll",
                Calories = "105",
                TotalFat = "1.6",
                Cholestrol = "0",
                Sodium = "231",
                TotalCarbs = "19.1",
                Protein = "3.3",
                Calcium = "34.6",
                Potassium = "43.3"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 28,
                ServingSize="piece(5.3 oz)",
                SubItemName = "Frybread, made with lard (Apache)",
                Calories = "464",
                TotalFat = "15.2",
                Cholestrol = "6",
                Sodium = "1007",
                TotalCarbs = "69",
                Protein = "12.6",
                Calcium = "78",
                Potassium = "112.5"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 29,
                ServingSize="piece(5.4 oz)",
                SubItemName = "Frybread, made with lard (Navajo)",
                Calories = "502",
                TotalFat = "18.6",
                Cholestrol = "11",
                Sodium = "500",
                TotalCarbs = "73.4",
                Protein = "10.2",
                Calcium = "86.6",
                Potassium = "117"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 30,
                ServingSize="roll(1.5 oz)",
                SubItemName = "Hamburger or Hotdog Roll, Plain",
                Calories = "117",
                TotalFat = "1.6",
                Cholestrol = "0",
                Sodium = "210",
                TotalCarbs = "21.1",
                Protein = "4.1",
                Calcium = "72.7",
                Potassium = "53.3"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 31,
                ServingSize="roll(2.3 oz)",
                SubItemName = "Hoagie / Submarine Roll, plain",
                Calories = "180",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "396",
                TotalCarbs = "33.7",
                Protein = "5.7",
                Calcium = "60",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 32,
                ServingSize="bun(1 oz)",
                SubItemName = "Hot Cross Bun" ,
                Calories = "84",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "101",
                TotalCarbs = "18.6",
                Protein = "2.3",
                Calcium = "10",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 33,
                ServingSize="roll, 3.5\" dia(2 oz)",
                SubItemName = "Kaiser or Hard Roll",
                Calories = "167",
                TotalFat = "2.5",
                Cholestrol = "0",
                Sodium = "310",
                TotalCarbs = "30",
                Protein = "5.6",
                Calcium = "54.2",
                Potassium = "61.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 34,
                ServingSize="rol(2.4 oz)",
                SubItemName = "Onion Roll",
                Calories = "150",
                TotalFat = "2.5",
                Cholestrol = "0",
                Sodium = "230",
                TotalCarbs = "28",
                Protein = "6",
                Calcium = "40",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 35,
                ServingSize="roll(1 oz)",
                SubItemName = "Parker House Roll",
                Calories = "80",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "95",
                TotalCarbs = "14",
                Protein = "3",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 36,
                ServingSize="serving, 3 rolls(1.8 oz)",
                SubItemName = "Party Roll",
                Calories = "130",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "190",
                TotalCarbs = "26",
                Protein = "5",
                Calcium = "40",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 37,
                ServingSize="small, 4\" dia(1 oz)",
                SubItemName = "Whole Wheat Pita (Khoubiz, Pocket)",
                Calories = "74",
                TotalFat = "0.7",
                Cholestrol = "0",
                Sodium = "149",
                TotalCarbs = "15.4",
                Protein = "2.7",
                Calcium = "4.2",
                Potassium = "47.6"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 38,
                ServingSize="roll(2.8 oz)",
                SubItemName = "Sourdough Roll",
                Calories = "210",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "350",
                TotalCarbs = "40",
                Protein = "5",
                Calcium = "60",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 13,
                SubItemId = 39,
                ServingSize="bun(2.6 oz)",
                SubItemName = "Wheat Bun",
                Calories = "200",
                TotalFat = "3.5",
                Cholestrol = "0",
                Sodium = "390",
                TotalCarbs = "38",
                Protein = "7",
                Calcium = "60",
                Potassium = "0"

            }); 
            #endregion 
          
            #region | Snacks |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 1,
                ServingSize="quantity(1 oz)",
                SubItemName = "Caramel-Coated Popcorn",
                Calories = "122",
                TotalFat = "3.6",
                Cholestrol = "1",
                Sodium = "59",
                TotalCarbs = "22.5",
                Protein = "1.1",
                Calcium = "12.2",
                Potassium = "31"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 2,
                ServingSize = "serving(1 oz)",
                SubItemName = "94% Fat-Free Microwave Popped Popcorn",
                Calories = "114",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "178",
                TotalCarbs = "21.6",
                Protein = "3",
                Calcium = "0.3",
                Potassium = "80.5"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 3,
                ServingSize = "serving(1 oz)",
                SubItemName = "Low-Fat Reduced Sodium Microwave Popped Popcorn",
                Calories = "122",
                TotalFat = "2.7",
                Cholestrol = "0",
                Sodium = "139",
                TotalCarbs = "20.8",
                Protein = "3.6",
                Calcium = "3.1",
                Potassium = "68.4"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 4,
                ServingSize = "cup(0.4 oz)",
                SubItemName = "Microwave Oil Popped Popcorn",
                Calories = "60",
                TotalFat = "3.6",
                Cholestrol = "0",
                Sodium = "88",
                TotalCarbs = "6.3",
                Protein = "0.8",
                Calcium = "0.4",
                Potassium = "20.7"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 5,
                ServingSize = "serving(1.2 oz)",
                SubItemName = " Act II Butter Microwave Popcorn, unpopped",
                Calories = "160",
                TotalFat = "10",
                Cholestrol = "0",
                Sodium = "360",
                TotalCarbs = "18",
                Protein = "3",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 6,
                ServingSize = "serving(1 oz)",
                SubItemName = "Cheese Flavor Potato Chips",
                Calories = "141",
                TotalFat = "7.7",
                Cholestrol = "1",
                Sodium = "225",
                TotalCarbs = "16.4",
                Protein = "2.4",
                Calcium = "20.4",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 7,
                ServingSize = "serving(1 oz)",
                SubItemName = "Unsalted Plain Potato Chips",
                Calories = "152",
                TotalFat = "9.8",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "15",
                Protein = "2",
                Calcium = "6.8",
                Potassium = "362.1"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 8,
                ServingSize = "serving, 17 chips(1 oz)",
                SubItemName = " GeniSoy Barbecue Potato Bakes Chips",
                Calories = "110",
                TotalFat = "2.5",
                Cholestrol = "0",
                Sodium = "190",
                TotalCarbs = "16",
                Protein = "5",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 9,
                ServingSize = "serving, 18 chips(1 oz)",
                SubItemName = " Cape Cod Chips Sea Salt and Vinegar Potato Chips",
                Calories = "150",
                TotalFat = "8",
                Cholestrol = "0",
                Sodium = "170",
                TotalCarbs = "15",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 10,
                ServingSize = "serving, 13 chips(1 oz)",
                SubItemName = " Kettle Backyard Barbeque Potato Chips",
                Calories = "150",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "135",
                TotalCarbs = "15",
                Protein = "2",
                Calcium = "0",
                Potassium = "400"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 11,
                ServingSize = "serving, 13 chips(1 oz)",
                SubItemName = "Kettle Sea Salt Organic Potato Chips ",
                Calories = "150",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "115",
                TotalCarbs = "16",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 12,
                ServingSize = "serving, 16 chips(1 oz)",
                SubItemName = " Jays Barbecue Potato Chips",
                Calories = "150",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "250",
                TotalCarbs = "16",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 13,
                ServingSize = "serving, 16 chips(1 oz)",
                SubItemName = " Jays Curly Waves Chips",
                Calories = "150",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "130",
                TotalCarbs = "16",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 14,
                ServingSize = "serving, 16 chips(1 oz)",
                SubItemName = " Jays Hot Stuff Potato Chips",
                Calories = "150",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "260",
                TotalCarbs = "16",
                Protein = "2",
                Calcium = "0",
                Potassium = "0"
            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 14,
                SubItemId = 15,
                ServingSize = "serving, 20 chips(1 oz)",
                SubItemName = "Kettle Sea Salt Baked Potato Chips",
                Calories = "120",
                TotalFat = "3",
                Cholestrol = "0",
                Sodium = "135",
                TotalCarbs = "21",
                Protein = "2",
                Calcium = "0",
                Potassium = "440"
            });
            
            #endregion

            #region | Rice and Pasta |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 1,
                ServingSize="cup (6.9 oz)",
                SubItemName = "Long Grain Brown Rice, cooked",
                Calories = "216",
                TotalFat = "1.8",
                Cholestrol = "0",
                Sodium = "10",
                TotalCarbs = "44.8",
                Protein = "5",
                Calcium = "19.5",
                Potassium = "83.9"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 2,
                ServingSize = "cup (6.5 oz)",
                SubItemName = "Long Grain Brown Rice, raw",
                Calories = "685",
                TotalFat = "5.4",
                Cholestrol = "0",
                Sodium = "13",
                TotalCarbs = "142.9",
                Protein = "14.7",
                Calcium = "42.6",
                Potassium = "412.6"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 3,
                ServingSize = "cup (6.9 oz)",
                SubItemName = "Medium Grain Brown Rice, cooke",
                Calories = "218",
                TotalFat = "1.6",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "45.8",
                Protein = "4.5",
                Calcium = "19.5",
                Potassium = "154.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 4,
                ServingSize = "cup (6.7 oz)",
                SubItemName = "Medium Grain Brown Rice, raw",
                Calories = "688",
                TotalFat = "5.1",
                Cholestrol = "0",
                Sodium = "8",
                TotalCarbs = "144.7",
                Protein = "14.3",
                Calcium = "62.7",
                Potassium = "509.2"

            });  this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 5,
                ServingSize = "cup (6.1 oz)",
                SubItemName = "White Glutinous Rice, cooked",
                Calories = "169",
                TotalFat = "0.3",
                Cholestrol = "0",
                Sodium = "9",
                TotalCarbs = "36.7",
                Protein = "3.5",
                Calcium = "3.5",
                Potassium = "17.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 6,
                ServingSize = "cup (6.5 oz)",
                SubItemName = "White Glutinous Rice, raw",
                Calories = "685",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "13",
                TotalCarbs = "151.1",
                Protein = "12.6",
                Calcium = "20.4",
                Potassium = "142.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 7,
                ServingSize = "cup (5.6 oz)",
                SubItemName = "Parboiled Long Grain White Rice, cooked",
                Calories = "194",
                TotalFat = "0.6",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "41.2",
                Protein = "4.6",
                Calcium = "30",
                Potassium = "88.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 8,
                ServingSize = "cup (6.6 oz)",
                SubItemName = "Parboiled Long Grain White Rice, dry",
                Calories = "699",
                TotalFat = "1.9",
                Cholestrol = "0",
                Sodium = "6",
                TotalCarbs = "150.4",
                Protein = "15.2",
                Calcium = "102.9",
                Potassium = "349.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 9,
                ServingSize = "cup (3.4 oz)",
                SubItemName = "Precooked or Instant Long Grain White Rice, dry",
                Calories = "361",
                TotalFat = "0.9",
                Cholestrol = "0",
                Sodium = "10",
                TotalCarbs = "78.2",
                Protein = "7.4",
                Calcium = "20.9",
                Potassium = "25.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 10,
                ServingSize = "cup (5.6 oz)",
                SubItemName = "Long Grain White Rice, cooked without salt",
                Calories = "205",
                TotalFat = "0.4",
                Cholestrol = "0",
                Sodium = "2",
                TotalCarbs = "44.5",
                Protein = "4.3",
                Calcium = "15.8",
                Potassium = "55.3"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 11,
                ServingSize = "cup (4.9 oz)",
                SubItemName = "Corn Pasta, cooked",
                Calories = "176",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "39.1",
                Protein = "3.7",
                Calcium = "1.4",
                Potassium = "43.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 12,
                ServingSize = "cup, spiral shaped(3 oz)",
                SubItemName = "Vegetable Pasta, dry",
                Calories = "308",
                TotalFat = "0.9",
                Cholestrol = "0",
                Sodium = "36",
                TotalCarbs = "62.9",
                Protein = "11",
                Calcium = "28.6",
                Potassium = "239.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 13,
                ServingSize = "serving, 1/7 box(2 oz)",
                SubItemName = "Barilla PLUS Elbows Pasta",
                Calories = "210",
                TotalFat = "2",
                Cholestrol = "0",
                Sodium = "25",
                TotalCarbs = "38",
                Protein = "10",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 14,
                ServingSize = "cup (3.7 oz)",
                SubItemName = "Corn Pasta, dry",
                Calories = "375",
                TotalFat = "2.2",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "83.2",
                Protein = "7.8",
                Calcium = "4.2",
                Potassium = "308.7"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 15,
                ServingSize = "cup (4.5 oz)",
                SubItemName = "Fresh-refrigerated Plain Pasta, as purchased",
                Calories = "369",
                TotalFat = "2.9",
                Cholestrol = "93",
                Sodium = "33",
                TotalCarbs = "70.1",
                Protein = "14.5",
                Calcium = "19.2",
                Potassium = "229.1"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 16,
                ServingSize = "cup, small shells (4.1 oz)",
                SubItemName = "Plain Pasta, cooked",
                Calories = "182",
                TotalFat = "1.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "35.5",
                Protein = "6.7",
                Calcium = "8.1",
                Potassium = "51.8"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 17,
                ServingSize = "cup, elbow shaped (3.7 oz)",
                SubItemName = "Whole Wheat Pasta, dry",
                Calories = "365",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "8",
                TotalCarbs = "78.8",
                Protein = "15.4",
                Calcium = "42",
                Potassium = "255.8"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 18,
                ServingSize = "cup, small shells (4.1 oz)",
                SubItemName = "Protein-fortified Pasta, cooked",
                Calories = "189",
                TotalFat = "0.2",
                Cholestrol = "0",
                Sodium = "6",
                TotalCarbs = "36.4",
                Protein = "9.3",
                Calcium = "11.5",
                Potassium = "48.3"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 19,
                ServingSize = "cup (4.5 oz)",
                SubItemName = "Fresh-refrigerated Spinach Pasta, as purchased",
                Calories = "370",
                TotalFat = "2.7",
                Cholestrol = "93",
                Sodium = "35",
                TotalCarbs = "71.3",
                Protein = "14.4",
                Calcium = "55",
                Potassium = "348.2"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 20,
                ServingSize = "cup (5 oz)",
                SubItemName = "Homemade Pasta, made without egg, cooked",
                Calories = "176",
                TotalFat = "1.4",
                Cholestrol = "0",
                Sodium = "105",
                TotalCarbs = "35.7",
                Protein = "6.2",
                Calcium = "8.5",
                Potassium = "27"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 21,
                ServingSize = "serving, 1/4 packet",
                SubItemName = " Alessi Potato Gnocchi, dry",
                Calories = "170",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "660",
                TotalCarbs = "35",
                Protein = "4",
                Calcium = "20",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 15,
                SubItemId = 22,
                ServingSize = "serving, 1/3 cup",
                SubItemName = " Alessi Cavetelli Pasta, dry",
                Calories = "210",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "7",
                TotalCarbs = "44",
                Protein = "6",
                Calcium = "0",
                Potassium = "0"

            });

            #endregion

            #region | International Foods |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 1,
                ServingSize="serving",
                SubItemName = "Chicken Katsu, with Rice",
                Calories = "1110",
                TotalFat = "48",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "108",
                Protein = "61.5",
                Calcium = "0",
                Potassium = "0"
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 2,
                ServingSize = "serving",
                SubItemName = "Chicken Katsu, with Rice and Macaroni Salad",
                Calories = "1360",
                TotalFat = "68",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "123",
                Protein = "64",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 3,
                ServingSize = "serving",
                SubItemName = "Chicken Katsu, with Rice, Tossed Salad and Dressing",
                Calories = "1240",
                TotalFat = "61",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "111",
                Protein = "62",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 4,
                ServingSize = "serving",
                SubItemName = "Hamburger, with Rice",
                Calories = "710",
                TotalFat = "24",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "81",
                Protein = "42.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 5,
                ServingSize = "serving",
                SubItemName = "Hamburger, with Rice, Gravy and Macaroni Salad",
                Calories = "1135",
                TotalFat = "49",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "112",
                Protein = "61.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 6,
                ServingSize = "serving",
                SubItemName = "MahiMahi with Rice,Tossed Salad and Dressing",
                Calories = "815",
                TotalFat = "27",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "96",
                Protein = "47",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 7,
                ServingSize = "serving",
                SubItemName = "MahiMahi, with Rice, Macaroni Salad andTartar Sauce",
                Calories = "1150",
                TotalFat = "58",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "109",
                Protein = "48",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 8,
                ServingSize = "serving",
                SubItemName = " MahiMahi, with Rice, Macaroni Salad, without sauce",
                Calories = "935",
                TotalFat = "34",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "108",
                Protein = "49.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 9,
                ServingSize = "serving",
                SubItemName = "MahiMahi, with Rice, Tossed Salad, without dressing",
                Calories = "670",
                TotalFat = "12",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "93",
                Protein = "47.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 10,
                ServingSize = "regular serving",
                SubItemName = "Spaghetti and Meatballs with Tomato Sauce, regular",
                Calories = "970",
                TotalFat = "30.3",
                Cholestrol = "117",
                Sodium = "1268",
                TotalCarbs = "131.9",
                Protein = "44",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 11,
                ServingSize = "serving",
                SubItemName = "MahiMahi, withh Rice",
                Calories = "650",
                TotalFat = "12",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "90",
                Protein = "45.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 12,
                ServingSize = "serving",
                SubItemName = "Teri Beef, with Rice",
                Calories = "790",
                TotalFat = "23",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "94",
                Protein = "52",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 13,
                ServingSize = "serving",
                SubItemName = "Teri Beef, with Rice, Macaroni Salad",
                Calories = "1095",
                TotalFat = "47",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "113",
                Protein = "55",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 14,
                ServingSize = "serving",
                SubItemName = "Teri Beef, with Rice, Tossed Salad, without dressing",
                Calories = "800",
                TotalFat = "23",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "95",
                Protein = "53.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 15,
                ServingSize = "piece, 4-1/2\"x3-1/4\"x2\"",
                SubItemName = "Beef Lasagna",
                Calories = "408",
                TotalFat = "22.1",
                Cholestrol = "120",
                Sodium = "751",
                TotalCarbs = "27.4",
                Protein = "25.1",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 16,
                ServingSize = "Calzone, 1/2 recipe",
                SubItemName = "Calzone with Pepperoni Ham and Cheese",
                Calories = "641",
                TotalFat = "25.9",
                Cholestrol = "73",
                Sodium = "1703",
                TotalCarbs = "70.4",
                Protein = "29.6",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 17,
                ServingSize = "meal, 1/6 recipe",
                SubItemName = "Fettuccine Alfredo",
                Calories = "1166",
                TotalFat = "66.1",
                Cholestrol = "230",
                Sodium = "342",
                TotalCarbs = "119.1",
                Protein = "24.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 18,
                ServingSize = "meal, 1/6 recipe",
                SubItemName = "Four Cheese Fettuccine",
                Calories = "531",
                TotalFat = "22.7",
                Cholestrol = "60",
                Sodium = "487",
                TotalCarbs = "59.4",
                Protein = "22.5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 19,
                ServingSize = "sandwitch, 1/4 recipe",
                SubItemName = "Grilled Pesto Chicken Panini Sandwich",
                Calories = "577",
                TotalFat = "25.2",
                Cholestrol = "74",
                Sodium = "956",
                TotalCarbs = "48.4",
                Protein = "38.3",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 20,
                ServingSize = "breadstick, 12\" long",
                SubItemName = "Herb and Cheese Breadstick",
                Calories = "91",
                TotalFat = "1.5",
                Cholestrol = "0",
                Sodium = "190",
                TotalCarbs = "16.6",
                Protein = "2.7",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 21,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Homemade Egg Pasta, cooked",
                Calories = "212",
                TotalFat = "3.5",
                Cholestrol = "106",
                Sodium = "145",
                TotalCarbs = "36",
                Protein = "8",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 22,
                ServingSize = "crust, 8 slices",
                SubItemName = "Homemade Pizza Dough",
                Calories = "674",
                TotalFat = "6.5",
                Cholestrol = "0",
                Sodium = "1174",
                TotalCarbs = "131.7",
                Protein = "19.9",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 23,
                ServingSize = "serving, 1/2 cup(4 fl.oz)",
                SubItemName = "Lemon Ice",
                Calories = "105",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "3",
                TotalCarbs = "27.7",
                Protein = "0.1",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 24,
                ServingSize = "meal, 1 half-breast piece",
                SubItemName = "Chicken Marsala (Chicken with Red Wine Sauce)",
                Calories = "266",
                TotalFat = "8.4",
                Cholestrol = "68",
                Sodium = "416",
                TotalCarbs = "13.5",
                Protein = "29",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 25,
                ServingSize = "meal, 1/4 recipe",
                SubItemName = "Veal Marsala (Veal with Red Wine Sauce)",
                Calories = "288",
                TotalFat = "9.4",
                Cholestrol = "111",
                Sodium = "430",
                TotalCarbs = "13.5",
                Protein = "31.9",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 26,
                ServingSize = "bowl, 1/6 recipe",
                SubItemName = "Minestrone (Vegetable Soup)",
                Calories = "170",
                TotalFat = "5.1",
                Cholestrol = "0",
                Sodium = "884",
                TotalCarbs = "26.2",
                Protein = "5",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 27,
                ServingSize = "roll, 1/6 recipe",
                SubItemName = "Panini Bread Roll",
                Calories = "233",
                TotalFat = "2.5",
                Cholestrol = "0",
                Sodium = "198",
                TotalCarbs = "45",
                Protein = "6.8",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 28,
                ServingSize = "small meatball, 1\" dia",
                SubItemName = "Meatballs with Tomato Sauce",
                Calories = "40",
                TotalFat = "2.9",
                Cholestrol = "15",
                Sodium = "38",
                TotalCarbs = "0.9",
                Protein = "2.7",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 29,
                ServingSize = "meal, 1/4 recipe",
                SubItemName = "Eggplant Parmigiana with Tomato Sauce",
                Calories = "504",
                TotalFat = "32.8",
                Cholestrol = "57",
                Sodium = "1471",
                TotalCarbs = "32.9",
                Protein = "23.4",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 30,
                ServingSize = "meal, 1 piece",
                SubItemName = "Veal Parmigiana w.Tomato Sauce",
                Calories = "590",
                TotalFat = "34.8",
                Cholestrol = "168",
                Sodium = "980",
                TotalCarbs = "17.3",
                Protein = "50.8",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 31,
                ServingSize = "serving, 1/4 cup(4 fl.oz)",
                SubItemName = "Pesto (Basil Garlic Sauce)",
                Calories = "552",
                TotalFat = "56.2",
                Cholestrol = "15",
                Sodium = "1035",
                TotalCarbs = "5.7",
                Protein = "10.4",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 32,
                ServingSize = "cup (8 fl.oz)",
                SubItemName = "Ragu Bolgnese (Meat Sauce)",
                Calories = "318",
                TotalFat = "22.2",
                Cholestrol = "60",
                Sodium = "1186",
                TotalCarbs = "15.9",
                Protein = "15.6",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 33,
                ServingSize = "regular serving",
                SubItemName = "Spaghetti and Meatballs with Bolognese Sauce, regular",
                Calories = "1324",
                TotalFat = "58.5",
                Cholestrol = "206",
                Sodium = "2086",
                TotalCarbs = "136.6",
                Protein = "63.6",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 34,
                ServingSize = "small serving",
                SubItemName = "Spaghetti and Meatballs with Bolognese Sauce, small",
                Calories = "530",
                TotalFat = "23.5",
                Cholestrol = "88",
                Sodium = "2086",
                TotalCarbs = "53.7",
                Protein = "26.1",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 35,
                ServingSize = "meal, 1/6 recipe",
                SubItemName = "Spinach and Cheese Cannelloni, w.Tomato Sauce",
                Calories = "518",
                TotalFat = "15.6",
                Cholestrol = "43",
                Sodium = "899",
                TotalCarbs = "71.2",
                Protein = "24.9",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 36,
                ServingSize = "meal, 1/6 recipe",
                SubItemName = "Spinach Ricotta Ravioli with Bolognese Sauce",
                Calories = "654",
                TotalFat = "35",
                Cholestrol = "201",
                Sodium = "1489",
                TotalCarbs = "54.3",
                Protein = "31.7",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 37,
                ServingSize = "serving, 1/2 cup(4 fl.oz)",
                SubItemName = "Sugo (Tomato Sauce)",
                Calories = "41",
                TotalFat = "1.7",
                Cholestrol = "0",
                Sodium = "318",
                TotalCarbs = "6.4",
                Protein = "1.2",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 38,
                ServingSize = "piece,2-3/4\"x3-1/2\"x1-1/2\"",
                SubItemName = "Tiramisu",
                Calories = "602",
                TotalFat = "45.8",
                Cholestrol = "287",
                Sodium = "91",
                TotalCarbs = "34.3",
                Protein = "7.8",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 39,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Dashi Stock, prepared with Dashi Powder",
                Calories = "3",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "134",
                TotalCarbs = "0.6",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 40,
                ServingSize = "cup(6.3 oz)",
                SubItemName = "Edamame (Green Soybeans), boiled without salt added and drained",
                Calories = "254",
                TotalFat = "11.5",
                Cholestrol = "0",
                Sodium = "25",
                TotalCarbs = "19.9",
                Protein = "22.2",
                Calcium = "267",
                Potassium = "907.2"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 41,
                ServingSize = "bowl",
                SubItemName = "Katsudon(Deep Fried Pork Cutlet on Rice)",
                Calories = "679",
                TotalFat = "15.6",
                Cholestrol = "353",
                Sodium = "1625",
                TotalCarbs = "92.9",
                Protein = "41.4",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 42,
                ServingSize = "cup",
                SubItemName = "Miso Soup with Tofu and Spring Onion",
                Calories = "93",
                TotalFat = "4.3",
                Cholestrol = "0",
                Sodium = "805",
                TotalCarbs = "7.4",
                Protein = "7.9",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 43,
                ServingSize = "cup",
                SubItemName = "Miso Soup with Wakame Seaweed and Spring Onion",
                Calories = "47",
                TotalFat = "1.1",
                Cholestrol = "0",
                Sodium = "963",
                TotalCarbs = "6.7",
                Protein = "2.8",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 44,
                ServingSize = "serving (1 oz)",
                SubItemName = "Kimchi (Marinated Cabbage)",
                Calories = "8",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "122",
                TotalCarbs = "1",
                Protein = "0.5",
                Calcium = "10.1",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 45,
                ServingSize = "teaspoon(0.2 oz)",
                SubItemName = "Wasabi Root, raw",
                Calories = "5",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "1.2",
                Protein = "0.2",
                Calcium = "6.4",
                Potassium = "28.4"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 46,
                ServingSize = "tablespoon (0.5 fl.oz)",
                SubItemName = "Tonkatsu Sauce",
                Calories = "14",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "167",
                TotalCarbs = "3.4",
                Protein = "<0.1",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 47,
                ServingSize = "serving, 1/2 pepper",
                SubItemName = "Green Pepper Tempura",
                Calories = "69",
                TotalFat = "4",
                Cholestrol = "19",
                Sodium = "9",
                TotalCarbs = "7.1",
                Protein = "1.7",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 48,
                ServingSize = "cup (8 fl.oz)",
                SubItemName = "Tempura Batter, uncooked",
                Calories = "135",
                TotalFat = "2.5",
                Cholestrol = "93",
                Sodium = "35",
                TotalCarbs = "21.8",
                Protein = "5.7",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 49,
                ServingSize = "steak, yield from 4oz raw",
                SubItemName = "Teriyaki Beef",
                Calories = "249",
                TotalFat = "14.5",
                Cholestrol = "53",
                Sodium = "1065",
                TotalCarbs = "2.5",
                Protein = "25",
                Calcium = "0",
                Potassium = "0"
            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 16,
                SubItemId = 50,
                ServingSize = "serving, 1/2 fillet",
                SubItemName = "Teriyaki Salmon",
                Calories = "233",
                TotalFat = "5.5",
                Cholestrol = "83",
                Sodium = "1242",
                TotalCarbs = "11.3",
                Protein = "33.6",
                Calcium = "0",
                Potassium = "0"
            });

            #endregion

            #region | Beverages |

          
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 1,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed or Percolated. from Ground Coffee",
                Calories = "2",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "0",
                Protein = "0.3",
                Calcium = "4.7",
                Potassium = "116.1"
            
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 2,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Cappuccino, 2% milk ",
                Calories = "100",
                TotalFat = "3.5",
                Cholestrol = "15",
                Sodium = "105",
                TotalCarbs = "10",
                Protein = "6",
                Calcium = "200",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 3,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Cappuccino, No-Fat milk",
                Calories = "40",
                TotalFat = "0",
                Cholestrol = "3",
                Sodium = "47",
                TotalCarbs = "6",
                Protein = "4",
                Calcium = "133.2",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 4,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Cappuccino, whole milk",
                Calories = "73",
                TotalFat = "4",
                Cholestrol = "10",
                Sodium = "47",
                TotalCarbs = "6",
                Protein = "4",
                Calcium = "133.5",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 5,
                ServingSize = "shot(1 fl.oz)",
                SubItemName = "Espresso w. 5 g Sugar Coffee",
                Calories = "20",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "4",
                TotalCarbs = "5",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 6,
                ServingSize = "shot(1 fl.oz)",
                SubItemName = "Espresso w. dollop whipped cream Coffee",
                Calories = "110",
                TotalFat = "9",
                Cholestrol = "40",
                Sodium = "10",
                TotalCarbs = "3",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 7,
                ServingSize = "shot(1 fl.oz)",
                SubItemName = "Espresso, unsweetened coffee",
                Calories = "1",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "4",
                TotalCarbs = "0",
                Protein = "0.1",
                Calcium = "0.6",
                Potassium = "34.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 8,
                ServingSize = "fl.oz(1 oz)",
                SubItemName = "Ground Coffee",
                Calories = "0",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "1",
                TotalCarbs = "0",
                Protein = "0.1",
                Calcium = "0.6",
                Potassium = "14.5"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 9,
                ServingSize = "teaspoon, rounded (0.1 oz)",
                SubItemName = "Decaffeinated Instant Coffee Powder, dry",
                Calories = "4",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.8",
                Protein = "0.2",
                Calcium = "0.3",
                Potassium = "63"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 10,
                ServingSize = "teaspoon",
                SubItemName = "Instant Coffee Powder, dry",
                Calories = "2",
                TotalFat = "o.1",
                Cholestrol = "0",
                Sodium = "0",
                TotalCarbs = "0.4",
                Protein = "0.1",
                Calcium = "1.3",
                Potassium = "31.8"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 11,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = " Instant Powder, Regular, prep. w. 1 fl.oz Non-Fat Milk and 5g Sugar",
                Calories = "34",
                TotalFat = "0.1",
                Cholestrol = "1",
                Sodium = "21",
                TotalCarbs = "7.2",
                Protein = "1.3",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 12,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Caffe Mocha, No-Fat milk",
                Calories = "170",
                TotalFat = "0.5",
                Cholestrol = "5",
                Sodium = "160",
                TotalCarbs = "32",
                Protein = "8",
                Calcium = "250",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 13,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Caffe Mocha, 2% milk",
                Calories = "21",
                TotalFat = "4.5",
                Cholestrol = "15",
                Sodium = "160",
                TotalCarbs = "32",
                Protein = "7",
                Calcium = "200",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 14,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Caffe Latte, whole milk ",
                Calories = "136",
                TotalFat = "7",
                Cholestrol = "30",
                Sodium = "104",
                TotalCarbs = "11",
                Protein = "7",
                Calcium = "240",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 15,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Caffe Latte, No-Fat milk ",
                Calories = "64",
                TotalFat = "0",
                Cholestrol = "64",
                Sodium = "80",
                TotalCarbs = "10",
                Protein = "6.7",
                Calcium = "233.2",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 16,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Cafe Au Lait, No-Fat milk ",
                Calories = "50",
                TotalFat = "0",
                Cholestrol = "5",
                Sodium = "70",
                TotalCarbs = "7",
                Protein = "5",
                Calcium = "150",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 17,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. Coffee-Mate powder, 1 teaspoon",
                Calories = "12",
                TotalFat = "0.5",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "1",
                Protein = "0.3",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 18,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. Coffee-Mate liquid, 1 Tbsp",
                Calories = "20",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "2",
                Protein = "0.3",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 19,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. 2 Tbsp whole milk ",
                Calories = "20",
                TotalFat = "1",
                Cholestrol = "3",
                Sodium = "17",
                TotalCarbs = "1.4",
                Protein = "1.3",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 20,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. 2 Tbsp light coffee cream ",
                Calories = "61",
                TotalFat = "5.8",
                Cholestrol = "20",
                Sodium = "17",
                TotalCarbs = "1.1",
                Protein = "1.1",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 21,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. 2 Tbsp Half and Half",
                Calories = "41",
                TotalFat = "3.5",
                Cholestrol = "11",
                Sodium = "17",
                TotalCarbs = "1.3",
                Protein = "1.2",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 22,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. 2 Tbsp 2% milk",
                Calories = "18",
                TotalFat = "0.6",
                Cholestrol = "2",
                Sodium = "17",
                TotalCarbs = "1.4",
                Protein = "1.3",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 23,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. 2 Tbsp non-fat milk",
                Calories = "14",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "21",
                TotalCarbs = "1.5",
                Protein = "1.4",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 24,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Brewed w. Coffee-Mate liquid non-fat, 1 Tbsp",
                Calories = "10",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "2.5",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 25,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Cafe Au Lait, 2% milk",
                Calories = "70",
                TotalFat = "2.5",
                Cholestrol = "10",
                Sodium = "65",
                TotalCarbs = "7",
                Protein = "4",
                Calcium = "150",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 26,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Instant Coffee Powder, with Chicory, prepared with water",
                Calories = "7",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "12",
                TotalCarbs = "1.8",
                Protein = "0.2",
                Calcium = "7.2",
                Potassium = "81.4"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 27,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Instant Powder, Regular, prep. w. 1 fl.oz Whole Milk, unsweetened",
                Calories = "22",
                TotalFat = "1",
                Cholestrol = "3",
                Sodium = "17",
                TotalCarbs = "2",
                Protein = "1.2",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 28,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Instant Powder, Regular, prep. w. 1 fl.oz Whole Milk and 5g Sugar",
                Calories = "42",
                TotalFat = "1",
                Cholestrol = "3",
                Sodium = "17",
                TotalCarbs = "7",
                Protein = "1.2",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 29,
                ServingSize = "cup(8 fl.oz)",
                SubItemName = "Instant Powder, Regular, prep. w. 1 fl.oz Non-Fat Milk, unsweetened",
                Calories = "15",
                TotalFat = "0.1",
                Cholestrol = "1",
                Sodium = "21",
                TotalCarbs = "2.2",
                Protein = "1.3",
                Calcium = "0",
                Potassium = "0"

            }); this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 17,
                SubItemId = 30,
                ServingSize = "teaspoon,rounded (0.1 fl.oz)",
                SubItemName = "Instant Coffee Powder, with Chicory, dry",
                Calories = "6",
                TotalFat = "0.1",
                Cholestrol = "0",
                Sodium = "5",
                TotalCarbs = "1.3",
                Protein = "0.2",
                Calcium = "1.9",
                Potassium = "61.1"

            });
            #endregion

            #region | Dressings |

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 1,
                ServingSize="tablespoon(0.6 oz)",
                SubItemName = "Fat-Free Mayonnaise",
                Calories = "13",
                TotalFat = "0.4",
                Cholestrol = "1",
                Sodium = "126",
                TotalCarbs = "2.5",
                Protein = "0.1",
                Calcium = "1",
                Potassium = "7.8"
            
            });

            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 2,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Regular Mayonnaise",
                Calories = "90",
                TotalFat = "10",
                Cholestrol = "5",
                Sodium = "80",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 3,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Light or Reduced-Fat Mayonnaise",
                Calories = "49",
                TotalFat = "5",
                Cholestrol = "5",
                Sodium = "101",
                TotalCarbs = "1.2",
                Protein = "0.1",
                Calcium = "1.2",
                Potassium = "6"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 4,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Duke's Cholestrol-Free Mayonnaise",
                Calories = "45",
                TotalFat = "5",
                Cholestrol = "0",
                Sodium = "90",
                TotalCarbs = "1",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 5,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Duke's Light Mayonnaise",
                Calories = "50",
                TotalFat = "5",
                Cholestrol = "10",
                Sodium = "110",
                TotalCarbs = "1",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 6,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Duke's Fat-Free Mayonnaise",
                Calories = "15",
                TotalFat = "0",
                Cholestrol = "5",
                Sodium = "180",
                TotalCarbs = "3",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 7,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Duke's Mayonnaise",
                Calories = "100",
                TotalFat = "12",
                Cholestrol = "1.5",
                Sodium = "75",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 8,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Hain Pure Foods SafflowerOil",
                Calories = "100",
                TotalFat = "11",
                Cholestrol = "5",
                Sodium = "80",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 9,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Hollywood Canola Mayonnaise",
                Calories = "100",
                TotalFat = "11",
                Cholestrol = "5",
                Sodium = "100",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 10,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Hellmann's / Best Foods Mayonnaise with Extra Virgin Olive Oil",
                Calories = "50",
                TotalFat = "5",
                Cholestrol = "5",
                Sodium = "120",
                TotalCarbs = "0.5",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 11,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Hellmann's / Best Foods Canola Cholesterol-Free Mayonnaise",
                Calories = "45",
                TotalFat = "4.5",
                Cholestrol = "0",
                Sodium = "95",
                TotalCarbs = "0.5",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 12,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Hellmann's / Best Foods Low-Fat Mayonnaise",
                Calories = "15",
                TotalFat = "1",
                Cholestrol = "0",
                Sodium = "130",
                TotalCarbs = "2",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 13,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Hellmann's / Best Foods Real Mayonnaise",
                Calories = "90",
                TotalFat = "10",
                Cholestrol = "5",
                Sodium = "90",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 14,
                ServingSize = "serving(0.6 oz)",
                SubItemName = "Kraft Fat-Free Mayo",
                Calories = "10",
                TotalFat = "0",
                Cholestrol = "0",
                Sodium = "120",
                TotalCarbs = "2",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 15,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Spectrum Organic Mayonnaise",
                Calories = "100",
                TotalFat = "11",
                Cholestrol = "10",
                Sodium = "65",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 16,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Smart Balance Omega Plus Light Mayonnaise",
                Calories = "50",
                TotalFat = "4.5",
                Cholestrol = "5",
                Sodium = "115",
                TotalCarbs = "2",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 17,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Vegenaise Vegenaise, Expeller Pressed",
                Calories = "90",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "80",
                TotalCarbs = "1",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 18,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Mayonnaise Vegenaise, Vegenaise, Grapeseed Oil",
                Calories = "90",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "80",
                TotalCarbs = "1",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 19,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Mayonnaise Vegenaise, Vegenaise, Organic",
                Calories = "90",
                TotalFat = "9",
                Cholestrol = "0",
                Sodium = "85",
                TotalCarbs = "1",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 20,
                ServingSize = "tablespoon(0.5 oz)",
                SubItemName = "Mayonnaise Vegenaise, Vegenaise, Original",
                Calories = "90",
                TotalFat = "9",
                Cholestrol = "1",
                Sodium = "80",
                TotalCarbs = "1",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 21,
                ServingSize = "serving(0.5 oz)",
                SubItemName = "Kraft Real Mayo, Hot'n Spicy, Super Easy Squeeze",
                Calories = "100",
                TotalFat = "11",
                Cholestrol = "5",
                Sodium = "85",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 22,
                ServingSize = "tablespoon(0.5 fl.oz)",
                SubItemName = "Wegman's Classic Mayonnaise",
                Calories = "100",
                TotalFat = "11",
                Cholestrol = "5",
                Sodium = "85",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 23,
                ServingSize = "serving(0.5 oz)",
                SubItemName = "Kraft Light Mayo, Super Easy Squeeze",
                Calories = "45",
                TotalFat = "4",
                Cholestrol = "5",
                Sodium = "95",
                TotalCarbs = "2",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 24,
                ServingSize = "serving(0.5 oz)",
                SubItemName = "Kraft Real Mayo, All-Out Squeeze",
                Calories = "90",
                TotalFat = "10",
                Cholestrol = "5",
                Sodium = "70",
                TotalCarbs = "0",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
            this.SubItems.Add(new SubItemViewModel()
            {
                ItemId1 = 18,
                SubItemId = 25,
                ServingSize = "tablespoon",
                SubItemName = "Kraft Reduced-Fat, with Olive Oil",
                Calories = "45",
                TotalFat = "4",
                Cholestrol = "5",
                Sodium = "95",
                TotalCarbs = "2",
                Protein = "0",
                Calcium = "0",
                Potassium = "0"

            });
           
           #endregion

            this.IsDataLoaded = true;
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

