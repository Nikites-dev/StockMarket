﻿#pragma checksum "..\..\..\Pages\Person.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "26EB21463BDB07CADA4E3351BC5F89E368076AAC45154B9E87515C36D7E7E410"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StockMarket.Pages;
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


namespace StockMarket.Pages {
    
    
    /// <summary>
    /// Person
    /// </summary>
    public partial class Person : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackBasket;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBalance;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtCount;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtAmount;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCatalog;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBusket;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Person.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listTemplate;
        
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
            System.Uri resourceLocater = new System.Uri("/StockMarket;component/pages/person.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Person.xaml"
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
            this.StackBasket = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.TxtBalance = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TxtCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TxtAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\Person.xaml"
            this.btnCatalog.Click += new System.Windows.RoutedEventHandler(this.BtnCatalog_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnBusket = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\Person.xaml"
            this.btnBusket.Click += new System.Windows.RoutedEventHandler(this.BtnBusket_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\Person.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.BtnLogOut_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listTemplate = ((System.Windows.Controls.ListView)(target));
            
            #line 59 "..\..\..\Pages\Person.xaml"
            this.listTemplate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTemplate_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
