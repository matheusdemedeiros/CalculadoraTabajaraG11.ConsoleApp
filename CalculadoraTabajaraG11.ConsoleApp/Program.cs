using System;

namespace CalculadoraTabajaraG11.ConsoleApp
{
    public class Program
    {
        //2º Deve realizar operações de subtração
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 2 para realizar operações de Subtração\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;
                }

                #endregion
            }
        }
}
