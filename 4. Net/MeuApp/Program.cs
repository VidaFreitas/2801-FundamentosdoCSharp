using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "andre";
            switch (valor)
            {
                case "joao": Console.WriteLine("Não é o cara!"); break;
                case "marcelo": Console.WriteLine("Não é o cara!"); break;
                case "andre": Console.WriteLine("É este!"); break;
                default: Console.WriteLine("Não encontrei!"); break;
            }
        }
    }
}
