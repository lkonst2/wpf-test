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

namespace WPF_test.Items
{
    /// <summary>
    /// Interaction logic for TestWidgetTemplate2.xaml
    /// </summary>
    public partial class TestWidgetTemplate2 : UserControl
    {
        public TestWidgetTemplate2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Clicked");
        }
    }
}
