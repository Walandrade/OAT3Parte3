using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3Part3.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("===========================================================================================");
            Console.WriteLine("|45 -   Vetor de inteiros                                                                 |");
            Console.WriteLine("|46 -   Valor  x, y                                                                       |");
            Console.WriteLine("|47 -   Vetor dez numeros                                                                 |");
            Console.WriteLine("|48 -   Agencia de modelos                                                                |");
            Console.WriteLine("|49 -   vetor                  v1, v2                                                     |");
            Console.WriteLine("|50 -   Sortear um numero de 0 a 100                                                      |");
            Console.WriteLine("|51 -   Calçcular a quantidade de alunos                                                  |");
            Console.WriteLine("|52 -   Vetor positivo                                                                    |");
            Console.WriteLine("|53 -   Corrida automoveis                                                                |");
            Console.WriteLine("|54 -  Vetores A e B                                                                      |");
            Console.WriteLine("|55 -  Retirar espaco em branco                                                           |");
            Console.WriteLine("|56 -  Números pares e multiplos de cinco                                                 |");
            Console.WriteLine("|57 -   Imprimir somente vogais                                                           |");
            Console.WriteLine("|58 -   Armazenar em vetor varios números inteiros                                        |");
            Console.WriteLine("|59 -  Caracteres de A -Z                                                                 |");
            Console.WriteLine("|60 -  Numero do quadrante                                                                |");
            Console.WriteLine("|61 -   Salario atualizado                                                                |");
            Console.WriteLine("|62 -  Calculo da ipotenusa                                                               |");
            Console.WriteLine("|63 -   Verificar se é par ou impar                                                       |");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("Escolha uma opcao:  ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 45:

                    AtividadeOAT3 exercicio1 = new AtividadeOAT3();

                    exercicio1.Atividade45();


                    break;
                case 46:
                    AtividadeOAT3 exercicio2 = new AtividadeOAT3();

                    exercicio2.Atividade46();


                    break;
                case 47:
                    AtividadeOAT3 exercicio3 = new AtividadeOAT3();

                    exercicio3.Atividade47();


                    break;
                case 48:
                    AtividadeOAT3 exercicio4 = new AtividadeOAT3();

                    exercicio4.Atividade48();


                    break;
                case 49:
                    AtividadeOAT3 exercicio5 = new AtividadeOAT3();

                    exercicio5.Atividade49();

                    break;
                case 50:
                    AtividadeOAT3 exercicio6 = new AtividadeOAT3();

                    exercicio6.Atividade50();


                    break;
                case 51:
                    AtividadeOAT3 exercicio7 = new AtividadeOAT3();

                    exercicio7.Atividade51();


                    break;
                case 52:
                    AtividadeOAT3 exercicio8 = new AtividadeOAT3();

                    exercicio8.Atividade52();

                    break;
                case 53:
                    AtividadeOAT3 exercicio9 = new AtividadeOAT3();

                    exercicio9.Atividade53();


                    break;
                case 54:
                    AtividadeOAT3 exercicio10 = new AtividadeOAT3();

                    exercicio10.Atividade54();

                    break;
                case 55:
                    AtividadeOAT3 exercicio11 = new AtividadeOAT3();

                    exercicio11.Atividade55();


                    break;
                case 56:
                    AtividadeOAT3 exercicio12 = new AtividadeOAT3();

                    exercicio12.Atividade56();
                    break;
                case 57:
                    AtividadeOAT3 exercicio13 = new AtividadeOAT3();

                    exercicio13.Atividade57();
                    break;
                case 58:
                    AtividadeOAT3 exercicio14 = new AtividadeOAT3();

                    exercicio14.Atividade58();
                    break;
                case 59:
                    AtividadeOAT3 exercicio15 = new AtividadeOAT3();

                    exercicio15.Atividade59();
                    break;
                case 60:
                    AtividadeOAT3 exercicio16 = new AtividadeOAT3();

                    exercicio16.Atividade60();
                    break;
                case 61:
                    AtividadeOAT3 exercicio17 = new AtividadeOAT3();

                    exercicio17.Atividade61();
                    break;
                case 62:
                    AtividadeOAT3 exercicio18 = new AtividadeOAT3();

                    exercicio18.Atividade62();
                    break;
                case 63:
                    AtividadeOAT3 exercicio19 = new AtividadeOAT3();

                    exercicio19.Atividade63();
                    break;
                
                


                default:
                    Console.WriteLine("Opção Invalida!");
                    break;



            }

        }
    }
}
