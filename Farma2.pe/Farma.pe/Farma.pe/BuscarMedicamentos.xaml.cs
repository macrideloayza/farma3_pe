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
using System.IO.IsolatedStorage;

namespace Farma.pe
{
    public partial class BuscarMedicamentos : PhoneApplicationPage
    {
        public BuscarMedicamentos()
        {
            InitializeComponent();
            listarMedicamentos();
        }

        private void listarMedicamentos()
        {
            try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54970/WebAPI_Farma.pe/api/Medicamento/");

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
                List<Medicamento> arr = JsonConvert.DeserializeObject<List<Medicamento>>(e.Result);


                for (int i = 0; i < arr.Count(); i++)
                {
                    int codigo = arr.ElementAt(i).ID_MED;
                    arr.ElementAt(i).rutaFlecha = "/imagenes/flechaDerecha.png";
                    arr.ElementAt(i).rutaImagen = "/imagenes/"+ codigo.ToString().ElementAt(codigo.ToString().Length-1) +".png";
                }

                
                lbMedicamento.ItemsSource = arr;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void txtFiltro_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
           
        }

        private void txtFiltro_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54970/WebAPI_Farma.pe/api/Medicamento?filtro=" + txtFiltro.Text);

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Listar);
                wc.DownloadStringAsync(url);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lbMedicamento_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var medicamento = ((ListBox)sender).SelectedItem as Medicamento;

            int codigo = medicamento.ID_MED;

            IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;

            if (!iso.Contains("datoaeditar"))
            {
                iso.Add("datoaeditar", codigo);
            }
            else
            {
                iso["datoaeditar"] = codigo;
            }
            iso.Save();

            NavigationService.Navigate
                   (new Uri("/Mapa.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}