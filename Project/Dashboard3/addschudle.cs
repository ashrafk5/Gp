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
using static Android.App.DatePickerDialog;

namespace Dashboard3.Resources
{
    [Activity(Label = "addschudle")]
    public class addschudle : Activity , IOnDateSetListener
    {

        private const int DATE_DIALOG = 1;
        private int year, month, day;



        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            this.year = year;
            this.month = month;
            this.day = dayOfMonth;

            Toast.MakeText(this, "Date is" + (month + 1) + "/" + day + "/" + year, ToastLength.Short).Show();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.addSchdule);






            Button button = FindViewById<Button>(Resource.Id.date);
            button.Click += delegate

            {
#pragma warning disable CS0618 // Type or member is obsolete
                ShowDialog(DATE_DIALOG);
#pragma warning restore CS0618 // Type or member is obsolete
            };
        }


#pragma warning disable CS0672 // Member overrides obsolete member
        protected override Dialog OnCreateDialog(int id)
#pragma warning restore CS0672 // Member overrides obsolete member
        {
            switch (id)
            {
                case DATE_DIALOG:

                    {
                        return new DatePickerDialog(this, this, year, month, day);

                    }
                default:
                    break;


            }
            return null;
        }

    }


    

}