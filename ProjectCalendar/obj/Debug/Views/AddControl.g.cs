﻿#pragma checksum "..\..\..\Views\AddControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20396E78B86B38CFE4BAF14BD65BFFF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectCalendar;
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


namespace ProjectCalendar {
    
    
    /// <summary>
    /// AddControl
    /// </summary>
    public partial class AddControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// AddCont Name Field
        /// </summary>
        
        #line 3 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public ProjectCalendar.AddControl AddCont;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uxDue;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxNotes;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox uxEmpList;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox uxEmpCombo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\AddControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker uxDate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\AddControl.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProjectCalendar;component/views/addcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddControl.xaml"
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
            this.AddCont = ((ProjectCalendar.AddControl)(target));
            
            #line 10 "..\..\..\Views\AddControl.xaml"
            this.AddCont.Loaded += new System.Windows.RoutedEventHandler(this.AddCont_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxDue = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.uxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uxNotes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.uxEmpList = ((System.Windows.Controls.ListBox)(target));
            
            #line 31 "..\..\..\Views\AddControl.xaml"
            this.uxEmpList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.uxEmpList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.uxEmpCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\Views\AddControl.xaml"
            this.uxEmpCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.uxEmpCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.uxDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 38 "..\..\..\Views\AddControl.xaml"
            this.uxDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.uxDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\..\Views\AddControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 40 "..\..\..\Views\AddControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Views\AddControl.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

