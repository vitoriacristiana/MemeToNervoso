using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            String fraseDigitada,  fraseMemetoNervoso; 
            Console.Write("Usuário, o que você pensa sobre mim?" );
            fraseDigitada = Console.ReadLine();

              fraseMemetoNervoso = 
              $"{fraseDigitada.Remove(10)} ... NÃO, PERA.\n Tô nervoso";

              Console.WriteLine(fraseMemetoNervoso);
              


      


        }
    }
}
