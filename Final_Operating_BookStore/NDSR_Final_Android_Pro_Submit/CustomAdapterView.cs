using System;
using Android.Database;
using Android.Widget;
using Android.App;
using Android.Views;

namespace NDSR_Final_Android_Pro_Submit
{
	
	public class CustomAdapterView : CursorAdapter, IFilterable
	{
		Activity context;
		ICursor cursor;

		public CustomAdapterView(Activity context, ICursor cursor, DBHelper dbb) : base(context, cursor)
		{
			this.context = context;
			this.cursor = cursor;
			Filter = new VendorFilter(this, dbb);
		}

		public override void BindView(Android.Views.View view, Android.Content.Context context, ICursor cursor)
		{
			ImageView img = view.FindViewById<ImageView>(Resource.Id.vendorimg);
			TextView name = view.FindViewById<TextView>(Resource.Id.vendorName);
			TextView addr = view.FindViewById<TextView>(Resource.Id.vendorAddr);
			TextView pn = view.FindViewById<TextView>(Resource.Id.vendorPn);

			name.Text = cursor.GetString(1);
			addr.Text = cursor.GetString(2);
			pn.Text = cursor.GetString(3);
			img.SetImageResource(cursor.GetInt(5));

		}

		public override Android.Views.View NewView(Android.Content.Context context, ICursor cursor, Android.Views.ViewGroup parent)
		{
			View view = this.context.LayoutInflater.Inflate(Resource.Layout.customLayout, null);
			return view;
		}


		public Filter Filter { get; private set; }



		public override void NotifyDataSetChanged()
		{
			base.NotifyDataSetChanged();
		}

		/*Main Class to Filter the element */
		private class VendorFilter : Filter
		{
			private readonly CustomAdapterView adapter;
			private DBHelper dbb;

			public VendorFilter(CustomAdapterView adapter, DBHelper dbb)
			{
				this.adapter = adapter;
				this.dbb = dbb;
			}

			protected override FilterResults PerformFiltering(Java.Lang.ICharSequence constraint)
			{
				var returnObj = new FilterResults();
				ICursor newCursor = dbb.ReadableDatabase.RawQuery("select * from Vendors where vname like :constrStr ", new string[] { "%" + constraint.ToString() + "%" });
				returnObj.Values = (Java.Lang.Object)newCursor;
				returnObj.Count = newCursor.Count;
				return returnObj;
			}

			protected override void PublishResults(Java.Lang.ICharSequence constraint, FilterResults results)
			{
				adapter.cursor = (ICursor)results.Values;
				adapter.ChangeCursor((ICursor)results.Values);
				adapter.NotifyDataSetChanged();

				constraint.Dispose();
				results.Dispose();

			}
		}

	}
}

