﻿#pragma checksum "..\..\ProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1FED2F912F806871DC2B7A6B5B9E926E282A6013A7E929D9A96B3B477BE20CC4"
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
    /// ProductWindow
    /// </summary>
    public partial class ProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbProductName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbProductCode;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbPrice;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvProducts;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCotumer;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrder;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrderLine;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuyProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/Target;component/productwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductWindow.xaml"
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
            
            #line 26 "..\..\ProductWindow.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.Event_btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ProductWindow.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.Event_btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\ProductWindow.xaml"
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
            
            #line 40 "..\..\ProductWindow.xaml"
            this.lvProducts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LvProducts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCotumer = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\ProductWindow.xaml"
            this.btnCotumer.Click += new System.Windows.RoutedEventHandler(this.Event_btnCostumer_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnOrder = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\ProductWindow.xaml"
            this.btnOrder.Click += new System.Windows.RoutedEventHandler(this.Event_btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnOrderLine = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\ProductWindow.xaml"
            this.btnOrderLine.Click += new System.Windows.RoutedEventHandler(this.Event_btnOrderLine_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnBuyProduct = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\ProductWindow.xaml"
            this.btnBuyProduct.Click += new System.Windows.RoutedEventHandler(this.Event_btnBuyProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

