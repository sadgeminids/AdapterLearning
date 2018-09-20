using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterByInterface ad = new AdapterByInterface();
            // To do something with ad ...

            TargetInterface tInterface = ad;
            tInterface.OnGUI();


            SourceClass sc = new SourceClass();
            // To do something with sc

            TargetClass tClass = new AdapterByClass(sc);
            tClass.OnGUI();

            Console.ReadKey();

        }
    }
}
