using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişken
            string kurs1 = "Yazılım Geliştirici yetiştirici kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "Phyton";
            string kurs5 = "c#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("statik yapı  bitti ---------------------------");


            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici yetiştirici kampı", "Programlamaya başlangıç için temel kurs", "java", "Python","c#" };

            //for dögüsü
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("for dögüsü bitti----------------------");

            
            
            //foreach döngüsü diziler için
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("foreach dögüsü bitti------------------");







            Console.WriteLine("Sayfa Sonu - Footer");
            Console.WriteLine("---------------");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("---------------");
            
            for (int i = 1; i < 10; i = i +2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------");
            
            for (int i = 1; i < 10; i +=2)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
