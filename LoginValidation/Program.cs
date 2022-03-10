using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            int i = 0;
           

            while (i < 3)
            {

                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    if (3 - i == 0)
                    {
                        Console.WriteLine("Vale kasutajatunnus või salasõna! Proovi mõne aja pärast uuesti!");
                    }
                    else
                    {
                        Console.WriteLine($"Vale kasutajatunnus või salasõna! Proovi uuesti. Sul on {3 - i} jäänud katset!");
                    } 

                }
                
            }

        }
    }
}
