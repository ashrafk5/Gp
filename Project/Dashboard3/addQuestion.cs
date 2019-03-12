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


namespace Dashboard3
{
    [Activity(Label = "addQuestion")]
    public class addQuestion : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.addQuestions);
            string type = Intent.GetStringExtra("type");
            //FindViewById<TextView>(Resource.Id.textView1).Text = Intent.GetStringExtra("NO");
            //FindViewById<TextView>(Resource.Id.textView1).Text = type;
            if (type == "TF") FindViewById<LinearLayout>(Resource.Id.linearLayout3).Visibility = ViewStates.Visible;
            if (type == "MC") FindViewById<LinearLayout>(Resource.Id.linearLayout2).Visibility = ViewStates.Visible;

        }
    }
}