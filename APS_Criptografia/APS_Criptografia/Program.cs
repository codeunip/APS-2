using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace APS_Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            //long e, p, Ca, Cb, Xa, Xb;


            //Console.WriteLine("Digite o número primo");
            //p = Convert.ToInt64(Console.ReadLine());

            //Console.WriteLine("Digite um número menor que o número primo digitado");
            //e = Convert.ToInt64(Console.ReadLine());

            //Console.WriteLine("Digite a primeira chave A");
            //Ca = Convert.ToInt64(Console.ReadLine());

            //Console.WriteLine("Digite a primeira chave B");
            //Cb = Convert.ToInt64(Console.ReadLine());

            //Xa = Convert.ToInt64(Math.Pow(e, Ca) % p);
            //Console.WriteLine(Xa);

            //Xb = Convert.ToInt64(Math.Pow(e, Cb) % p);
            //Console.WriteLine(Xb);

            //BigInteger bigInt = new BigInteger(217416671473944530487060546875 % 179);
            //Console.WriteLine(bigInt);


            BigInteger bigInt = new BigInteger(Math.Pow(2, 1023));
            Console.WriteLine(bigInt);

            Console.ReadKey();



        }
    }
}
