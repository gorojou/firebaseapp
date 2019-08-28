package md5359b83cd58b2d6ec4a800a863366acf7;


public class OnProgressHandlerListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.firebase.storage.OnProgressListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onProgress:(Ljava/lang/Object;)V:GetOnProgress_Ljava_lang_Object_Handler:Firebase.Storage.IOnProgressListenerInvoker, Xamarin.Firebase.Storage\n" +
			"";
		mono.android.Runtime.register ("Plugin.FirebaseStorage.OnProgressHandlerListener, Plugin.FirebaseStorage", OnProgressHandlerListener.class, __md_methods);
	}


	public OnProgressHandlerListener ()
	{
		super ();
		if (getClass () == OnProgressHandlerListener.class)
			mono.android.TypeManager.Activate ("Plugin.FirebaseStorage.OnProgressHandlerListener, Plugin.FirebaseStorage", "", this, new java.lang.Object[] {  });
	}


	public void onProgress (java.lang.Object p0)
	{
		n_onProgress (p0);
	}

	private native void n_onProgress (java.lang.Object p0);

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
