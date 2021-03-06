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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double _width;
        private double _height;
        private string _color;
        public MainPage()
        {
            this.InitializeComponent();
        }



        /* private async void Button_Click(object sender, RoutedEventArgs e)
         {
             MediaElement mediaElement = new MediaElement();
             var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
             Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
             mediaElement.SetSource(stream, stream.ContentType);
             mediaElement.Play();
         }
         */


        private bool Validate_Input()
        {
            bool good = true;
            string heightString = heightInput.Text;
            string widthString = widthInput.Text;

            if (!Double.TryParse(heightString, out _height))
            {
                HeightError.Text = "Please enter a valid number";
                heightInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                good = false;
            }
            else
            {
                HeightError.Text = "";
                heightInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            }
            if (!Double.TryParse(widthString, out _width))
            {
                WidthError.Text = "Please enter a valid number";
                widthInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                good = false;
            }
            else
            {
                WidthError.Text = "";
                widthInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            }
            return good;
        }



        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (Validate_Input())
            {
                double woodLength, glassArea;
                string widthString, heightString;



                woodLength = 2 * (_width + _height) * 3.25;
                glassArea = 2 * (_width * _height);


                outLength.Text = $"{woodLength} in";
                areaOut.Text = $"{glassArea} in2";

                //test test
            }
        }
    }
}
