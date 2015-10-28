
using System;
using AVFoundation;
using TrickOrTreatForms.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (SpeechSynth_iOS))]
namespace TrickOrTreatForms.iOS
{	
	public class SpeechSynth_iOS : ISpeechSynth
	{
		public SpeechSynth_iOS()
		{
		}

		#region ISpeechSynth implementation

		public void SpeakText(string text)
		{
			var speechSynthesizer = new AVSpeechSynthesizer ();
			var speechUtterance = new AVSpeechUtterance(text);
			speechSynthesizer.SpeakUtterance (speechUtterance);
		}

		#endregion
	}
}

