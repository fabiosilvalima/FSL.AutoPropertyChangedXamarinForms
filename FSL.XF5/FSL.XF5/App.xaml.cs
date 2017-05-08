﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FSL.XF5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new FSL.XF5.MainPage();
            MainPage = new Views.HomePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
