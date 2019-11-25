using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Essentials;

namespace XamarinEssentialsProov2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView _batteryLevelTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);           

            var batteryLevelTextView = FindViewById<TextView>(Resource.Id.textView2);
            var batteryLevel = Battery.ChargeLevel;
            var state = Battery.State;
            var source = Battery.PowerSource;

            var deviceModel = DeviceInfo.Model;
            var manufacturer = DeviceInfo.Manufacturer;
            var deviceName = DeviceInfo.Name;
            var version = DeviceInfo.Version;
            var platform = DeviceInfo.Platform;
            var idiom = DeviceInfo.Idiom;
            var deviceType = DeviceInfo.DeviceType;

            System.Diagnostics.Debug.WriteLine("DeviceInfo: {0}, {1}, {2}, {3}, {4}, {5}, {6}",
                deviceModel, manufacturer, deviceName, version, platform, idiom, deviceType);

            batteryLevelTextView.Text = batteryLevel.ToString();

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;

            switch (state)
            {
                case BatteryState.Charging:
                    // Currently charging
                    break;
                case BatteryState.Full:
                    // Battery is full
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    // Currently discharging battery or not being charged
                    break;
                case BatteryState.NotPresent:
                // Battery doesn't exist in device (desktop computer)
                case BatteryState.Unknown:
                    // Unable to detect battery state
                    break;
            }

            switch (source)
            {
                case BatteryPowerSource.Battery:
                    // Being powered by the battery
                    break;
                case BatteryPowerSource.AC:
                    // Being powered by A/C unit
                    break;
                case BatteryPowerSource.Usb:
                    // Being powered by USB cable
                    break;
                case BatteryPowerSource.Wireless:
                    // Powered via wireless charging
                    break;
                case BatteryPowerSource.Unknown:
                    // Unable to detect power source
                    break;
            }


        }


        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            _batteryLevelTextView.Text = Battery.ChargeLevel.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}