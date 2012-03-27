using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Geekors.GWP7
{
    using ViewModels.Pages;

    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            button1.Click += new RoutedEventHandler(button1_Click);

        }


        protected void button1_Click(object sender, RoutedEventArgs e)
        {
            var p = new ResourceDictionary() { { "ID", 007 } };
            App.ViewModel.GoToWithParameters<DetailPageViewModel>(p);
        }
    }
}