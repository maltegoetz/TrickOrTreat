
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TrickOrTreat.Droid
{
	[Activity(Label = "Result", ParentActivity = typeof(MainActivity))]			
	public class ResultActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Result);
			ActionBar.SetDisplayHomeAsUpEnabled(true);

			// Set result text
			var textView = FindViewById<TextView>(Resource.Id.tvResult);
			textView.Text = "Trick!";

			// Set result background image
			var imageView = FindViewById<ImageView>(Resource.Id.ivBackground);
			imageView.SetImageResource(Resource.Drawable.trickBackground);
		}
	}
}

