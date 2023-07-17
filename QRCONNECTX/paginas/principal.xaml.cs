using Newtonsoft.Json;
using QRCONNECTX.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace QRCONNECTX.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class principal : Xamarin.Forms.TabbedPage
    {
        public principal(string correo)
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetIsSmoothScrollEnabled(true);

            data_usuario(correo);



        }
        





        public async Task data_usuario(string correo)
        {
            HttpClient client = new HttpClient();

            var data = JsonConvert.SerializeObject(new { email = correo });

            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://economica.tech/QRCONNECTX/post_usuario", content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var contenido = await response.Content.ReadAsStringAsync();

                // Convertir la cadena JSON en un arreglo de objetos
                var jsonArray = JsonConvert.DeserializeObject<List<Usuario>>(contenido);

                // Recorrer el arreglo de objetos
                foreach (var usuario in jsonArray)
                {
                    Console.WriteLine("ID: " + usuario.id);
                    Console.WriteLine("Nombres: " + usuario.nombres);
                    Console.WriteLine("Apellidos: " + usuario.tipo_usuario);

                    if (usuario.tipo_usuario == 1 || usuario.tipo_usuario == '1')
                    {
                        
                    }
                    else
                    {
                        this.Children.Remove(otrosTab);
                    }
                }

            }

        }
    }
}