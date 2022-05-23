using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Android;
using Android;
using XamarinFormsUiLib;

namespace FlashApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			bool flashOn = false;
			InitializeComponent();
			
			btt1.Clicked += delegate{
				if (flashOn){
					flashOn = false;
					Flashlight.TurnOffAsync();
					btt1.Text = "Flash Desligado";
					btt1.TextColor = Color.White;
				} else{
					flashOn = true;
					Flashlight.TurnOnAsync();
					btt1.Text = "Flash Ligado";
					btt1.TextColor = Color.Orange;
				}
			};
		}
	}
}