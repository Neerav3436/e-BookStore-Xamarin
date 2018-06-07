using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*

string text = Intent.GetStringExtra("name_admin") ?? "Not  Found";
			tv1.Text = "Welcome Admin:" + text;



 */
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Database;

namespace NDSR_Final_Android_Pro_Submit
{
	[Activity(Label = "Admin_Welcome")]
	public class Admin_Welcome : Activity
	{
		int count = 1;
		ListView mylist;



		DBHelper dbHelper;
		ICursor cursor;
		SearchView searchView;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.WelcomePg);

			TextView tv1 = FindViewById<TextView>(Resource.Id.tv1);
			string text = Intent.GetStringExtra("name_admin") ?? "Not  Found";
			tv1.Text = "Welcome Admin:" + text;

			dbHelper = new DBHelper(this);
			searchView = FindViewById<SearchView>(Resource.Id.searchViewId);
			mylist = FindViewById<ListView>(Resource.Id.listView1);
			cursor = dbHelper.ReadableDatabase.RawQuery("select * from Vendors", null);
			StartManagingCursor(cursor);
			/* Custom Curson Adapter*/

			Button tvs = FindViewById<Button>(Resource.Id.tvs);
			tvs.Click += delegate
			{
				var tologin = new Intent(this, typeof(MainActivity));
				StartActivity(tologin);

			};


			CustomAdapterView adapterVendor = new CustomAdapterView(this, cursor, dbHelper);




			mylist.Adapter = adapterVendor;


			/* Search View Event */
			searchView.QueryTextChange += (sender, e) => adapterVendor.Filter.InvokeFilter(e.NewText);

			searchView.QueryTextSubmit += (sender, e) =>
			{
				Toast.MakeText(this, "Searched for : " + e.Query, ToastLength.Short).Show();
				e.Handled = true;
			};

			mylist.ItemClick += OnListItemClick;

			mylist.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
	   {
		   string selectedFromList = mylist.GetItemAtPosition(e.Position).ToString();

		   var activity1 = new Intent(this, typeof(DisplayDetails));

		   StartActivity(activity1);


	   };
			mylist.ItemClick += OnListItemClick;

		}

		protected void OnListItemClick(object sender, Android.Widget.ListView.ItemClickEventArgs e)
		{
			var obj = mylist.Adapter.GetItem(e.Position);

			var curs = (ICursor)obj;
			var tname = curs.GetString(1);
			var taddr = curs.GetString(2);
			var temail = curs.GetString(3);
			var tpn = curs.GetString(4);



			var tt1 = curs.GetString(6);

			var tt2 = curs.GetString(7);
			var tt3 = curs.GetString(8);

			var tt4 = curs.GetString(9);
			var tt5 = curs.GetString(10);

			var tt6 = curs.GetString(11);
			var tt7 = curs.GetString(12);

			var tt8 = curs.GetString(13);
			var tt9 = curs.GetString(14);

			var tt10 = curs.GetString(15);
			var tt11 = curs.GetString(16);
			var tt12 = curs.GetString(17);
			var tt13 = curs.GetString(18);
			var tt14 = curs.GetString(19);



			var i = new Intent(this, typeof(DisplayDetails));
			i.PutExtra("name", tname);
			i.PutExtra("addr", taddr);
			i.PutExtra("email", temail);

			i.PutExtra("pn", tpn);
			i.PutExtra("t1", tt1);
			i.PutExtra("t2", tt2);
			i.PutExtra("t3", tt3);

			i.PutExtra("t4", tt4);
			i.PutExtra("t5", tt5);
			i.PutExtra("t6", tt6);
			i.PutExtra("t7", tt7);
			i.PutExtra("t8", tt8);
			i.PutExtra("t9", tt9);

			i.PutExtra("t10", tt10);
			i.PutExtra("t11", tt11);
			i.PutExtra("t12", tt12);
			i.PutExtra("t13", tt13);
			i.PutExtra("t14", tt14);


			StartActivity(i);


		}


		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.menu, menu);
			return base.OnPrepareOptionsMenu(menu);
		}


		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
				case Resource.Id.add:
					var toVendorAdd = new Intent(this, typeof(InsertVendor));
					StartActivity(toVendorAdd);

					Toast.MakeText(this, "Start adding vendors: ", ToastLength.Short).Show();

					return true;

			}
			return base.OnOptionsItemSelected(item);
		}

		protected override void OnDestroy()
		{
			StopManagingCursor(cursor);
			cursor.Close();

			base.OnDestroy();
		}

	}
}

