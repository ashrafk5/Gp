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
    [Activity(Label = "AssignTeacher")]
    public class AssignTeacher : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.assignCourses);
            Spinner spinner;
            spinner = FindViewById<Spinner>(Resource.Id.spinner_teacher);
            var items = new List<string>() { "ahmed", "mohamed", "elsayed", "younes", "hany", "basem", "ashraf", "peter" };
            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, items);
            spinner.Adapter = adapter;

            Spinner spinner2;
            spinner2 = FindViewById<Spinner>(Resource.Id.spinner_course);
            var items2 = new List<string>() { "Graphics", "pattern", "database2", "programming", "math", "ethics" };
            var adapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, items2);
            spinner2.Adapter = adapter2;

            Button btn = FindViewById<Button>(Resource.Id.btn_assign);
            btn.Click += delegate {
                btn.Text = "clicked";
                Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                AlertDialog alert = dialog.Create();
                alert.SetTitle("Title");

                alert.SetMessage("this teacher " + spinner.SelectedItem.ToString() + " Assigned to " + spinner2.SelectedItem.ToString());

                alert.SetButton("OK", (c, ev) =>
                {
                    alert.Dispose();
                });
                alert.Show();
            };

        }
    }
}