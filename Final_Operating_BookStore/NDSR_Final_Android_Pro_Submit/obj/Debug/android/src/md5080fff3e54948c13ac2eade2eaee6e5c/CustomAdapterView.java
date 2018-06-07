package md5080fff3e54948c13ac2eade2eaee6e5c;


public class CustomAdapterView
	extends android.widget.CursorAdapter
	implements
		mono.android.IGCUserPeer,
		android.widget.Filterable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_bindView:(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V:GetBindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_Handler\n" +
			"n_newView:(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;:GetNewView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_Handler\n" +
			"n_notifyDataSetChanged:()V:GetNotifyDataSetChangedHandler\n" +
			"n_getFilter:()Landroid/widget/Filter;:GetGetFilterHandler:Android.Widget.IFilterableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("NDSR_Final_Android_Pro_Submit.CustomAdapterView, NDSR_Final_Android_Pro_Submit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CustomAdapterView.class, __md_methods);
	}


	public CustomAdapterView (android.content.Context p0, android.database.Cursor p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == CustomAdapterView.class)
			mono.android.TypeManager.Activate ("NDSR_Final_Android_Pro_Submit.CustomAdapterView, NDSR_Final_Android_Pro_Submit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Database.ICursor, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomAdapterView (android.content.Context p0, android.database.Cursor p1, boolean p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == CustomAdapterView.class)
			mono.android.TypeManager.Activate ("NDSR_Final_Android_Pro_Submit.CustomAdapterView, NDSR_Final_Android_Pro_Submit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Database.ICursor, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomAdapterView (android.content.Context p0, android.database.Cursor p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == CustomAdapterView.class)
			mono.android.TypeManager.Activate ("NDSR_Final_Android_Pro_Submit.CustomAdapterView, NDSR_Final_Android_Pro_Submit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Database.ICursor, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Widget.CursorAdapterFlags, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void bindView (android.view.View p0, android.content.Context p1, android.database.Cursor p2)
	{
		n_bindView (p0, p1, p2);
	}

	private native void n_bindView (android.view.View p0, android.content.Context p1, android.database.Cursor p2);


	public android.view.View newView (android.content.Context p0, android.database.Cursor p1, android.view.ViewGroup p2)
	{
		return n_newView (p0, p1, p2);
	}

	private native android.view.View n_newView (android.content.Context p0, android.database.Cursor p1, android.view.ViewGroup p2);


	public void notifyDataSetChanged ()
	{
		n_notifyDataSetChanged ();
	}

	private native void n_notifyDataSetChanged ();


	public android.widget.Filter getFilter ()
	{
		return n_getFilter ();
	}

	private native android.widget.Filter n_getFilter ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
