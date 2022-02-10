using SG2022.Services;
using SG2022.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SG2022
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
