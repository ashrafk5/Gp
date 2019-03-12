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
    [Activity(Label = "dashboard")]
    public class dashboard2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.dashboard2);

            TextView text1 = FindViewById<TextView>(Resource.Id.textView1);
            TextView text2 = FindViewById<TextView>(Resource.Id.textView2);
            TextView text3 = FindViewById<TextView>(Resource.Id.textView3);
            Button btn_t_show_lecs = FindViewById<Button>(Resource.Id.btn_t_show_lecs);
            Button btn_devide_grades = FindViewById<Button>(Resource.Id.btn_devide_grades);
            Button btn_t_make_quiz = FindViewById<Button>(Resource.Id.btn_t_make_quiz);
            Button btn_edit_attendance = FindViewById<Button>(Resource.Id.btn_edit_attendance);
            Button btn_t_add_lecture = FindViewById<Button>(Resource.Id.btn_t_add_lecture);
            Button btn6 = FindViewById<Button>(Resource.Id.button6);
            Button btn7 = FindViewById<Button>(Resource.Id.button7);
            Button btn8 = FindViewById<Button>(Resource.Id.button8);


            var font = Typeface.CreateFromAsset(Assets, "font2.ttf");
            text1.Typeface = font;
            text2.Typeface = font;
            text3.Typeface = font;
            btn_t_show_lecs.Typeface = font;
            btn_devide_grades.Typeface = font;
            btn_t_make_quiz.Typeface = font;
            btn_edit_attendance.Typeface = font;
            btn_t_add_lecture.Typeface = font;
            btn6.Typeface = font;
            btn7.Typeface = font;
            btn8.Typeface = font;





            btn_devide_grades.Click += delegate {
                StartActivity(typeof(divide_grades));
            };

            btn_t_show_lecs.Click += delegate {
                StartActivity(typeof(t_show_lectures));
            };

            btn_edit_attendance.Click += delegate {
                StartActivity(typeof(t_edit_Attendence));
            };

            btn_t_add_lecture.Click += delegate {
                StartActivity(typeof(t_add_lecture));
            };

            btn_t_make_quiz.Click += delegate {
                StartActivity(typeof(t_make_quiz));
            };







        }
    }
}