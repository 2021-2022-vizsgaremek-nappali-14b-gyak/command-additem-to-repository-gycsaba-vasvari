using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;

namespace Kreta.View.Navigation
{
    public static class Navigation
    {
        public static MainWindow MainWindow;

        public static void Navigate(UserControl userControl)
        {
            MainWindow.Content.Children.Clear();
            MainWindow.Content.Children.Add(userControl);
        }
    }
}
