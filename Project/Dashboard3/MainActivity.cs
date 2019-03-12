using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Dashboard3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Button btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += delegate {

                var edittext = FindViewById<EditText>(Resource.Id.editText1);
                string name = edittext.Text;
                 if (name == "admin")
                {
                    System.Diagnostics.Debug.WriteLine("admin");

                    StartActivity(typeof(newd));

                }
                 else if (name == "teacher")

                {
                    System.Diagnostics.Debug.WriteLine("teacher");
                   StartActivity(typeof(dashboard2));

                }

            };
        }
    }
}