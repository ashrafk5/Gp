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
using Android.Graphics;

namespace Dashboard3
{
    [Activity(Label = "newd")]
    public class newd : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.dashboard);

            TextView text1 = FindViewById<TextView>(Resource.Id.textView1);
            TextView text2 = FindViewById<TextView>(Resource.Id.textView_Account);
            TextView text3 = FindViewById<TextView>(Resource.Id.textView_courses);
            Button btn1 = FindViewById<Button>(Resource.Id.btn_AddAccount);
            Button btn2 = FindViewById<Button>(Resource.Id.btn_EditAccount);
            Button btn3 = FindViewById<Button>(Resource.Id.btn_DeleteAccount);
            Button btn4 = FindViewById<Button>(Resource.Id.btn_AssignTeacher);
            Button btn5 = FindViewById<Button>(Resource.Id.btn_ShowALLCourses);
            Button btn6 = FindViewById<Button>(Resource.Id.btn_AddCourse);
            Button btn7 = FindViewById<Button>(Resource.Id.btn_AssignTeacher);
            Button btn8 = FindViewById<Button>(Resource.Id.button8);

            btn1.Click += delegate {
                // StartActivity(typeof(addschudle));
                StartActivity(typeof(create_account));
            };

            btn6.Click += delegate {
                StartActivity(typeof(addcourse));

            };
            btn7.Click += delegate {
                StartActivity(typeof(addcourse));

            };



            var font = Typeface.CreateFromAsset(Assets, "font.ttf");
            text1.Typeface = font;
            text2.Typeface = font;
            text3.Typeface = font;
            btn1.Typeface = font;
            btn2.Typeface = font;
            btn3.Typeface = font;
            btn4.Typeface = font;
            btn5.Typeface = font;
            btn6.Typeface = font;
            btn7.Typeface = font;
            btn8.Typeface = font;

        }
    }
}