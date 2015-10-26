using System;
using TrickOrTreatForms.Droid;
using Android.Speech.Tts;
using Java.Util;
using System.Collections.Generic;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency (typeof (SpeechSynth_Android))]
namespace TrickOrTreatForms.Droid
{
    public class SpeechSynth_Android : Java.Lang.Object, ISpeechSynth, TextToSpeech.IOnInitListener
    {
    	TextToSpeech speaker;
    	string toSpeak;

    	public SpeechSynth_Android()
    	{
    	}

    	#region ISpeechSynth implementation

    	public void SpeakText(string text)
    	{
    		toSpeak = text;
    		speaker = new TextToSpeech(Forms.Context, this);
    	}

    	#endregion

    	public void OnInit(OperationResult status)
    	{
    		if (status.Equals (OperationResult.Success))
    		{
    			var dict = new Dictionary<string,string>();
    			speaker.Speak(toSpeak, QueueMode.Flush, dict);
    		} 
    	}
    }
}

