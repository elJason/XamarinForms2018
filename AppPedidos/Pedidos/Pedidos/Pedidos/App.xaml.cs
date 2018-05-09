﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Pedidos
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();


            //aqui ele vai chamar uma login page, que em seguida chama a pagina referente ao seu acesso
            MainPage = new LoginPage();
            //MainPage = new NavigationPage(new Menu.Master());
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
