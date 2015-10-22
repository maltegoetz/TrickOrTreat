
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

			var isTreat = TrickOrTreat.Random.IsTreat();

			// Set result text
			var textView = FindViewById<TextView>(Resource.Id.tvResult);
			textView.Text = TrickOrTreat.Random.TrickTreatText(isTreat);

			// Set result background image
			var imageView = FindViewById<ImageView>(Resource.Id.ivBackground);
			if (isTreat)
				imageView.SetImageResource(Resource.Drawable.treatBackground);
			else
				imageView.SetImageResource(Resource.Drawable.trickBackground);
		}
	}
}

