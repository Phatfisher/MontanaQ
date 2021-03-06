﻿using MontanaQ.Services;
using MontanaQ.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("FontAwesome5Regular.otf", Alias = "FontAwesomeRegular")]
[assembly: ExportFont("FontAwesome5Solid.otf", Alias = "FontAwesomeSolid")]
namespace MontanaQ
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false,false);
			Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);
			Sharpnado.Tabs.Initializer.Initialize(false, false);

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
