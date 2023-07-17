using Acr.UserDialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRCONNECTX.paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class inicio_sesion : ContentPage
	{
        /* ===== Variables Globales ===== */
        Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        /* ===== Funcion main de inicio de sesion ===== */
        public inicio_sesion ()
		{
			InitializeComponent ();
		}

        /* ===== Funcion de validacion de correo ===== */
        public bool validacion_correo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                emailFra.BorderColor = Color.Red;
                emailSpa.IsVisible = true;
                return false;
            }
            else
            {
                emailFra.BorderColor = Color.Green;
                emailSpa.IsVisible = false;
                return EmailRegex.IsMatch(correo);
            }

        }

        /* ===== Funcion de validacion de correo ===== */
        public bool validacion_password(string contrasenia)
        {

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                passFra.BorderColor = Color.Red;
                passSpa.IsVisible = true;
                return false;
            }
            else
            {
                passFra.BorderColor = Color.Green;
                passSpa.IsVisible = false;
                return true;
            }

           

        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            bool var1 = validacion_correo(emailTxt.Text);
            bool var2 = validacion_password(passTxt.Text);

            Console.WriteLine("correo:" + var1);
            Console.WriteLine("contraseña:" + var2);

            if (var1 == true && var2 == true)
            {
                dataSpa.IsVisible = false;
                comprobar(emailTxt.Text, passTxt.Text);
            }

        }

        private async Task comprobar(string username, string password)
        {

           

            HttpClient client = new HttpClient();
            
            var data = JsonConvert.SerializeObject(new { email = username, password = password });
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://economica.tech/QRCONNECTX/iniciar-sesion-app", content);
            var result = JsonConvert.DeserializeObject<String>(response.Content.ReadAsStringAsync().Result);

            Console.WriteLine(result.ToString());



            dataSpa.TextColor = Color.Red;

            switch (result.ToString())
            {
                case "1":
                    Console.WriteLine("Datos validos");
                   
                    Navigation.PushAsync(new principal(username));
                    break;
                case "2": 
                    dataSpa.Text = "Contraseña incorrecta";
                    dataSpa.IsVisible = true;
                    break;
                case "3":
                    dataSpa.Text = "Usuario desactivado";
                    dataSpa.IsVisible = true;
                    break;
                case "4":
                    dataSpa.Text = "Usuario no registrado";
                    dataSpa.IsVisible = true;
                    break;
            }






        }
    }
}