using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Systems;

namespace TrickOrTreat.Droid
{
	[Activity (Label = "Halloween", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			// Add event handler to button
			var button = FindViewById<Button>(Resource.Id.myButton);
			button.Click += Button_Click;			
		}

		void Button_Click (object sender, EventArgs e)
		{
			// Navigate to result page
			var intent = new Intent(this, typeof(ResultActivity));
			StartActivity(intent);
		}
	}
}