using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercicio5();
            Console.ReadKey();

        }

        private static void exercicio1()
        {
            string nome;
            decimal nota1, nota2, nota3, nota4, resultado;
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Bem vindo-vindo " + nome);

            Console.WriteLine("digite seu nome: \n");
            nome = Console.ReadLine();
            Console.WriteLine("bem-vindo " + nome);
            Console.WriteLine("digiteva nota 1: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("digiteva nota 2: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("digiteva nota 3: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("digiteva nota 4: ");
            nota4 = Convert.ToDecimal(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("O aluno obteve uma média de: " + resultado);
            Console.ReadLine();

        }

        private static void exercicio2()
        {
            
            const double PI = 3.14159;

            
            Console.Write("Digite o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            
            double area = PI * raio * raio;

            
            Console.WriteLine("A área do círculo é: " + area);

           
        }

        private static void exercicio3()
        {
            Console.WriteLine("Digite o primeiro número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: "); 
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            double numero3 = Convert.ToDouble(Console.ReadLine());


            double media = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine("A média é: " + media);

            
 
        }

        private static void exercicio4()
        {
            
            double resultado = 2 + 3 * Math.Pow(4, 2) / Math.Pow(1 - 5, 2) + 3 * Math.Pow(4, 2) / (1 - 5);

            
            Console.WriteLine("O resultado da expressão é: " + resultado);
            
        }

        private static void exercicio5()
        {
            
            Console.Write("Digite o preço original do produto: ");
            double precoOriginal = Convert.ToDouble(Console.ReadLine());

            
            double desconto = precoOriginal * 0.1;

            
            double precoFinal = precoOriginal - desconto;

            
            Console.WriteLine($"O preço final do produto com desconto é: R${precoFinal}");
        }
    }
    
}
