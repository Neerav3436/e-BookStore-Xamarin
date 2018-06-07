using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

using Android.Views;
using Android.Database;
using System.Collections.Generic;


namespace NDSR_Final_Android_Pro_Submit
{
	[Activity(Label = "NDSR_Final_Android_Pro_Submit", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		DBHelper myDataBase;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			myDataBase = new DBHelper(this);

			myDataBase.OpenMyDB();

			SetContentView(Resource.Layout.Main);



			Button ll = FindViewById<Button>(Resource.Id.btn1);
			Button b2 = FindViewById<Button>(Resource.Id.btn2);
			//var email = Intent.GetStringExtra("email") ?? "Data not available";


			/*while (listOfUsers.MoveToNext())
			{
				names = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.name));
				emails = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.email));
				pwds = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.pwd));
			} */

			//Console.Out.WriteLine(" My User Fist Name :" + names);

			ll.Click += delegate
			{
				EditText ed1 = FindViewById<EditText>(Resource.Id.ed1);
				EditText ed2 = FindViewById<EditText>(Resource.Id.ed2);

				var listOfUsers = myDataBase.getUsers();

				if (ed1.Text == "" || ed2.Text == "")
				{
					AlertDialog.Builder builder = new AlertDialog.Builder(this);
					builder.SetTitle("Authentication failed!");
					builder.SetMessage("Fields can't be empty!!");
					builder.SetPositiveButton("OK", (sender, e) =>
					{
						Toast.MakeText(this, "Try Again!!", ToastLength.Short).Show();
					});
					Dialog dialog1 = builder.Create();
					dialog1.Show();

				}
				else {
					var names = "";
					var emails = "";
					var pwds = "";
					//
					bool userExisted = false;
					while (listOfUsers.MoveToNext())
					{
						names = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.name));
						emails = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.email));
						pwds = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.pwd));

						if (ed1.Text == emails && ed2.Text == pwds)
						{
							//set the flag to true if user entered was found in database
							userExisted = true;

							if (ed1.Text == "admin@bookmart.ca" && ed2.Text == "bookmart")
							{
								//admin

								var tologin = new Intent(this, typeof(Admin_Welcome));
								tologin.PutExtra("name_admin", names);
								StartActivity(tologin);

							}
							else {

								//users
								var tologin = new Intent(this, typeof(WelcomeAct));
								tologin.PutExtra("name", names);
								StartActivity(tologin);

							}

						}
					}

					//user not found in database
					if (userExisted == false)
					{


						AlertDialog.Builder builder = new AlertDialog.Builder(this);
						builder.SetTitle("Authentication failed!");
						builder.SetMessage("Either username or password is incorrect!!");
						builder.SetPositiveButton("OK", (sender, e) =>
						{
							Toast.MakeText(this, "Try Again!!", ToastLength.Short).Show();
						});
						Dialog dialog2 = builder.Create();
						dialog2.Show();
					}
				}

			};

			b2.Click += delegate
			{
				var toregister = new Intent(this, typeof(Register));
				StartActivity(toregister);
			};

		}
	}
}


