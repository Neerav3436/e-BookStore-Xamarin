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
	[Activity(Label = "Register")]
	public class Register : Activity
	{
		DBHelper myDataBase;

		const string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
											 + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
											 + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";


		public String getMessage(String msg)
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
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{

			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.register);

			myDataBase = new DBHelper(this);

			myDataBase.OpenMyDB();

			EditText name = FindViewById<EditText>(Resource.Id.ed11);
			EditText email = FindViewById<EditText>(Resource.Id.ed12);
			EditText pwd = FindViewById<EditText>(Resource.Id.ed13);



			Button b11 = FindViewById<Button>(Resource.Id.b11);

			b11.Click += delegate
			{



				bool rg = new Regex(validEmailPattern, RegexOptions.IgnoreCase).IsMatch(email.Text);

				var listOfUsers = myDataBase.getUsers();

				while (listOfUsers.MoveToNext())
				{
					if (name.Text != "" || email.Text != "" || pwd.Text != "")
					{
						//var emails = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.email));



						if (rg == true)
						{
							if (CheckEmail(email.Text) == false)
							{
								getMessage("Email already existing!!");

								break;

							}
							else
							{
								myDataBase.insertUserInfo(name.Text, email.Text, pwd.Text);
								var tologin = new Intent(this, typeof(MainActivity));
								StartActivity(tologin);
								break;
							}
						}
						else
						{
							getMessage("Email format violated!!");
							break;
						}


					}
					else {

						getMessage("fields can't be empty!!");

						break;
					}
				}

			};
		}

		public bool CheckEmail(string email)
		{
			try
			{
				var listOfUsers = myDataBase.getUsers();

				while (listOfUsers.MoveToNext())
				{
					var emails = listOfUsers.GetString(listOfUsers.GetColumnIndexOrThrow(DBHelper.email));
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
		}
	}
}

