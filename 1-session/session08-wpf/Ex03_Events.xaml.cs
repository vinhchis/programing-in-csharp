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
using System.Windows.Shapes;

namespace session08_wpf
{
    /// <summary>
    /// Interaction logic for Ex03_Events.xaml
    /// </summary>
    public partial class Ex03_Events : Window
    {
        public Ex03_Events()
        {
            InitializeComponent();
            txt01.FontSize = txt02.FontSize = txt03.FontSize = 30;
        }

        private void txt03_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt02.Text = txt03.Text;
        }

        private void txt03_GotFocus(object sender, RoutedEventArgs e)
        {
            txt03.Clear();
        }
    }
}
