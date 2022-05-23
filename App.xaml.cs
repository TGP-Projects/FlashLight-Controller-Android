using System;
using System.IO;
using Xamarin.Forms;

namespace FlashApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new MainPage();
		}
	}
}