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
    [Activity(Label = "t_show_lectures")]
    public class t_show_lectures : Activity
    {
        List<lecture_item> lecture_Items = new List<lecture_item>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.t_show_lectures);


            // Create your application here



            var courses = new List<String>();
            courses.Add("MIS");
            courses.Add("NLP");
            courses.Add("Internet Aplication");
            courses.Add("DSS");


            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, courses);
            var spin_courses = FindViewById<Spinner>(Resource.Id.spin_courses);
            spin_courses.Adapter = adapter;





            lecture_Items.Add(new lecture_item("1.", "graphics"));
            lecture_Items.Add(new lecture_item("2.", "nlp"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));
            lecture_Items.Add(new lecture_item("3.", " MIS"));







            ListView list = FindViewById<ListView>(Resource.Id.list_lectures);
            list.Adapter = new HomeScreenAdapter(this, lecture_Items);

            list.ItemClick += clickfunction;




        }
        void clickfunction(object sender, AdapterView.ItemClickEventArgs e)


        {

            var listView = sender as ListView;
            var t = lecture_Items[e.Position];
            Android.Widget.Toast.MakeText(this, t.lec_name, Android.Widget.ToastLength.Short).Show();
        }

    }

    public class lecture_item
    {
        public string lec_id;
        public string lec_name;

        public lecture_item(string lec_id, string lec_name)
        {
            this.lec_id = lec_id;
            this.lec_name = lec_name;

        }
    }


    // adpater manage
    public class HomeScreenAdapter : BaseAdapter<lecture_item>
    {
        List<lecture_item> items;
        Activity context;
        public HomeScreenAdapter(Activity context, List<lecture_item> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override lecture_item this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.t_lec_show_tic, null);
            view.FindViewById<TextView>(Resource.Id.textView_lecture_id).Text = item.lec_id;
            view.FindViewById<TextView>(Resource.Id.txtv_lecture_name).Text = item.lec_name;

            return view;
        }
    }
}