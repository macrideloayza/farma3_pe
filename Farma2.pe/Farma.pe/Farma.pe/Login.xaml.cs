using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Farma.pe.Resources;

using Newtonsoft.Json;
using Farma.pe.models;

namespace Farma.pe
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            validarUsuario();
        }

        private void validarUsuario()
        {

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Password;
            if (usuario == String.Empty || contrasena == String.Empty)
            {
                MessageBox.Show("Debe ingresar el usuario y la contraseña");
            }
            else
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54973/api/USUARIO?usuario=" + usuario + "&pass=" + contrasena);

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Buscar);
                wc.DownloadStringAsync(url);
            }
        }

        private void Buscar(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                List<Usuario> respuesta = JsonConvert.DeserializeObject<List<Usuario>>(e.Result);

                if (respuesta.Count > 0)
                {
                    Usuario usuario = respuesta.ElementAt(0);
                    NavigationService.Navigate(new Uri("/MenuPrincipal.xaml", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarte_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegistrarUsuario.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}