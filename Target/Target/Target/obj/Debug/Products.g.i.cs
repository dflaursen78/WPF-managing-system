﻿#pragma checksum "..\..\Products.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCFBDC823D549F98B9960A5A9B5679303715179B79A900C695BA8E45D0EC327D"
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
    /// Products
    /// </summary>
    public partial class Products : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbProductName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbProductCode;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbPrice;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvProducts;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCotumer;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrder;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrderList;
        
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
            System.Uri resourceLocater = new System.Uri("/Target;component/products.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Products.xaml"
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
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Products.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.Event_btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Products.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.Event_btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Products.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.Event_btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtbProductName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtbProductCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtbPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lvProducts = ((System.Windows.Controls.ListView)(target));
            
            #line 40 "..\..\Products.xaml"
            this.lvProducts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvProducts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCotumer = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Products.xaml"
            this.btnCotumer.Click += new System.Windows.RoutedEventHandler(this.Event_btnCostumer_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnOrder = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Products.xaml"
            this.btnOrder.Click += new System.Windows.RoutedEventHandler(this.Event_btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnOrderList = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Products.xaml"
            this.btnOrderList.Click += new System.Windows.RoutedEventHandler(this.Event_btnOrderList_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

