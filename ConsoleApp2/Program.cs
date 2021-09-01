//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Globalization;


namespace ConsoleApp2
{
    class Program
    {
        Dados x , y;

        static void Main(string[] args)
        {
            //Declaração de variavel da classe Dados
            Dados x,y;

            //Instanciar a variavel
            x = new Dados();
            y = new Dados();

            //Solicitar o nome da primeira pessoa
            Console.WriteLine("Insira o nome da primeira pessoa:");
            x.nome = Console.ReadLine();
            //Solicitar a idade da primeira pessoa
            Console.WriteLine("Insira a idade da primeira pessoa:");
            x.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Solicitar o nome da segunda pessoa
            Console.WriteLine("Insira o nome da segunda pessoa:");
            y.nome = Console.ReadLine();
            //Solicitar a idade da segunda pessoa
            Console.WriteLine("Insira a idade da segunda pessoa:");
            y.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Comparar e informar quem é o mais velho
            if (x.idade > y.idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + x.nome);
            }
            if (x.idade == y.idade)
            {
                Console.WriteLine("As duas pessoas tema mesma idade");
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + y.nome);
            }
            Console.ReadKey();
        }
    }
}
