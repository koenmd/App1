using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamvvm;

namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //var factory = new XamvvmFormsPageFactory(this);
            var factory = new XamvvmFormsRxUIFactory(this);
            XamvvmCore.SetCurrentFactory(factory);

            //MainPage = new App1.MainPage();
            MainPage = new NavigationPage(new App1.Views.LoginPage());
            //MainPage = new App1.Views.LoginPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
