using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

[assembly: UsesPermission(Android.Manifest.Permission.BatteryStats)]
namespace XamarinEssentialsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatterChargeStatusDemo : ContentPage
    {
        public BatterChargeStatusDemo()
        {
            InitializeComponent();

            txtBatteryLevel.Text = (Battery.ChargeLevel * 100).ToString();
            txtBatteryState.Text = Battery.State.ToString();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            var state = Battery.State;

            txtBatteryLevel.Text = (e.ChargeLevel * 100).ToString() + "%";
            txtBatteryState.Text = Battery.State.ToString();
        }
    }
}