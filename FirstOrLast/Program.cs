using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust 
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine(); 
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes {lastName.Length} sümbolit");
            
            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine($"{firstName} on pikem kui {lastName}."); 
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine($"{lastName} on pikem kui {firstName}.");
            }
            else
            {
                Console.WriteLine($"{firstName} on sama pikk kui {lastName}."); 
            }

            Console.WriteLine("Kena päeva!");            
        }
    }
}
