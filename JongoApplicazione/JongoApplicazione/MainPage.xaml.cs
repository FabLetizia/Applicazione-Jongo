﻿using JongoApplicazione.JongoApplicazione.PagineLogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JongoApplicazione
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
          
            this.Children.Add(new View.Prenota(new Utente()) { Title = "prenota!" });
            this.Children.Add(new ContentPage() { Title = "cronologia" });
            this.Children.Add(new ContentPage() { Title = "admin" });

        }
    }
}
