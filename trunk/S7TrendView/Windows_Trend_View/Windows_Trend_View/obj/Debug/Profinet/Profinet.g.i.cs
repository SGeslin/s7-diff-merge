﻿#pragma checksum "..\..\..\Profinet\Profinet.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD7AA472191D33C0580B746262A6A2CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Windows_Display_App;
using Windows_Trend_View.Properties;


namespace Windows_Trend_View {
    
    
    /// <summary>
    /// Profinet
    /// </summary>
    public partial class Profinet : Windows_Display_App.MenuBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Profinet\Profinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Profinet\Profinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Exit;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Profinet\Profinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Config;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Profinet\Profinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem About;
        
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
            System.Uri resourceLocater = new System.Uri("/Windows_Trend_View;component/profinet/profinet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Profinet\Profinet.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            
            #line 27 "..\..\..\Profinet\Profinet.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetErrors_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\..\Profinet\Profinet.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SetDirectory_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Exit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\..\Profinet\Profinet.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Config = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\Profinet\Profinet.xaml"
            this.Config.Click += new System.Windows.RoutedEventHandler(this.ConfigChannels_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\..\Profinet\Profinet.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DataLogging_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.About = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\..\Profinet\Profinet.xaml"
            this.About.Click += new System.Windows.RoutedEventHandler(this.About_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 45 "..\..\..\Profinet\Profinet.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetDirectory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

