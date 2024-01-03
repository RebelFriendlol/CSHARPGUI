﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70BB9BAC811C0962CEED1F8FA88FC8BC4A4F3F84"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using AlbertoPlayer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AlbertoPlayer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Previous;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Forward;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Randomize;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Repeat;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button libraryButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playlistButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button settingsButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shopButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AlbertoPlayer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Previous = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.Previous.Click += new System.Windows.RoutedEventHandler(this.Previous_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Forward = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.Forward.Click += new System.Windows.RoutedEventHandler(this.Forward_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Randomize = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.Randomize.Click += new System.Windows.RoutedEventHandler(this.Randomize_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Repeat = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\MainWindow.xaml"
            this.Repeat.Click += new System.Windows.RoutedEventHandler(this.Repeat_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.libraryButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.libraryButton.Click += new System.Windows.RoutedEventHandler(this.LibraryClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.playlistButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.playlistButton.Click += new System.Windows.RoutedEventHandler(this.PlaylistClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.settingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.settingsButton.Click += new System.Windows.RoutedEventHandler(this.SettingsClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.shopButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.shopButton.Click += new System.Windows.RoutedEventHandler(this.ShopClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

