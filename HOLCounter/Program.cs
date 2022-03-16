using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on "Hello World!"

            Console.WriteLine("Hello World!");
            string fullSentence = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;



            for (int i = 0; i < fullSentence.Length; i++)
            {
                if(fullSentence[i] == 'h')
                {
                    hCounter++;

                }
             }

            for(int i = 0; i < fullSentence.Length; i++)
            {
                if (fullSentence[i] == 'o')
                {
                    oCounter++;
                }
            }

            for (int i = 0; i < fullSentence.Length; i++)
            {
                if (fullSentence[i] == 'l')
                {
                    lCounter++;

                }
            }

            Console.WriteLine($"Hello World! - lauses on { hCounter} h-täht , { oCounter} o-tähte ja { lCounter} l-tähte.");
            
        }
    }
}
