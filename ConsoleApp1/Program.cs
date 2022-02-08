using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string frase = "O Rato roeu a roupa do rei de roma";
            //string termo = "Rato";
            Console.WriteLine("Digite a frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite o termo a ser buscado: ");
            string palavraBuscada = Console.ReadLine();
            frase = frase.ToLower();
            palavraBuscada = palavraBuscada.ToLower();
            string[] palavras = frase.Split(" ");
            int count = 0;
            foreach (var palavra in palavras){
                if (palavra.Equals(palavraBuscada))
                {
                    count++;
                }
            }
            Console.WriteLine("O termo foi encontrado "+count+" vezes na frase");
        }
    }
}
