using System;

namespace ProgramaçãoEstruturadaE1.ConsoleApp
{


    /*
     Encontrar o Maior Valor da sequência
    • Encontrar o Menor Valor da sequência
    • Encontrar o Valor Médio da sequência
    • Encontrar os 3 maiores valores da sequência
    • Encontrar os valores negativos da sequência
    • Mostrar na Tela os valores da sequência
    • Remover um item da sequência
    
     Critérios de Aceite:
    • Para obter o Maior valor utilize o modificador de parâmetro: ref
    • Para obter o Menor valor utilize o modificador de parâmetro: out
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Entrada de dados

            int[] valores = new int[10] { -3, -7, -5, 8, 705, 34, 65, 204, 5, 5 };
            /*
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);

                valores[i] = int.Parse(Console.ReadLine());
            }
            */

            #endregion

            #region Processamento e apresentação dos dados

            ExibirTodosValores(valores);

            ValoresNegativos(valores);

            ValorMedio(valores);

            valores = RemoverItem(valores);

            ExibirTodosValores(valores);

            TresMaioresValores(valores);

            ExibirTodosValores(valores);

            MaiorValor(ref valores);

            #region Mostrando o menor valor com o modificador out

            MenorValor(valores, out int menor);

            Console.WriteLine("\nMenor valor{0}", menor);

            #endregion

            #endregion

        }

        #region Métodos
        static void MaiorValor(ref int[] numeros)
        {
            Console.WriteLine("\n=========================================================");

            Console.WriteLine("EXIBINDO O MAIOR VALOR DO ARRAY");

            int maior = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            Console.WriteLine("\nMaior valor: {0}", maior);
        }
        static void MenorValor(int[] numeros, out int menor)
        {
            Console.WriteLine("\n=========================================================");

            Console.WriteLine("EXIBINDO O MENOR VALOR DO ARRAY");

            menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

        }
        static void ValorMedio(int[] numeros)
        {
            Console.WriteLine("\n=========================================================");

            decimal media = 0m;

            for (int i = 0; i < numeros.Length; i++)
            {
                media += numeros[i];
            }

            media = media / numeros.Length;

            Console.WriteLine("Média dos valores: {0}", media);
        }
        static void TresMaioresValores(int[] numeros)
        {
            Console.WriteLine("\n=========================================================");

            Console.WriteLine("EXIBINDO OS TRÊS MAIORES VALORES DO ARRAY");
            
            int[] arrayAuxiliar = new int[numeros.Length];
            
            Array.Copy(numeros, arrayAuxiliar, numeros.Length);

            Array.Sort(arrayAuxiliar);

            int cont = 0;

            for (int i = arrayAuxiliar.Length - 1; arrayAuxiliar.Length >= 0; i--)
            {
                if (arrayAuxiliar[i] != arrayAuxiliar[i - 1])
                {
                    Console.WriteLine("{0}º Maior valor (Índice) {1}: {2}", cont + 1, i, arrayAuxiliar[i]);

                    cont++;

                    if (cont == 3)
                    {
                        break;
                    }
                }
            }

        }
        static void ValoresNegativos(int[] numeros)
        {
            Console.WriteLine("\n=========================================================");

            Console.WriteLine("EXIBINDO OS VALORES NEGATIVOS DO ARRAY");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("Índice {0} é negativo: {1}", i, numeros[i]);
                }
            }
        }
        static void ExibirTodosValores(int[] numeros)
        {
            Console.WriteLine("\n=========================================================");

            Console.WriteLine("EXIBINDO TODOS OS VALORES DO ARRAY");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Índice {0}: {1}", i, numeros[i]);
            }

        }
        static int[] RemoverItem(int[] numeros)
        {
            Console.WriteLine("\n=========================================================");

            Console.WriteLine("REMOVENDO UM VALOR DO ARRAY");

            Console.Write("Informe a posição do item que deseja remover: ");

            int posicao = int.Parse(Console.ReadLine());

            int[] arrayRetorno = new int[numeros.Length - 1];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i < posicao)
                {
                    arrayRetorno[i] = numeros[i];
                }
                else if (i >= posicao && posicao < (numeros.Length - 1) && i < arrayRetorno.Length)
                {
                    arrayRetorno[i] = numeros[i + 1];
                }
            }

            return arrayRetorno;

        }

        #endregion
    }
}
