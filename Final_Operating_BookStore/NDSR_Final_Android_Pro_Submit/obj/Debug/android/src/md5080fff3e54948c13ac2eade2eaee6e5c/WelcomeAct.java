package md5080fff3e54948c13ac2eade2eaee6e5c;


public class WelcomeAct
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"";
		mono.android.Runtime.register ("NDSR_Final_Android_Pro_Submit.WelcomeAct, NDSR_Final_Android_Pro_Submit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WelcomeAct.class, __md_methods);
	}


	public WelcomeAct () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WelcomeAct.class)
			mono.android.TypeManager.Activate ("NDSR_Final_Android_Pro_Submit.WelcomeAct, NDSR_Final_Android_Pro_Submit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();

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
