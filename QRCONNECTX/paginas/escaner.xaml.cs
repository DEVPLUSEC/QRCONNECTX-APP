using Newtonsoft.Json;
using QRCONNECTX.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;
using static ZXing.QrCode.Internal.Mode;
using System.Security.Cryptography;


namespace QRCONNECTX.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class escaner : ContentPage
    {
        public escaner()
        {
            InitializeComponent();
        }

        private async void escanerBtn_Clicked(object sender, EventArgs e)
        {
            try
            {

                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Escanear";
                scanner.BottomText = "Codigo QR";

                var result = await scanner.Scan();
                if (result != null)
                {
                    
                    data_usuario(result.Text);
                    
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Cerrar");
            }
        }

        public async Task data_usuario(string codigo)
        {
            HttpClient client = new HttpClient();
         

            var response = await client.GetAsync(codigo);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var contenido = await response.Content.ReadAsStringAsync();

                // Convertir la cadena JSON en un arreglo de objetos
                var jsonArray = JsonConvert.DeserializeObject<List<Equipo>>(contenido);


                

                // Recorrer el arreglo de objetos
                foreach (var equipo in jsonArray)
                {

                    nomEq.Text = equipo.nombre;
                    marEq.Text = equipo.marca;
                    carEq.Text = equipo.caracteristicas;
                    desEq.Text = equipo.descripcion;
                    Console.WriteLine("ID: " + equipo.id);
                    Console.WriteLine("Nombre: " + equipo.nombre);
                    Console.WriteLine("Tipo: " + equipo.tipo);
                    Console.WriteLine("Marca: " + equipo.marca);
                    // Resto de las propiedades...
                }

            }
           

        }
    }
}