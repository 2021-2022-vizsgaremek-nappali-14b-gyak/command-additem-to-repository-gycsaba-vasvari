using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Kreta.View.Navigation;
using Kreta.View.Controls;

using Kreta.ViewModel;
using Kreta.View.Page;

namespace Kreta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentOfClassViewModel studentOfClassViewModel = new StudentOfClassViewModel();

        private void miStudentOfClass_Click(object sender, RoutedEventArgs e)
        {
            StudentOfClassPage studentOfClassPage = new StudentOfClassPage(studentOfClassViewModel);
            Navigation.Navigate(studentOfClassPage);
        }
    }
}
