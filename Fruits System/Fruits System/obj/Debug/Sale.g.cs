﻿#pragma checksum "..\..\Sale.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E9C4E2F59CC8D7D747386F6D5E7617CC0DDE5DB05168A6F89C337107BA7A8DB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fruits_System;
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


namespace Fruits_System {
    
    
    /// <summary>
    /// Sale
    /// </summary>
    public partial class Sale : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdText;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WeightText;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridView1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaleBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TotalBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Fruits System;component/sale.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sale.xaml"
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
            this.IdText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.WeightText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dataGridView1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\Sale.xaml"
            this.dataGridView1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridView1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaleBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Sale.xaml"
            this.SaleBtn.Click += new System.Windows.RoutedEventHandler(this.SaleBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TotalBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Sale.xaml"
            this.TotalBtn.Click += new System.Windows.RoutedEventHandler(this.TotalBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

