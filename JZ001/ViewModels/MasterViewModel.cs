using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Geekors.GWP7.ViewModels
{
    using Core.Extensions;
    using Core.Helpers;
    using Pages;

    /// <summary>
    /// Similar to Global file of asp.net web project
    /// </summary>
    public class MasterViewModel
    {
        /// <summary>
        /// Get current page in this class
        /// </summary>
        private PhoneApplicationPage CurrentPage
        {
            get
            {
                return ((App)Application.Current).RootFrame.Content as PhoneApplicationPage ?? new MainPage();
            }
        }

        /// <summary>
        /// Get or set current view model in this application.
        /// </summary>
        public BaseViewModel CurrentViewModel { get; private set; }

        public MasterViewModel()
        {
            CurrentViewModel = new MainPageViewModel();
            CurrentPage.DataContext = CurrentViewModel;

            //Register the navigated event, we have to assign the right Page and Model to the right field of this class.
            Navigation.Navigated += new NavigatedEventHandler(Navigation_Navigated);
        }

        protected void Navigation_Navigated(object sender, NavigationEventArgs e)
        {
            //1. Get current ViewModel class by the given url string.
            var viewModel = PageHelpers.FindCurrentView(e.Uri);
            //2. Set 1.(current viewModel) to the the CurrentViewModel property.
            CurrentViewModel = viewModel;
        }

        /// <summary>
        /// Get navigation service.
        /// </summary>
        public NavigationService Navigation
        {
            get { return CurrentPage.NavigationService; }
        }

        /// <summary>
        /// Go to page.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void GoToWithParameters<T>(ResourceDictionary parameters)
        {
            Type type = typeof(T);
            var pageDefinition = type.PageDefinition();
            Uri _uri = new Uri(pageDefinition.ToString() + parameters.ToQueryString() , UriKind.Relative);
            
            Navigation.Navigate(_uri);
        }

        /// <summary>
        /// Go to page(T)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void GoTo<T>()
        {
            GoToWithParameters<T>(new ResourceDictionary());
        }

    }
}
