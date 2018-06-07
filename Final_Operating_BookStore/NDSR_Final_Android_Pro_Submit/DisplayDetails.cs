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

namespace NDSR_Final_Android_Pro_Submit
{
	[Activity(Label = "DisplayDetails")]
	public class DisplayDetails : Activity
	{
		DBHelper db;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.DisplayDetails);

			TextView tv1 = FindViewById<TextView>(Resource.Id.a1);
			TextView tv2 = FindViewById<TextView>(Resource.Id.a2);
			TextView tv3 = FindViewById<TextView>(Resource.Id.a3);
			TextView tv4 = FindViewById<TextView>(Resource.Id.a4);
			string name = Intent.GetStringExtra("name") ?? "Data not available";
			string addr = Intent.GetStringExtra("addr") ?? "Data not available";
			string email = Intent.GetStringExtra("email") ?? "Data not available";
			string pn = Intent.GetStringExtra("pn") ?? "Data not available";



			TextView tv5 = FindViewById<TextView>(Resource.Id.a5);
			TextView tv6 = FindViewById<TextView>(Resource.Id.a6);
			TextView tv7 = FindViewById<TextView>(Resource.Id.a7);
			TextView tv8 = FindViewById<TextView>(Resource.Id.a8);
			TextView tv9 = FindViewById<TextView>(Resource.Id.a9);
			TextView tv10 = FindViewById<TextView>(Resource.Id.a10);
			TextView tv11 = FindViewById<TextView>(Resource.Id.a11);
			TextView tv12 = FindViewById<TextView>(Resource.Id.a12);
			TextView tv13 = FindViewById<TextView>(Resource.Id.a13);
			TextView tv14 = FindViewById<TextView>(Resource.Id.a14);
			TextView tv15 = FindViewById<TextView>(Resource.Id.a15);
			TextView tv16 = FindViewById<TextView>(Resource.Id.a16);
			TextView tv17 = FindViewById<TextView>(Resource.Id.a17);
			TextView tv18 = FindViewById<TextView>(Resource.Id.a18);



			string t1 = Intent.GetStringExtra("t1") ?? "Data not available";
			string t2 = Intent.GetStringExtra("t2") ?? "Data not available";
			string t3 = Intent.GetStringExtra("t3") ?? "Data not available";
			string t4 = Intent.GetStringExtra("t4") ?? "Data not available";
			string t5 = Intent.GetStringExtra("t5") ?? "Data not available";
			string t6 = Intent.GetStringExtra("t6") ?? "Data not available";
			string t7 = Intent.GetStringExtra("t7") ?? "Data not available";
			string t8 = Intent.GetStringExtra("t8") ?? "Data not available";
			string t9 = Intent.GetStringExtra("t9") ?? "Data not available";
			string t10 = Intent.GetStringExtra("t10") ?? "Data not available";
			string t11 = Intent.GetStringExtra("t11") ?? "Data not available";
			string t12 = Intent.GetStringExtra("t12") ?? "Data not available";
			string t13 = Intent.GetStringExtra("t13") ?? "Data not available";
			string t14 = Intent.GetStringExtra("t14") ?? "Data not available";


			tv1.Text = name;
			tv2.Text = addr;
			tv3.Text = email;
			tv4.Text = pn;
			tv5.Text = t1;
			tv6.Text = t2;
			tv7.Text = t3;
			tv8.Text = t4;
			tv9.Text = t5;
			tv10.Text = t6;
			tv11.Text = t7;
			tv12.Text = t8;
			tv13.Text = t9;
			tv14.Text = t10;
			tv15.Text = t11;
			tv16.Text = t12;
			tv17.Text = t13;
			tv18.Text = t14;




		}

	}
}

