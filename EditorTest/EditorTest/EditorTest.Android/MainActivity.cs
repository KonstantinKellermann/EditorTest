using Android.App;
using Android.Content.PM;
using Android.OS;

namespace EditorTest.Droid
{
    [Activity(Label = "EditorTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}