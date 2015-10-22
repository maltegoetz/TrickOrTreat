using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TrickOrTreatForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			Title = "Halloween";
        }

		public async void Random_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ResultPage());
		}
    }
}
