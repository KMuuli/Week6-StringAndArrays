using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            Console.WriteLine("Sisesta lause Hello World!");
            string fullSentence = Console.ReadLine();

            for(int i = fullSentence.Length-1; i >= 0; i--)
            {
                Console.Write(fullSentence[i]);
            }
        }
    }
}
