﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2_ListaBrasil
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Estados() { BackgroundColor = Color.Black, Title = "BRASIL Estados!"}) { BarBackgroundColor = Color.Black, BarTextColor= Color.SlateGray};

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
