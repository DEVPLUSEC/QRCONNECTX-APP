using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Text.RegularExpressions;
using Xamarin.Essentials;


namespace QRCONNECTX
{
    public partial class MainPage : ContentPage
    {
        /* ===== Variables Globales ===== */
        Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public MainPage()
        {
            InitializeComponent();

        }
        
        public bool ValidacionEmail(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            return EmailRegex.IsMatch(correo);


        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            bool var1 = ValidacionEmail(emailTxt.Text);

            Console.WriteLine(var1);

        }
    }
}
