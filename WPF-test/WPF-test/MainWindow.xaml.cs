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

namespace WPF_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            showData();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            viewbox.Width += 50;
            viewbox.Height += 50;
            showData();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            viewbox.Width -= 50;
            viewbox.Height -= 50;
            showData();
        }

        private void showData()
        {
            textBox.Text = String.Format("ActualWidth = {0}\nWidth = {1}", viewbox.ActualWidth, viewbox.Width);
            //textBox1.Text = String.Format("ScaleX = {0}\nScaleY = {1}", 1);
        }

        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text = String.Format("Mouse X={0}", e.GetPosition(canvas1).X);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            showData();
        }
    }
}
