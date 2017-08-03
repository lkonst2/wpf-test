using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public class StrList : List<string>
        {
        }

        static void Main(string[] args)
        {
            /*
            List<string> strings = new List<string>(
                new string[]
                {
                    "Button1",
                    "Button3",
                    "Knopka",
                    "Button5",
                    "Buttons23"
                }
                );

            string TemplateString = "^Button";

            foreach(
              var s in strings.Where(a => Regex.Match(a, $@"{TemplateString}").Success)
              )

              Console.WriteLine(s);
            Console.ReadKey();
            */
            List<string> list1 = new List<string>(
                new string[]
                {
                    "Button1",
                    "Button3",
                    "Knopka",
                    "Button5",
                    "Buttons23"
                }
                );

            List<string> list2 = new List<string>(
                new string[]
                {
                    "ton1",
                    "ton3",
                    "pka",
                }
                );
            List<List<string>> mainlist = new List<List<string>>();
            mainlist.Add(list1);
            mainlist.Add(list2);

            var q1 = from l1 in (from l in mainlist select l) S ;
            foreach (var item in q1)
                Console.WriteLine(item);
            Console.ReadKey();
        }

    }
}
