﻿#pragma checksum "..\..\..\Gui\Clientes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBCD1E4B772231E95B03D3CC959576AEDA8CCF29D6DA1CF8BA7D81DD4698D711"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Actividad_6.Gui;
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


namespace Actividad_6.Gui {
    
    
    /// <summary>
    /// Clientes
    /// </summary>
    public partial class Clientes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApMaterno;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApPaterno;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreUsuario;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Gui\Clientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegresar;
        
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
            System.Uri resourceLocater = new System.Uri("/Actividad_6;component/gui/clientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gui\Clientes.xaml"
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
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Gui\Clientes.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.BtnAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Gui\Clientes.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.BtnBuscar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.txtApMaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtApPaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtNombreUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Gui\Clientes.xaml"
            this.btnRegresar.Click += new System.Windows.RoutedEventHandler(this.BtnRegresar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

