﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75B94B316A3B590FA6D604BC8605986231C964E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PracticeWPFBivlioteka;
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


namespace PracticeWPFBivlioteka {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SerializedBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SerializedBtn1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeserializedBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTxb;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurNameTxb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TelephoneTxb;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PracticeWPFBivlioteka;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SerializedBtn = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SerializedBtn1 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.SerializedBtn1.Click += new System.Windows.RoutedEventHandler(this.SerializedBtn1_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeserializedBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.DeserializedBtn.Click += new System.Windows.RoutedEventHandler(this.DeserializedBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SurNameTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TelephoneTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
