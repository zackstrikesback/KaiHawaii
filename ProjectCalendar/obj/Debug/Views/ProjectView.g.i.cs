﻿#pragma checksum "..\..\..\Views\ProjectView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9A39F64FE9F61D23671179157FEFB04D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectCalendar.ViewModel;
using ProjectCalendar.Views;
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


namespace ProjectCalendar.Views {
    
    
    /// <summary>
    /// ProjectView
    /// </summary>
    public partial class ProjectView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox uxTaskList;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid uxDisplay;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uxDue;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxNotes;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox uxEmpList;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox uxEmpCombo;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker uxDate;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\ProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectCalendar;component/views/projectview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProjectView.xaml"
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
            this.uxTaskList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.uxDisplay = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.uxDue = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.uxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.uxNotes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.uxEmpList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.uxEmpCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.uxDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

