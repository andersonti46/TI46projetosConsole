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
            string nome;
            decimal nota1, nota2, nota3, nota4, resultado;
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
    }
}
