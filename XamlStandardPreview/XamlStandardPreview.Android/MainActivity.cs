using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//加入 Xamarin.Forms.Alias 的參考                        
using Xamarin.Forms.Alias;

namespace XamlStandardPreview.Droid
{
    [Activity( Label = "XamlStandardPreview" , Icon = "@drawable/icon" , 
        Theme = "@style/MainTheme" , MainLauncher = true , 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate( Bundle bundle )
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate( bundle );

            global::Xamarin.Forms.Forms.Init( this , bundle );

            //加入這行
            Alias.Init();

            LoadApplication( new App() );
        }
    }
}

