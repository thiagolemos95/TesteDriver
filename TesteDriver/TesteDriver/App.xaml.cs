﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDriver.Views;
using Xamarin.Forms;

namespace TesteDriver
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new ListagemView());
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
