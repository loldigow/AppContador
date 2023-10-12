using Android.App;
using Android.Content.PM;
using Android.OS;

namespace AppFinanceiro.Droid
{
    [Activity(MainLauncher = true, 
              Label = "Contador",
              Theme = "@style/SplashTheme",
              Icon = "@mipmap/ic_launcher", 
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            OverridePendingTransition(0, 0);
            // Create your application here
        }
    }
}