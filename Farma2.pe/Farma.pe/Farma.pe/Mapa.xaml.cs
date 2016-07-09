using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Farma.pe
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();

            IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;

            if (iso.Contains("datoaeditar"))
            {
                //La pantalla carga por una edición de datos
                //Recuperamos el código del producto que está siendo editado
                string codigo;
                codigo = iso["datoaeditar"].ToString();

                try
                {
                    WebClient wc = new WebClient();
                    Uri url = new Uri("http://localhost:54970/WebAPI_Farma.pe/api/=" + codigo);

                    wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Buscar);
                    wc.DownloadStringAsync(url);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}