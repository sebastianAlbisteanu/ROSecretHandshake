using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomGenerator = new Random();
            Comportament.bunSimt = true;
            for (var i = 0; i < 10; i = i + 1)
            {
                if (i == 3)
                {
                    var manager = new Manager(randomGenerator);
                    Console.WriteLine(manager.SalutSecret("Ion"));
                }
                else
                {


                    if (Comportament.bunSimt == true)
                    {
                        var persoana = new Persoana(randomGenerator);
                        Console.WriteLine(persoana.SalutSecret());
                    }
                    else
                    {
                        Console.WriteLine("@#*&");
                    }

      
                }
            }

            Console.Read();

        }
    }
}