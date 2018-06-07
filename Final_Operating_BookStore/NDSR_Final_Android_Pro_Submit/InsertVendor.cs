using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NDSR_Final_Android_Pro_Submit
{
	[Activity(Label = "InsertVendor")]
	public class InsertVendor : Activity

	{
		//int count = 1;

		DBHelper myDataBase;
		/*

		const string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
											 + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
											 + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";


		public String getMsg(String msg)
		{

			AlertDialog.Builder builders = new AlertDialog.Builder(this);
			builders.SetTitle("Invalidation!");
			builders.SetMessage(msg);
			builders.SetPositiveButton("OK", (sender, e) =>
			{
				Toast.MakeText(this, "Try Again!!", ToastLength.Short).Show();
			});
			Dialog dialog11 = builders.Create();
			dialog11.Show();

			return msg;

		}   */

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.insertVendor);

			myDataBase = new DBHelper(this);
			myDataBase.OpenMyDB();

			Button btn = FindViewById<Button>(Resource.Id.b2);


			int z = Resource.Drawable.m;
			EditText e1 = FindViewById<EditText>(Resource.Id.a1);
			EditText e2 = FindViewById<EditText>(Resource.Id.a2);
			EditText e3 = FindViewById<EditText>(Resource.Id.a3);
			EditText e4 = FindViewById<EditText>(Resource.Id.a4);
			EditText e5 = FindViewById<EditText>(Resource.Id.a5);
			EditText e6 = FindViewById<EditText>(Resource.Id.a6);
			EditText e7 = FindViewById<EditText>(Resource.Id.a7);
			EditText e8 = FindViewById<EditText>(Resource.Id.a8);
			EditText e9 = FindViewById<EditText>(Resource.Id.a9);
			EditText e10 = FindViewById<EditText>(Resource.Id.a10);
			EditText e11 = FindViewById<EditText>(Resource.Id.a11);
			EditText e12 = FindViewById<EditText>(Resource.Id.a12);
			EditText e13 = FindViewById<EditText>(Resource.Id.a13);
			EditText e14 = FindViewById<EditText>(Resource.Id.a14);
			EditText e15 = FindViewById<EditText>(Resource.Id.a15);
			EditText e16 = FindViewById<EditText>(Resource.Id.a16);
			EditText e17 = FindViewById<EditText>(Resource.Id.a17);
			EditText e18 = FindViewById<EditText>(Resource.Id.a18);



			btn.Click += delegate
			{
				myDataBase.insertVendorInfo(e1.Text, e2.Text, e3.Text, e4.Text, z, e5.Text, e6.Text, e7.Text, e8.Text, e9.Text, e10.Text, e11.Text, e12.Text, e13.Text, e14.Text, e15.Text, e16.Text, e17.Text, e18.Text);

				var tologin = new Intent(this, typeof(Admin_Welcome));
				StartActivity(tologin);

				/*bool rg = new Regex(validEmailPattern, RegexOptions.IgnoreCase).IsMatch(e3.Text);


				//var emails = listOfVendors.GetString(listOfVendors.GetColumnIndexOrThrow(DBHelper.vemail));

				if (e3.Text != "" && rg == true)
					{
					
					//if (CheckEmail(e3.Text) == false||)
					if(true)
					{

						myDataBase.insertVendorInfo(e1.Text, e2.Text, e3.Text, e4.Text, z, e5.Text, e6.Text, e7.Text, e8.Text, e9.Text, e10.Text, e11.Text, e12.Text, e13.Text, e14.Text, e15.Text, e16.Text, e17.Text, e18.Text);

						var tologin = new Intent(this, typeof(Admin_Welcome));
						StartActivity(tologin);

						getMsg("Inserted Successfully");
					
					}
					else {
						getMsg("credentials already exists");
					}

								  }
								  else {
									 getMsg("Invalid credentials or format");

								  }
							  

							  */

			};



		}
		/*

		public bool CheckEmail(string email)
		{
			try
			{
				var listOfUsers = myDataBase.getUsers();

				while (listOfUsers.MoveToNext())
				{
					var emails = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.vemail));
					if (email == emails)
					{







						return false;
					}

				}
				return true;
			}
			catch (Exception ex)
			{
				return false;

			}
			*/
	}

}
