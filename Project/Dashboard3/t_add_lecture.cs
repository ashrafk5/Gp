using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using static Android.App.DatePickerDialog;
using AlertDialog = Android.App.AlertDialog;
//using Plugin.FilePicker;
using Java.Interop;
using Android.Views;


namespace Dashboard3
{
    [Activity(Label = "t_add_lecture")]
    public class t_add_lecture : Activity, IOnDateSetListener
    {
        [Export("radioButton_onClick")]
        public void radioButton_onClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.radioButton1:
                    Toast.MakeText(this, "you show lecture", ToastLength.Short).Show();
                    break;
                case Resource.Id.radioButton2:
                    Toast.MakeText(this, "you hide lecture", ToastLength.Short).Show();
                    break;

            }

        }






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
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.t_add_lecture);

            Button button = FindViewById<Button>(Resource.Id.date);
            button.Click += delegate

            {
#pragma warning disable CS0618 // Type or member is obsolete
                ShowDialog(DATE_DIALOG);
#pragma warning restore CS0618 // Type or member is obsolete
            };


            Button button1 = FindViewById<Button>(Resource.Id.button5);
            button1.Click += delegate
            {
                var lecturename = FindViewById<EditText>(Resource.Id.lecturename);
                string lecture = lecturename.Text;
                System.Diagnostics.Debug.WriteLine(lecture);
            };
            //Button button2 = FindViewById<Button>(Resource.Id.button6);
            /* button2.Click += async delegate
             {

                 var file = await CrossFilePicker.Current.PickFile();
                 if (file != null)
                 {

                     System.Diagnostics.Debug.WriteLine(file.FileName);

                 }


             };*/








            // Button button3 = FindViewById<Button>(Resource.Id.mybutton);
            //button3.Click += delegate

            //{
            //  var alert = new AlertDialog.Builder(this);
            //alert.SetTitle("your course grade");
            //alert.SetMessage("your grade is ");
            //alert.SetPositiveButton("ok", delegate { });
            //alert.Show();
            //};





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
