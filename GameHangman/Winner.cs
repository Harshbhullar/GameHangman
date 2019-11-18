using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android;

namespace GameHangman
{
    [Activity(Label = "Winner")]
    public class Winner : Activity
    {
        private Button btn;
        private Button btnExit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.winner);
            // Create your application here

            btn = FindViewById<Button>(Resource.Id.btnwinnerBack);
            btn.Click += (Object Sender, EventArgs ex) =>
            {
                StartActivity(typeof(MainActivity));
            };

            btnExit = FindViewById<Button>(Resource.Id.btnExit);
            btnExit.Click += (Object Sender, EventArgs ex) =>
            {
                System.Environment.Exit(0);
            };
        }
    }
}