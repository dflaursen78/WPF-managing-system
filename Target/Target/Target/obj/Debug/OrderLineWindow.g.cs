﻿#pragma checksum "..\..\OrderLineWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1D43969B099E970E862C834912B48EEE9A567C239BCD3C1962BB0B3E50CAE3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using Target;


namespace Target {
    
    
    /// <summary>
    /// OrderLineWindow
    /// </summary>
    public partial class OrderLineWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\OrderLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvOrderLine;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\OrderLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductLine;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\OrderLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrders;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\OrderLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCostumer;
        
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
            System.Uri resourceLocater = new System.Uri("/Target;component/orderlinewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrderLineWindow.xaml"
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
            this.lvOrderLine = ((System.Windows.Controls.ListView)(target));
            
            #line 27 "..\..\OrderLineWindow.xaml"
            this.lvOrderLine.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LvOrderLine_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnProductLine = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\OrderLineWindow.xaml"
            this.btnProductLine.Click += new System.Windows.RoutedEventHandler(this.BtnProductLine_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnOrders = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\OrderLineWindow.xaml"
            this.btnOrders.Click += new System.Windows.RoutedEventHandler(this.BtnOrders_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCostumer = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\OrderLineWindow.xaml"
            this.btnCostumer.Click += new System.Windows.RoutedEventHandler(this.BtnCostumer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

