﻿#pragma checksum "C:\Users\Zoya\Documents\GitHub\MFD\Repository\My Fitness Doctor\Views\BMIAbout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "484AF7874B73A9D9DF832ACB859DBBB2"
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
    
    
    public partial class BMIAbout : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image logo;
        
        internal System.Windows.Controls.Grid Details;
        
        internal System.Windows.Controls.TextBlock PageName;
        
        internal System.Windows.Controls.TextBlock Description;
        
        internal System.Windows.Controls.TextBlock ColumnHeadings;
        
        internal System.Windows.Controls.TextBlock Underweight;
        
        internal System.Windows.Controls.TextBlock OverWeight;
        
        internal System.Windows.Controls.TextBlock Normal;
        
        internal System.Windows.Controls.TextBlock UnderweightRange;
        
        internal System.Windows.Controls.TextBlock NormalRange;
        
        internal System.Windows.Controls.TextBlock OverWeightRange;
        
        internal System.Windows.Controls.Border HeadingBorder;
        
        internal System.Windows.Controls.Border Row1Border;
        
        internal System.Windows.Controls.Border Row2Border;
        
        internal System.Windows.Controls.Border Row3Border;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton close;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/My%20Fitness%20Doctor;component/Views/BMIAbout.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.logo = ((System.Windows.Controls.Image)(this.FindName("logo")));
            this.Details = ((System.Windows.Controls.Grid)(this.FindName("Details")));
            this.PageName = ((System.Windows.Controls.TextBlock)(this.FindName("PageName")));
            this.Description = ((System.Windows.Controls.TextBlock)(this.FindName("Description")));
            this.ColumnHeadings = ((System.Windows.Controls.TextBlock)(this.FindName("ColumnHeadings")));
            this.Underweight = ((System.Windows.Controls.TextBlock)(this.FindName("Underweight")));
            this.OverWeight = ((System.Windows.Controls.TextBlock)(this.FindName("OverWeight")));
            this.Normal = ((System.Windows.Controls.TextBlock)(this.FindName("Normal")));
            this.UnderweightRange = ((System.Windows.Controls.TextBlock)(this.FindName("UnderweightRange")));
            this.NormalRange = ((System.Windows.Controls.TextBlock)(this.FindName("NormalRange")));
            this.OverWeightRange = ((System.Windows.Controls.TextBlock)(this.FindName("OverWeightRange")));
            this.HeadingBorder = ((System.Windows.Controls.Border)(this.FindName("HeadingBorder")));
            this.Row1Border = ((System.Windows.Controls.Border)(this.FindName("Row1Border")));
            this.Row2Border = ((System.Windows.Controls.Border)(this.FindName("Row2Border")));
            this.Row3Border = ((System.Windows.Controls.Border)(this.FindName("Row3Border")));
            this.close = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("close")));
        }
    }
}

