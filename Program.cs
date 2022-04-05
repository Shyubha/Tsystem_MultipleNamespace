
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_MultipleNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            First_TSystem.TSystem objTSystem1 = new First_TSystem.TSystem();
            objTSystem1.Hello();
            Second_TSystem.TSystem objTSystem2 = new Second_TSystem.TSystem();
            objTSystem2.Hello();
            Console.ReadLine();

        }
    }
}
namespace First_TSystem
{
    public class TSystem
    {
        public void Hello()
        {
            Console.WriteLine("HELLO TSYSTEMS BATCH 1");
        }

    }
}
namespace Second_TSystem
{
    public class TSystem
    {
        public void Hello()
        {
            Console.WriteLine("HELLO TSYSTEMS BATCH 2");
        }
    }
}
