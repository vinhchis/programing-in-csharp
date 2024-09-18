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
    /// Interaction logic for Ex02_TextBlock.xaml
    /// </summary>
    public partial class Ex02_TextBlock : Window
    {
        public Ex02_TextBlock()
        {
            InitializeComponent();
            txt03.FontSize = 50;
            double left = 10, top = 10, right = 10, bottom = 10;
            txt03.Margin = new Thickness(left, top, right, bottom);
        }
    }
}
