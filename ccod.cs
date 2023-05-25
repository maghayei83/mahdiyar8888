using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class employer
    {
        int employeeid{set; get;}

        date date{set; get;}

        string reason{set; get}
    }
}
class randomGenerator
{

    static void main()
    {
        System.Random random = new System.Random();
        System.Console.WriteLine(random.Next());
        System.Console.WriteLine(random.Next(50));
        System.Console.WriteLine(random.Next(10, 50));
    }
}