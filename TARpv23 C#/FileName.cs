using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_C_
{
    public class FileName
    {
        public static void Main(string[] args)
        {
            //I.osa 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}", nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus=Funktsioonid.Liitmine(a,b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus=Funktsioonid.Liitmine(a,(int)arv);
            Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }
            int vastus1 = Funktsioonid.Calculate(a, b);
            if (vastus1 > 50)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus1);
            }

        }
    }
}
