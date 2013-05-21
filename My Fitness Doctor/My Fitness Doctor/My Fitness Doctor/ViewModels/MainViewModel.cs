using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace My_Fitness_Doctor
{
    #region | MainViewModel Class |

    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            this.Items1 = new ObservableCollection<ItemViewModel>();

        }

        public ObservableCollection<ItemViewModel> Items { get; private set; }
        public ObservableCollection<ItemViewModel> Items1 { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";

        public ItemViewModel GetItem(int itemId)
        {
            foreach (ItemViewModel item in this.Items)
            {
                if (item.ItemId == itemId)
                {
                    return item;
                }
            }
            return null;
        }

        #region | Properties |

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

        public void LoadData()
        {
            #region | CalorieCounter MainItems |

            // Sample data; replace with real data

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Fruits",
                itemdescription = "Apples , Cherries , Peaches , Bananas , Oranges ",
                ItemId = 1,
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Fruits.png",
                Color = "#FFB85CFF"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Vegetables",
                itemdescription = "Onion , Peas , Carrots , Cabbage , Potatoes , Asparagus,raw",
                ItemId = 2,
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Vegetables.png",
                Color = "#FF9741D8"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Poultry",
                itemdescription = "Drumsticks , Wings , Honey BBQ Glazed , Deviled Egg , cooked",
                ItemId = 3,
                Color = "#FFCF23FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Poultry.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Chicken",
                itemdescription = "Fried Eggs , Omelet , Scrambled Eggs , Cheese , Breast, with skin",
                ItemId = 4,
                Color = "#FFD137FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Chicken.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Sausages",
                itemdescription = "Ham, minced , Headcheese (Brawn) , Corn Dogs, Beef ",
                ItemId = 5,
                Color = "#FFB566FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Sausages.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Seafoods",
                itemdescription = "Bass, Sea, cooked with dry heat , Rib, lean only, broiled , Salmon",
                ItemId = 6,
                Color = "#FF7588FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Seafoods.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Cakes",
                itemdescription = "Pie Crust, baked Brownie, dry , Fudge Nut Brownie",
                ItemId = 7,
                Color = "#FFA993FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Cakes.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Meats",
                itemdescription = "Brisket, lean , braised , lean only , Rabbit, raw",
                ItemId = 8,
                Color = "#FFA084FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Meats.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Soups",
                itemdescription = "Bean w. Bacon, dehydrated, dry , Cream of Celery , Fuyu",
                ItemId = 9,
                Color = "#FF8F7CD8",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/SoupAndTofu.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Fast Foods",
                itemdescription = "Appetizer Sampler , Sandwich , Nachos, Chili Cheese",
                ItemId = 10,
                Color = "#FFC570FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/fast foods.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Desserts",
                itemdescription = "Gelatin Mix, Reduced Calorie , Pie Crust, baked",
                ItemId = 11,
                Color = "#FFB17FC6",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/DessertsAndPies.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Drinks(Alcohol)",
                itemdescription = "Coke , Bloody Mary , Brandy Alexander ",
                ItemId = 12,
                Color = "#FFA65FD9",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/AlcoholicDrinks.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Breads",
                itemdescription = "Bread Stuffing , Biscuit, Plain or Buttermilk , Croutons",
                ItemId = 13,
                Color = "#FF8D50B7",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/BreadsProducts.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Snacks",
                itemdescription = "Fruit Flavored Shapes, Sunkist, Mixed Fruit , Mini Chips ",
                ItemId = 14,
                Color = "#FFCE1DFF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Snacks.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Rice and Pasta",
                itemdescription = "Long Grain Brown Rice, cooked, White Glutinous Rice ",
                ItemId = 15,
                Color = "#FFC578CC",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Rice and pasta.png"
            });
            
            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Intl. Foods",
                itemdescription = "Chicken Katsu, Beef Lasagna , Sushi Rolls, Small, Cucumber",
                ItemId = 16,
                Color = "#FFC62FD2",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/InternationalFoods.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Beverages",
                itemdescription = "Signature Ground Coffee , French Vanilla Latte , Milk",
                ItemId = 17,
                Color = "#FFB814FF",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Beverages.png"
            });

            this.Items.Add(new ItemViewModel()
            {
                mainitems = "Dressings",
                itemdescription = "Mayonnaise , Safflower Oil , Fat-Free Mayo , Blue Cheese ",
                ItemId = 18,
                Color = "#FF8A17D4",
                ItemImage = "/Images/CalorieCounter/MainItemsTile/Dressings.png"
            });

            #endregion

            #region| HealthTips SampleDat |

            #region| Eyes |

            // Sample data; replace with real data
            this.Items1.Add(new ItemViewModel() { Header = "◆ Eat right to protect your sight:", Tip = "You’ve heard carrots are good for your eyes. But eating a diet rich in fruits and vegetables, particularly dark leafy greens such as spinach, kale, or collard greens is important for keeping your eyes healthy, too.i Research has also shown there are eye health benefits from eating fish high in omega-3 fatty acids, such as salmon, tuna, and halibut." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Maintain a healthy weight:", Tip = "Being overweight or obese increases your risk of developing diabetes and other systemic conditions, which can lead to vision loss, such as diabetic eye disease or glaucoma. If you are having trouble maintaining a healthy weight, talk to your doctor." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Wear protective eyewear:", Tip = "Wear protective eyewear when playing sports or doing activities around the home. Protective eyewear includes safety glasses and goggles, safety shields, and eye guards specially designed to provide the correct protection for a certain activity. Most protective eyewear lenses are made of polycarbonate, which is 10 times stronger than other plastics. Many eye care providers sell protective eyewear, as do some sporting goods stores." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Quit smoking or never start:", Tip = "Smoking is as bad for your eyes as it is for the rest of your body. Research has linked smoking to an increased risk of developing age-related macular degeneration, cataract, and optic nerve damage, all of which can lead to blindness." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Be cool and wear your shades:", Tip = "Sunglasses are a great fashion accessory, but their most important job is to protect your eyes from the sun’s ultraviolet rays. When purchasing sunglasses, look for ones that block out 99 to 100 percent of both UV-A and UV-B radiation." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Give your eyes a rest:", Tip = "If you spend a lot of time at the computer or focusing on any one thing, you sometimes forget to blink and your eyes can get fatigued. Try the 20-20-20 rule: Every 20 minutes, look away about 20 feet in front of you for 20 seconds. This can help reduce eyestrain." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Clean your hands and your contact lenses properly:", Tip = "To avoid the risk of infection, always wash your hands thoroughly before putting in or taking out your contact lenses. Make sure to disinfect contact lenses as instructed and replace them as appropriate." });
            this.Items1.Add(new ItemViewModel() { Header = "◆ Practice workplace eye safety:", Tip = "Employers are required to provide a safe work environment. When protective eyewear is required as a part of your job, make a habit of wearing the appropriate type at all times and encourage your coworkers to do the same." });

            #endregion

            #region | Heart |

            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Healthy balanced diet", HeartTip = "Eat a healthy, balanced diet including a variety of foods. Eat smaller, more regular meals. Include at least 5 servings of fruits and vegetables every day." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Choose the Heart Mark", HeartTip = "Choose the Heart Mark when shopping, look out for products bearing the Heart Mark logo as these are better, heart healthier food choices i.e. lower in saturated fat, cholesterol, salt and sugar and often higher in fibre." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Avoid red meat", HeartTip = "Try to include fatty fish as part of your diet at least twice a week. And limit the intake of red meat to 2-3 times per week." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Avoid refined foods", HeartTip = "Limit the intake of refined and sugary foods." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Heart attack? Act quickly!", HeartTip = "Act quickly on the following symptoms: a pressing pain in the centre of the chest that spreads to the arms and/or jaw, anxiousness, nausea, a pale, grey complexion, a rapid pulse and profuse sweating. This is an emergency and the person must be rapidly diagnosed and treated in hospital. Treatment with “clot-busting” medication within the first two to four hours of the heart attack decreases the chances of early death from abnormal heart rhythms, so it is very important to get the patient to a hospital as soon as possible." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Take good fats", HeartTip = "Eat fats sparingly, limiting ‘bad’ fats and including more ‘good’ fats in your diet." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Avoid cholesterol-rich foods", HeartTip = "Limit your daily intake of foods high in cholesterol such as egg yolks, organ meats, calamari, shrimps and prawns." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Drink milk", HeartTip = "Have at least 2 servings of low fat milk/dairy products every day." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Avoid much sault", HeartTip = "Use salt sparingly. Intake should be limited to 1 teaspoon a day (6g), remembering that processed foods also contain a lot of hidden salts." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Avoid alcohol", HeartTip = "If you drink alcohol, do so in moderation. Limit to 1 drink/day in women and 2 drinks/day in men." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Control your weight", HeartTip = "Control your weight through regular physical activity - aim for 30 minutes 5 times a week." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Stay calm", HeartTip = "Manage stress. High stress is often linked to cardiovascular events." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Quit smoking", HeartTip = "Quit smoking or don’t even start." });
            this.Items1.Add(new ItemViewModel() { HeartTipHeader = "◆ Know your numbers", HeartTip = "Know your numbers i.e. blood pressure, cholesterol and BMI." });


            #endregion

            #region | Skin |

            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Sugar mask with lemon peels", SkinTip = "Take equal proportions of grained sugar and powered lemon peel, mix them with a bit of milk and make a fine paste, apply it on your face and when it dries wash off with fresh water. If you apply it at least once in a week, it not only smoothes your skin but also adds shine and brightens your complexion." });
            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Tomato and Lime juice", SkinTip = "Take one tomato and add 2-3 drops of lime juice. Apply on your face and wash off till dry after 15 to 20 minutes. You will see a slight shine in just one go. If you will do it twice in a week, you will definitely feel the difference." });
            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Wheat flour and vinegar paste", SkinTip = "Apply a paste of wheat flour with vinegar on your face with the very light and soft pat. Wash your face with fresh water when dries. It helps you to remove freckles and dark sports." });
            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Lime juice and honey paste", SkinTip = "Mix lime juice, honey and egg white, apply it on your face and let it dry for few minutes and then washout. It will make your skin soft and smooth." });
            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Rose water and glycerin, ", SkinTip = "Make a mixture of rose water, glycerin and lemon juice. Apply this lotion on your face, arms and even feet, especially before going to bed at night. Regular application of this lotion will surely give your face a beautiful glow." });
            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Avoid washing your face with makeup!", SkinTip = " You can simply use rose water as best toner, after cleansing, after removing your make up, before going to bed, or just to fresh your face." });
            this.Items1.Add(new ItemViewModel() { SkinTipHeader = "◆ Cucumber mask", SkinTip = "Cucumber mask helps you to make your skin glowing and attractive." });


            #endregion

            #region | Brain |

            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Make sure you’re getting enough rest.", BrainTip = "Sleep is the body’s way of recharging, meaning that sleep doesn’t only increase your energy—it actually boosts your mental health." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Feel what you feel!", BrainTip = "Don't worry about controlling or changing your feelings. For now, focus on expressing the feelings that you have rather than trying to feel a certain way." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Forgive yourself for past mistakes. ", BrainTip = "Messing up is a part of life, and mental health requires understanding that and moving past mistakes in our lives. Is there a mistake or regret that eats at you? Let. It. Go." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Throw a mini-party for yourself!", BrainTip = "Celebrate a recent accomplishment in your life by patting yourself on the back and rewarding yourself with a small gift you've been looking forward to. It's important to acknowledge successes-- not just failures." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Find a good support system.", BrainTip = "Whether family, friends, a church, or something else, find a group of people who are willing to love you for who you are. This boosts resilience and helps to provide perspective in the midst of stress and pain." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Eat healthy. ", BrainTip = "Invest time in learning which kinds of foods bring you “up” and which kinds bring you “down.” Committing to a diet can make you feel good about yourself, give you a sense of self-improvement, and boost your sense of accomplishment." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Exercise.", BrainTip = "Regularly exercising can help to cut back stress in your life, releasing pent up energy as you work your body. Exercise releases endorphins, chemicals in the brain that energize us." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Get some sun.", BrainTip = "Sunlight can lift one’s spirits, boosting mental health and preventing depression." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Leave some time for leisure.", BrainTip = "Make sure you allow time in your schedule for whatever causes you to relax. Maybe it's watching movies or completing crossword puzzles or walking outside. Make time for the things you know relax you." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Stay away from drugs and alcohol.", BrainTip = "When you consume cigarettes, illegal drugs, and alcohol, these drugs tamper with your mental health, decreasing mental stability and giving you “false positive” emotions." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Commit to helping others", BrainTip = "You can build self-esteem and self-worth by regularly pouring out your energy and talents to help others. Volunteering is another activity that releases endorphins, boosting your mood." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Do things that require discipline", BrainTip = "Self-control increases self-worth, as you feel like you can control aspects of your life." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Learn something new!", BrainTip = "Part of what makes us human is our tendency to challenge ourselves. Challenge yourself to learn something new-- maybe a new skill, sport, or game." });
            this.Items1.Add(new ItemViewModel() { BrainTipHeader = "◆ Spend time enjoying art", BrainTip = "Studying artwork exercises our minds and encourages us to think creatively. Take some time to visit a gallery or an art show-- you may return with a new perspective on your situation." });


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

    #endregion
}
