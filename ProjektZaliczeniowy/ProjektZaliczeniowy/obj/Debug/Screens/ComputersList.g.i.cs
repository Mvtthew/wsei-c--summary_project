﻿#pragma checksum "..\..\..\Screens\ComputersList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7586C944C09A592ECBC5645EBFAA085F412DC0650BE4B74ED46804D7E869C78"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektZaliczeniowy;
using ProjektZaliczeniowy.Screens;
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


namespace ProjektZaliczeniowy.Screens {
    
    
    /// <summary>
    /// ComputersList
    /// </summary>
    public partial class ComputersList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid computersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerAmountColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerIDColumn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerModelIdColumn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerNameColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerPriceColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerReservationPriceColumn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Screens\ComputersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn computerTypeColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjektZaliczeniowy;component/screens/computerslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Screens\ComputersList.xaml"
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
            this.computersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.computerAmountColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.computerIDColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.computerModelIdColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.computerNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.computerPriceColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.computerReservationPriceColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.computerTypeColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

