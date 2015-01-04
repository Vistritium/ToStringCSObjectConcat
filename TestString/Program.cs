using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleJSON;

namespace TestString
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new JSONClass();
            foo["key"] = "foo";
            String a = "a" + foo;
            String b = "b" + foo.ToString();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
