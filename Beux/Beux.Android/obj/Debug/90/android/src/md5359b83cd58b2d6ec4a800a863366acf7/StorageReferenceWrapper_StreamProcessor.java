package md5359b83cd58b2d6ec4a800a863366acf7;


public class StorageReferenceWrapper_StreamProcessor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.firebase.storage.StreamDownloadTask.StreamProcessor
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_doInBackground:(Lcom/google/firebase/storage/StreamDownloadTask$TaskSnapshot;Ljava/io/InputStream;)V:GetDoInBackground_Lcom_google_firebase_storage_StreamDownloadTask_TaskSnapshot_Ljava_io_InputStream_Handler:Firebase.Storage.StreamDownloadTask/IStreamProcessorInvoker, Xamarin.Firebase.Storage\n" +
			"";
		mono.android.Runtime.register ("Plugin.FirebaseStorage.StorageReferenceWrapper+StreamProcessor, Plugin.FirebaseStorage", StorageReferenceWrapper_StreamProcessor.class, __md_methods);
	}


	public StorageReferenceWrapper_StreamProcessor ()
	{
		super ();
		if (getClass () == StorageReferenceWrapper_StreamProcessor.class)
			mono.android.TypeManager.Activate ("Plugin.FirebaseStorage.StorageReferenceWrapper+StreamProcessor, Plugin.FirebaseStorage", "", this, new java.lang.Object[] {  });
	}


	public void doInBackground (com.google.firebase.storage.StreamDownloadTask.TaskSnapshot p0, java.io.InputStream p1)
	{
		n_doInBackground (p0, p1);
	}

	private native void n_doInBackground (com.google.firebase.storage.StreamDownloadTask.TaskSnapshot p0, java.io.InputStream p1);

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
