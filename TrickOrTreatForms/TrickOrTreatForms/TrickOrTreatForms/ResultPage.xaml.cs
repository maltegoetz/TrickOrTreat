using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TrickOrTreatForms
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
        	Title = "Result";

        	//
        	var isTreat = Random.IsTreat();
        	var resultText = Random.TrickTreatText(isTreat);
        	lblResult.Text = resultText;

        	//
        	if (isTreat)
        		imgBackground.Source = ImageSource.FromFile("treatBackground.jpg");
        	else
        		imgBackground.Source = ImageSource.FromFile("trickBackground.jpg");

        	// 
        	var implementation = DependencyService.Get<ISpeechSynth>();
        	implementation.SpeakText(resultText);
        }			
    }
}
