﻿#pragma checksum "..\..\UART.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A1EABB330DB6D824802E040F32BD71D8FE4C8EC5D321C3A93A3A2BD6F7E2519F"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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


namespace Wpf_UART {
    
    
    /// <summary>
    /// UART
    /// </summary>
    public partial class UART : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\UART.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox txListBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\UART.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uartTxTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\UART.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox rxListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_UART;component/uart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UART.xaml"
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
            
            #line 10 "..\..\UART.xaml"
            ((System.Windows.Controls.Grid)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.uartTxTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            
            #line 37 "..\..\UART.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSend_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uartTxTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\UART.xaml"
            this.uartTxTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            
            #line 39 "..\..\UART.xaml"
            this.uartTxTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.uartTxTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rxListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            
            #line 48 "..\..\UART.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Open_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 49 "..\..\UART.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 50 "..\..\UART.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 56 "..\..\UART.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Translate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 57 "..\..\UART.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_ClearCommunication_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

