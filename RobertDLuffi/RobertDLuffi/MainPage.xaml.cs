﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Specialized;

namespace RobertDLuffi
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }
       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://token.somee.com/");
            await Browser.OpenAsync(uri);

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }
    }

}
