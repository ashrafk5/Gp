package md57d786d45dae5d7c33e42a03e4e93014d;


public class t_edit_Attendence
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
		mono.android.Runtime.register ("teacher_dashboard.t_edit_Attendence, Dashboard3", t_edit_Attendence.class, __md_methods);
	}


	public t_edit_Attendence ()
	{
		super ();
		if (getClass () == t_edit_Attendence.class)
			mono.android.TypeManager.Activate ("teacher_dashboard.t_edit_Attendence, Dashboard3", "", this, new java.lang.Object[] {  });
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
