using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECCApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}