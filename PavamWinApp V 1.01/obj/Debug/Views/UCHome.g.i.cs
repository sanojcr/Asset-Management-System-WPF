﻿#pragma checksum "..\..\..\Views\UCHome.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89A69D77D54ADA1DB4E4F00D6A6291C2D4B5771CB9273FCE94FC6B97180571F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PavamWinApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace PavamWinApp {
    
    
    /// <summary>
    /// UCHome
    /// </summary>
    public partial class UCHome : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel UCHomeSP;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameLb;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimize;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Maximize;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Signout;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MenuSP;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\UCHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PavamWinApp;component/views/uchome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UCHome.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UCHomeSP = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 35 "..\..\..\Views\UCHome.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameLb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Minimize = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Maximize = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Signout = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Views\UCHome.xaml"
            this.Signout.Click += new System.Windows.RoutedEventHandler(this.Signout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenuSP = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\Views\UCHome.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Views\UCHome.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

