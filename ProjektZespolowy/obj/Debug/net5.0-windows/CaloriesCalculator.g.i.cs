﻿#pragma checksum "..\..\..\CaloriesCalculator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9D414CF0F1506B72BF028677CBA0D793EB40D3DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektZespolowy;
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


namespace ProjektZespolowy {
    
    
    /// <summary>
    /// CaloriesCalculator
    /// </summary>
    public partial class CaloriesCalculator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\CaloriesCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_summary;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CaloriesCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_back;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CaloriesCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_wynik;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\CaloriesCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_value;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\CaloriesCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_add;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CaloriesCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_equals;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjektZespolowy;component/caloriescalculator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CaloriesCalculator.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CaloriesCalculator.xaml"
            ((ProjektZespolowy.CaloriesCalculator)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lb_summary = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.b_back = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\CaloriesCalculator.xaml"
            this.b_back.Click += new System.Windows.RoutedEventHandler(this.b_back_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_wynik = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_value = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.b_add = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\CaloriesCalculator.xaml"
            this.b_add.Click += new System.Windows.RoutedEventHandler(this.b_add_click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b_equals = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\CaloriesCalculator.xaml"
            this.b_equals.Click += new System.Windows.RoutedEventHandler(this.b_equals_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

