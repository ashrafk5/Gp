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
using Dashboard3;

namespace Dashboard3
{
    [Activity(Label = "divide_grades")]
    public class divide_grades : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.divide_grades);
            // Create your application here

            var txt_mid = FindViewById<EditText>(Resource.Id.txt_class_mid);
            var txt_attend = FindViewById<EditText>(Resource.Id.txt_class_attend);
            var txt_proj = FindViewById<EditText>(Resource.Id.txt_prac_proj);
            var txt_quiz = FindViewById<EditText>(Resource.Id.txt_prac_quiz);
            var btn_submit = FindViewById<Button>(Resource.Id.btn_submit);

            string mid = "";
            string attend = "";
            string quiz = "";
            string proj = "";

            btn_submit.Click += delegate {

                mid = txt_mid.Text;
                attend = txt_attend.Text;
                proj = txt_proj.Text;
                quiz = txt_quiz.Text;
                string message = mid + "/n" + attend + "/n" + proj + "/n" + quiz;

                Toast.MakeText(ApplicationContext, message, ToastLength.Long).Show();
            };

        }
    }
}