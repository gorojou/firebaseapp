package md55ea7c5771b751fa5d3e0922bc6a28594;


public class SegmentedControlRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Messier16.Forms.Android.Controls.SegmentedControlRenderer, Messier16.Forms.Android.Controls", SegmentedControlRenderer.class, __md_methods);
	}


	public SegmentedControlRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SegmentedControlRenderer.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.SegmentedControlRenderer, Messier16.Forms.Android.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SegmentedControlRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SegmentedControlRenderer.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.SegmentedControlRenderer, Messier16.Forms.Android.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SegmentedControlRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SegmentedControlRenderer.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.SegmentedControlRenderer, Messier16.Forms.Android.Controls", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
