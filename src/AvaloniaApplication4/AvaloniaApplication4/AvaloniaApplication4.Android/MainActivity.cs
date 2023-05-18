﻿using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace AvaloniaApplication4.Android
{
    [Activity(Label = "AvaloniaApplication4.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : AvaloniaMainActivity
    {
    }
}