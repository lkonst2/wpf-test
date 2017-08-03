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

namespace WPF_test
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = this;
            ListOfEvents = new List<EventItem>()  {
                new EventItem() { Name="Item1", Visible=true },
                new EventItem() { Name="Item2", Visible=true },
                new EventItem() { Name="Item3", Visible=true }
            };
        }

        public List<EventItem> ListOfEvents;
    }

    public class EventItem
    {
        public string Name { get; set; }
        public Boolean Visible { get; set; } 
    }
}
