using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Client C1 = new Client();
            // Field değer ataması yapılmasın ama değer okunabilsin.
            // Field değer ataması yapılsın ama değer okunamasın.
            // Field değer ataması yapılsın ama değerin ilk dört hanesi okunsun.
            // Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin. Veri daha sonra gösterilsin.



            //Genel olarak kapsülleme konusuna giriş yaptık.
            C1.EmailAddress = "yk.58@hotmail.com";
            Console.WriteLine(C1.EmailAddress);
        }
    }
}
