using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace GameHangman
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private Button btnNew;
        private Button btnExit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnNew = FindViewById<Button>(Resource.Id.btnPlay);
            btnNew.Click += (object sender, EventArgs e) =>
            {
                btnNew_Click(sender, e);
            };


            btnExit = FindViewById<Button>(Resource.Id.btnQuit);
            btnExit.Click += (object sender, EventArgs e) =>
            {
                btnExit_Click(sender, e);
            };
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Game));
            //Toast.MakeText(this, "wel come to the game ", ToastLength.Short).Show();
            Finish();
        }
    }
}