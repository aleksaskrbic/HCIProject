﻿#pragma checksum "..\..\..\IstorijaPregleda.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3310426FD5ED9DC863D02CBA27B9B5EFAE686D7F"
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
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// IstorijaPregleda
    /// </summary>
    public partial class IstorijaPregleda : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\IstorijaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsers;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\IstorijaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsers_Copy;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\IstorijaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsers_Copy1;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\IstorijaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Alergeni;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\IstorijaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Propisani_Lekovi;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;V1.0.0.0;component/istorijapregleda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IstorijaPregleda.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\IstorijaPregleda.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Nazad_Na_Karton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvUsers = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.lvUsers_Copy = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.lvUsers_Copy1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.Alergeni = ((System.Windows.Controls.DataGrid)(target));
            
            #line 102 "..\..\..\IstorijaPregleda.xaml"
            this.Alergeni.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lekovi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Propisani_Lekovi = ((System.Windows.Controls.DataGrid)(target));
            
            #line 111 "..\..\..\IstorijaPregleda.xaml"
            this.Propisani_Lekovi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lekovi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

