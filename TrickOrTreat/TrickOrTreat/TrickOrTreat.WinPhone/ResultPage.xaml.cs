﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TrickOrTreat;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TrickOrTreat.WinPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResultPage : Page
    {
        public ResultPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            bool isTreat = TrickOrTreat.Random.IsTreat();
            tricktreattext.Text = TrickOrTreat.Random.TrickTreatText(isTreat);
            BitmapImage img;
            if (isTreat)
                img = new BitmapImage { UriSource = new Uri("ms-appx:///Assets/halloween/treatBackground.jpg") };
            else
                img = new BitmapImage { UriSource = new Uri("ms-appx:///Assets/halloween/trickBackground.jpg") };
            backgroundimg.ImageSource = img;
        }
    }
}
