using Movie_Theaters;
using System;
using System.Collections.Generic;
using System.Linq;
using TheaterApp;

namespace TheaterApp
{
    class Program
    {
       

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n===== ANA MENYU =====");
                Console.WriteLine("1. Yeni teatr yarat");
                Console.WriteLine("2. Yeni janr yarat");
                Console.WriteLine("3. Yeni film yarat");
                Console.WriteLine("4. Teatra daxil ol");
                Console.WriteLine("5. Proqramdan çıx");
                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateTheater(); break;
                    case "2": CreateGenre(); break;
                    case "3": CreateMovie(); break;
                    case "4": EnterTheater(); break;
                    case "5": return;
                    default: Console.WriteLine("Yanlış seçim!"); break;
                }
            }
        }
    }
}
//Burdan sonra ne edeceyimi bilmirem:(


