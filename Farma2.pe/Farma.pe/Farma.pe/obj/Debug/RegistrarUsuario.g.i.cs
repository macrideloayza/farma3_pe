﻿#pragma checksum "C:\Users\Paul\Documents\GitHub\aaa\Farma2.pe\Farma.pe\Farma.pe\RegistrarUsuario.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0568B0DC5345E5E339358E8161841AEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Farma.pe {
    
    
    public partial class RegistrarUsuario : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnRegistrarse;
        
        internal System.Windows.Controls.TextBlock lblNombre;
        
        internal System.Windows.Controls.TextBlock lblApePat;
        
        internal System.Windows.Controls.TextBlock lblApeMat;
        
        internal System.Windows.Controls.TextBlock lblFecNac;
        
        internal System.Windows.Controls.TextBlock lblCorreo;
        
        internal System.Windows.Controls.TextBox txtNombre;
        
        internal System.Windows.Controls.TextBox txtApePat;
        
        internal System.Windows.Controls.TextBox txtApeMat;
        
        internal System.Windows.Controls.TextBox txtCorreo;
        
        internal Microsoft.Phone.Controls.DatePicker txtFecNac;
        
        internal System.Windows.Controls.TextBlock lblContrasena;
        
        internal System.Windows.Controls.TextBox txtContrasena;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Farma.pe;component/RegistrarUsuario.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnRegistrarse = ((System.Windows.Controls.Button)(this.FindName("btnRegistrarse")));
            this.lblNombre = ((System.Windows.Controls.TextBlock)(this.FindName("lblNombre")));
            this.lblApePat = ((System.Windows.Controls.TextBlock)(this.FindName("lblApePat")));
            this.lblApeMat = ((System.Windows.Controls.TextBlock)(this.FindName("lblApeMat")));
            this.lblFecNac = ((System.Windows.Controls.TextBlock)(this.FindName("lblFecNac")));
            this.lblCorreo = ((System.Windows.Controls.TextBlock)(this.FindName("lblCorreo")));
            this.txtNombre = ((System.Windows.Controls.TextBox)(this.FindName("txtNombre")));
            this.txtApePat = ((System.Windows.Controls.TextBox)(this.FindName("txtApePat")));
            this.txtApeMat = ((System.Windows.Controls.TextBox)(this.FindName("txtApeMat")));
            this.txtCorreo = ((System.Windows.Controls.TextBox)(this.FindName("txtCorreo")));
            this.txtFecNac = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("txtFecNac")));
            this.lblContrasena = ((System.Windows.Controls.TextBlock)(this.FindName("lblContrasena")));
            this.txtContrasena = ((System.Windows.Controls.TextBox)(this.FindName("txtContrasena")));
        }
    }
}

