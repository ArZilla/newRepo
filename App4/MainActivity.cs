using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App4
{
    [Activity(Label = "App4", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    { 

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.calculateButton);
            var firstArgument = FindViewById<EditText>(Resource.Id.firstArgument);
            var secondArgument = FindViewById<EditText>(Resource.Id.secondArgument);
            var result = FindViewById<TextView>(Resource.Id.result);


            button.Click += (sender, args) =>
            {
                if (String.IsNullOrEmpty(firstArgument.Text) || String.IsNullOrEmpty(secondArgument.Text))
                    return;

                int first, second;

                if (!Int32.TryParse(firstArgument.Text, out first))
                    return;

                if (!Int32.TryParse(secondArgument.Text, out second))
                    return;

                result.Text = (first + second).ToString();
            };
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

