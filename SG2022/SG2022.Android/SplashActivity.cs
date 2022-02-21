using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;

namespace SG2022.Droid
{
    [Activity(Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { this.SimulateStartup(); });
            startupWork.Start();
        }

        private async void SimulateStartup()
        {
            await Task.Delay(100);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
