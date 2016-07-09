using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Farma.pe.models;
using Newtonsoft.Json;

namespace Farma.pe
{
    public partial class BuscarFarmacias : PhoneApplicationPage
    {
        public BuscarFarmacias()
        {
            InitializeComponent();
            listarFarmacias();
        }

        private void listarFarmacias()
        {

            try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54973/WebAPI_Farma.pe/api/FARMACIA/");

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Listar);
                wc.DownloadStringAsync(url);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Listar(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                List<Farmacia> lista = JsonConvert.DeserializeObject<List<Farmacia>>(e.Result);

                for (int i = 0; i < lista.Count(); i++)
                {
                    lista.ElementAt(i).rutaFlecha = "/imagenes/flechaDerecha.png";
                    lista.ElementAt(i).rutaImagen = "/imagenes/farmacias/" + lista.ElementAt(i).ID_FAR + ".png" ;
                }

                lbFarmacia.ItemsSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {

            listarFarmaciasXFiltro();
        }

        private void listarFarmaciasXFiltro()
        {

            string filtro = txtFiltro.Text;

            try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54973/WebAPI_Farma.pe/api/FARMACIA/?filtro=" + filtro);

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Listar);
                wc.DownloadStringAsync(url);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tapBuscar(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }
    }
}