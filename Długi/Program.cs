using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Długi
{
    class Program
    {
        static void Main(string[] args)
        {
            int dlug = 5000;
            int miesiecznaOszczednasc = 300;
            int zaoszczedzone = 0;
            int miesiac = 0;

            while (zaoszczedzone<dlug)
            {
                zaoszczedzone += miesiecznaOszczednasc;
                miesiac++;
                Console.WriteLine("{0} miesiąc spłacono {1} długu.", miesiac, zaoszczedzone);
            }
            Console.WriteLine("");
            Console.WriteLine("Dług zostanie spłacony po {0} miesiacach", miesiac);
            Console.WriteLine("Zostanie mu {0} zł nadwyżki.", (zaoszczedzone-dlug));

            Console.ReadKey();


        }
    }
}
