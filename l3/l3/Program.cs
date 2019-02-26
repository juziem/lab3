using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    class Program
    {
        static void Main(string[] args)
        {
            int key, a, b, res;
            Console.WriteLine("Vvedite nomer komandi:\n1. Vvedite A \n2. Vvedite B\n3. Vvedite +\n4. Vvedite -\n5. Vvedite *\n6. Vvedite /");
            key = Console.Read();
            switch (key)
            {
                case 1: 
                case 2: 
                case 3: 
                case 4:
                case 5:
                case 6: res = a / b; break;
                default: break;
            }
            Console.ReadKey();
        }
    }
}
