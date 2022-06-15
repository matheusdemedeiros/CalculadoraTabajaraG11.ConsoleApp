
using System;
using System.Collections.Generic;

namespace CalculadoraTabajaraG11.ConsoleApp
{

    public class Program
    {
        //2º Deve realizar operações de subtração

        static List<string> historico = new List<string>();

        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para realizar operações de Adição\n");

                Console.WriteLine("Digite 2 para realizar operações de Subtração\n");

                Console.WriteLine("Digite 3 para realizar operações de Multiplicação\n");

                Console.WriteLine("Digite 5 para mostrar o histórico das operações\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("Por favor, digite uma opção válida!");
                    Console.ReadLine();
                    continue;
                }

                #endregion

                #region Realizar Cálculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                string operacao = "", simbolo = "";

                switch (opcao)
                {
                    case "1": operacao = "Adição"; simbolo = "+"; break;

                    case "2": operacao = "Subtração"; simbolo = "-"; break;

                    case "3": operacao = "Multiplicação"; simbolo = "*"; break;

                    case "5":

                        Console.Clear();

                        Console.WriteLine("Calculadora Tabajara\n");

                        Console.WriteLine("Historico de operações realizadas\n");

                        if (historico.Count > 0)
                            foreach (var item in historico)
                                Console.WriteLine(item);
                        else
                            Console.WriteLine("Nenhuma operação realizada ainda!");

                        Console.ReadLine();

                        continue;

                        break;

                    default: break;
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;

                    case "2": resultado = primeiroNumero - segundoNumero; break;

                    case "3": resultado = primeiroNumero * segundoNumero; break;

                    default: break;
                }

                string operacaoAtual = $"{primeiroNumero} {simbolo} {segundoNumero} = {resultado}";

                historico.Add(operacaoAtual);

                #endregion

                #region Mostrar Resultado

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação da {operacao} é: {resultado}");

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

                #endregion
            }
        }
    }
}