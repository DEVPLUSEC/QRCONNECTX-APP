using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace QRCONNECTX.Droid
{
    [Activity(Label = "QRCONNECTX", Icon = "@mipmap/logo_qrconnectx", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            /* ===== Inicializar funciones globales para scanner de codigos QR ===== */
            global::ZXing.Net.Mobile.Forms.Android.Platform.Init();
            ZXing.Mobile.MobileBarcodeScanner.Initialize(Application);
            /* ===== Inicializar funciones globales para scanner de codigos QR ===== */

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            /* ===== Inicializar permisos de scanner de codigos QR ===== */
            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            /* ===== Inicializar permisos de scanner de codigos QR ===== */

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}