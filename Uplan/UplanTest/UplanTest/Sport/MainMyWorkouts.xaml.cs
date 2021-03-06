﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UplanTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMyWorkouts : ContentPage
    {
        public MainMyWorkouts()
        {
            InitializeComponent();
        }

        async void WorkoutNowLink(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutNow());
        }

        async void WorkoutSKLink(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SchedWorkout());
        }

        async void ViewWorklink(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewWorkouts());
        }
    }
}