using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_test.Main
{
    public class MainWindowViewModel
    {
        public List<TestItem> Items { get; set; }

        public MainWindowViewModel()
        {
            string @namespace = "WPF_test.Items";

            // Get the list of classes derived from UserControls, using LINQ and Reflection
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == @namespace && t.BaseType.Name == "UserControl"
                    select t;

            // Create the list of instances of this classes (and also create this instances using Reflection)
            Items = new List<TestItem>();
            q.ToList().ForEach
                ( t => Items.Add
                    ( 
                        new TestItem()
                        {
                            Name = t.Name, // using class name (without namespace) as the name of tab
                            Content =  (UserControl)Activator.CreateInstance(t.UnderlyingSystemType)
                        }
                    )
                );


        }
    }
}
