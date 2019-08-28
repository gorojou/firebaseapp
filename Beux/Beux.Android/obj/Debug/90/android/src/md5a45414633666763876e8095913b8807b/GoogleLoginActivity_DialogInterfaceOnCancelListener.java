package md5a45414633666763876e8095913b8807b;


public class GoogleLoginActivity_DialogInterfaceOnCancelListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnCancelListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:(Landroid/content/DialogInterface;)V:GetOnCancel_Landroid_content_DialogInterface_Handler:Android.Content.IDialogInterfaceOnCancelListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Beux.Droid.Activities.GoogleLoginActivity+DialogInterfaceOnCancelListener, Beux.Android", GoogleLoginActivity_DialogInterfaceOnCancelListener.class, __md_methods);
	}


	public GoogleLoginActivity_DialogInterfaceOnCancelListener ()
	{
		super ();
		if (getClass () == GoogleLoginActivity_DialogInterfaceOnCancelListener.class)
			mono.android.TypeManager.Activate ("Beux.Droid.Activities.GoogleLoginActivity+DialogInterfaceOnCancelListener, Beux.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCancel (android.content.DialogInterface p0)
	{
		n_onCancel (p0);
	}

	private native void n_onCancel (android.content.DialogInterface p0);

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
