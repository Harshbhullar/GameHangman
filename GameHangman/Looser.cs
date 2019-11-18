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

namespace GameHangman
{
    [Activity(Label = "Looser")]
    public class Looser : Activity
    {
        private Button btnBack;
        private Button btnExit;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Looser);

            // Create your application here
            btnBack = FindViewById<Button>(Resource.Id.btnLoserBack);
            btnBack.Click += (Object Sender, EventArgs ex) =>
            {
                StartActivity(typeof(MainActivity));
            };

            btnExit = FindViewById<Button>(Resource.Id.btnLoserExit);

            btnExit.Click += (Object Sender, EventArgs ex) =>
            {
                System.Environment.Exit(0);
            };




        }
    }
}