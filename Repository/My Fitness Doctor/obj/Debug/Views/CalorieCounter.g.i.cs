﻿#pragma checksum "C:\Users\Zoya\Documents\GitHub\MFD\Repository\My Fitness Doctor\Views\CalorieCounter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4CF9EC66AC42CCDFCE2D5F5E66202772"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace My_Fitness_Doctor.Views {
    
    
    public partial class CalorieCounter : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image logo;
        
        internal System.Windows.Controls.Grid MainItemsContentPannel;
        
        internal System.Windows.Controls.ListBox MainItemsListBox;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Pin;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton about;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton search;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton settings;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/My%20Fitness%20Doctor;component/Views/CalorieCounter.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.logo = ((System.Windows.Controls.Image)(this.FindName("logo")));
            this.MainItemsContentPannel = ((System.Windows.Controls.Grid)(this.FindName("MainItemsContentPannel")));
            this.MainItemsListBox = ((System.Windows.Controls.ListBox)(this.FindName("MainItemsListBox")));
            this.Pin = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Pin")));
            this.about = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("about")));
            this.search = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("search")));
            this.settings = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("settings")));
        }
    }
}

