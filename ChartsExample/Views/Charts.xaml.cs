﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ChartsExample.ViewModels;

namespace ChartsExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Charts : ContentPage
    {
        public Charts()
        {
            this.BindingContext = new ChartsViewModel();
            InitializeComponent();
        }
    }
}