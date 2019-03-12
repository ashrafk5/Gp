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
    [Activity(Label = "t_make_quiz")]
    public class t_make_quiz : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.t_make_quiz);

            Spinner spinner1;
            spinner1 = FindViewById<Spinner>(Resource.Id.spinner1);
            var items1 = new List<string>() { "lecture1", "lecture2", "lecture3", "lecture4" };
            var adapter1 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, items1);
            spinner1.Adapter = adapter1;


            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate {
                RadioButton RB1 = FindViewById<RadioButton>(Resource.Id.radioButton1);
                RadioButton RB2 = FindViewById<RadioButton>(Resource.Id.radioButton2);

                var activity = new Intent(this, typeof(addQuestion));

                //  activity.PutExtra("NO", FindViewById<EditText>(Resource.Id.ed).Text);
                if (RB2.Checked) activity.PutExtra("type", "TF");
                if (RB1.Checked) activity.PutExtra("type", "MC");

                StartActivity(activity);
            };
        }
    }
}