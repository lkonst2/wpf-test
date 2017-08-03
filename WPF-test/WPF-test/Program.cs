using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        interface IHierarchy
        {
            object getParent();
            ICollection getChilds();
        }

        class Subchild : IHierarchy
        {
            string name;
            Child parent;
            public ICollection getChilds()
            {
                return null;
            }

            public object getParent()
            {
                return parent;
            }
        }

        class Child : IHierarchy
        {
            string name;
            List<Subchild> list;
            Root parent;

            public object getParent()
            {
                return parent;
            }

            public ICollection getChilds()
            {
                return list;
            }
        }

        class Root : IHierarchy
        {
            string name;
            List<Child> list;

            public object getParent()
            {
                return null;
            }

            public ICollection getChilds()
            {
                return list;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(int));
            Console.ReadKey();
        }

    }
}
