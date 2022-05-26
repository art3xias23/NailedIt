package crc64cf2e65de3a945ecd;


public class ServiceTabsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Art3xias.NailedIt.App.ServiceTabsActivity, Art3xias.NailedIt.App", ServiceTabsActivity.class, __md_methods);
	}


	public ServiceTabsActivity ()
	{
		super ();
		if (getClass () == ServiceTabsActivity.class)
			mono.android.TypeManager.Activate ("Art3xias.NailedIt.App.ServiceTabsActivity, Art3xias.NailedIt.App", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
