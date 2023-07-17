using Newtonsoft.Json;
using QRCONNECTX.modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static ZXing.QrCode.Internal.Mode;
using System.Diagnostics;

namespace QRCONNECTX.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class equipos : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public equipos()
        {
            InitializeComponent();

           data_usuario();
        }

        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            

            string action = await DisplayActionSheet("Opciones:", "Cancelar", null, "Editar", "Eliminbar");
            Debug.WriteLine("Action: " + action);

            if (action == "Editar")
            {

            }
            else
            {

            }


            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        public async Task data_usuario()
        {
            HttpClient client = new HttpClient();


            var response = await client.GetAsync("https://economica.tech/QRCONNECTX/get_equipo");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var contenido = await response.Content.ReadAsStringAsync();

                // Convertir la cadena JSON en un arreglo de objetos
                var jsonArray = JsonConvert.DeserializeObject<List<Equipo>>(contenido);

                listaEquipos.ItemsSource = jsonArray;





            }


        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}