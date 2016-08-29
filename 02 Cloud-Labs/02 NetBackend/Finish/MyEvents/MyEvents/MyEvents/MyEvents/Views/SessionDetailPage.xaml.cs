﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyEvents.Views
{
    public partial class SessionDetailPage : ContentPage
    {
        public SessionDetailPage()
        {
            InitializeComponent();
        }

        private async void FeedBackButton_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new FeedbackPage());
        }
    }
}
