using Altkom.Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Altkom.Shop.WpfClient
{
    public class FrameNavigationService : INavigationService
    {
        public object Parameter { get; private set; }

        public void GoBack()
        {
            Frame frame = Get("ContentFrame");

            frame.GoBack();
        }

        public void GoForward()
        {
            Frame frame = Get("ContentFrame");

            frame.GoForward();
        }

        public void Navigate(string viewName, object parameter = null)
        {
            Frame frame = Get("ContentFrame");

            Uri uri = new Uri($"Views/{viewName}View.xaml", UriKind.Relative);

            this.Parameter = parameter;

            frame.Navigate(uri, parameter);
        }

        private Frame Get(string name)
        {
            if (Application.Current.MainWindow.FindName(name) is Frame frame)
            {
                return frame;
            }

            throw new KeyNotFoundException(name);
        }
    }
}
