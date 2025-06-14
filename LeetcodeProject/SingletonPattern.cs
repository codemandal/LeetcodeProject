using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class SingletonPattern
    {
    }

    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(() => new SingletonLazy());
        private int cnt = 0;
        public static SingletonLazy Instance { get { return instance.Value; } }

        private SingletonLazy() {
            cnt++;
            Console.WriteLine("This class has " + cnt + "instances");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
