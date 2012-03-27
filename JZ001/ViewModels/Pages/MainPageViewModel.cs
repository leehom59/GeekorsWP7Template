using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Geekors.GWP7.ViewModels.Pages
{
    using Core.Attributes;

    /// <summary>
    /// View model of MainPage.xaml
    /// </summary>
    [PageDefinition("/MainPage.xaml")]
    public class MainPageViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    base.NotifyPropertyChanged("Title");
                }
            }
        }

        public MainPageViewModel()
        {
            Title = "Geekors Title";
        }
    }
}
