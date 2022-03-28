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

using Kreta.ViewModel;

namespace Kreta.View.Page
{
    /// <summary>
    /// Interaction logic for StudentOfClassPage.xaml
    /// </summary>
    public partial class StudentOfClassPage : UserControl
    {
        private StudentOfClassViewModel studentOfClassViewModel;

        public StudentOfClassPage(StudentOfClassViewModel studentOfClassViewModel)
        {
            this.studentOfClassViewModel = studentOfClassViewModel;
            InitializeComponent();
            this.DataContext = studentOfClassViewModel;
        }
    }
}
