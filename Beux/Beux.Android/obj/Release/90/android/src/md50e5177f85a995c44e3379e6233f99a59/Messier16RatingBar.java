package md50e5177f85a995c44e3379e6233f99a59;


public class Messier16RatingBar
	extends android.view.View
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Messier16.Forms.Android.Controls.Native.RatingBar.Messier16RatingBar, Messier16.Forms.Android.Controls", Messier16RatingBar.class, __md_methods);
	}


	public Messier16RatingBar (android.content.Context p0)
	{
		super (p0);
		if (getClass () == Messier16RatingBar.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.RatingBar.Messier16RatingBar, Messier16.Forms.Android.Controls", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public Messier16RatingBar (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == Messier16RatingBar.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.RatingBar.Messier16RatingBar, Messier16.Forms.Android.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public Messier16RatingBar (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == Messier16RatingBar.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.RatingBar.Messier16RatingBar, Messier16.Forms.Android.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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
