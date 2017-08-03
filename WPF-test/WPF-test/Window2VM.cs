using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_test
{

    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate t1 { get; set; }
        public DataTemplate t2 { get; set; }
        public DataTemplate t3 { get; set; }
        public override DataTemplate SelectTemplate(object item,
            DependencyObject container)
        {
            if (item is Type1)
                return t1;
            if (item is Type2)
                return t2;
            if (item is Type3)
                return t3;
            return null;
        }
    }

    public class Type1
    {
        public String text
        {
            get; set;
        }
    }

    public class Type2
    {
        public String text
        {
            get; set;
        }
    }

    public class Type3
    {
        public String text
        {
            get; set;
        }
        public List<Type4> Items { get; set;}
    }

    public class Type4
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }

    public class Window2VM
    {
        private object selectedItem;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<object> Items
        {
            get; set;
        }

        public Window2VM()
        {
            Items = new ObservableCollection<object>
            {
                new Type1 { text = "Type1" },
                new Type2 {text = "Type2" },
                new Type3 {text = "Type3", Items = new List<Type4>
                    {
                        new Type4 { Value1 = "Key1", Value2="Value1" },
                        new Type4 { Value1 = "Key2", Value2="Value2" },
                        new Type4 { Value1 = "Key3", Value2="Value3" },
                        new Type4 { Value1 = "Key4", Value2="Value4" },
                        new Type4 { Value1 = "Key5", Value2="Value5" }
                    }
                }
            };
        }

        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }

        }

    }

}
