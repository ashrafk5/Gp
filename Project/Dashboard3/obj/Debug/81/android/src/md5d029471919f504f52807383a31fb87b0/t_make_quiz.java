package md5d029471919f504f52807383a31fb87b0;


public class t_make_quiz
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
		mono.android.Runtime.register ("teacher_dashboard.Resources.Activities.t_make_quiz, Dashboard3", t_make_quiz.class, __md_methods);
	}


	public t_make_quiz ()
	{
		super ();
		if (getClass () == t_make_quiz.class)
			mono.android.TypeManager.Activate ("teacher_dashboard.Resources.Activities.t_make_quiz, Dashboard3", "", this, new java.lang.Object[] {  });
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
