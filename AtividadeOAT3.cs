using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3Part3.cs
{
    internal class AtividadeOAT3
    {

        public void  Atividade45() 
        {
            Console.Write("Digite a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];

            for (int x = 0; x < quantidade; x++)
            {
                Console.Write("Digite o número " + (x + 1) + ": ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sequência de números na ordem inversa:");

            for (int x = quantidade - 1; x >= 0; x--)
            {
                Console.WriteLine(numeros[x]);
            }


        }
        public void Atividade46()
        {
            int n = 5;

            int[] x = new int[] { 1, 2, 3, 4, 5 };

            int[] y = new int[] { 6, 7, 8, 9, 10 };

            int produtoEscalar = CalcularProdutoEscalar(x, y);

            Console.WriteLine("O produto escalar dos vetores x e y é: " + produtoEscalar);
        }

        static int CalcularProdutoEscalar(int[] vetorX, int[] vetorY)
        {
            if (vetorX.Length != vetorY.Length)
            {
                throw new ArgumentException("Os vetores devem ter o mesmo tamanho.");
            }

            int produtoEscalar = 0;

            for (int x = 0; x < vetorX.Length; x++)
            {
                produtoEscalar += vetorX[x] * vetorY[x];
            }

            return produtoEscalar;


        }
        public void Atividade47()
        {
            int tamanhoVetor = 10;

            int[] vetor = new int[tamanhoVetor];

            Console.WriteLine("Digite os elementos do vetor:");
            for (int x = 0; x < tamanhoVetor; x++)
            {
                Console.Write("Elemento {0}: ", x + 1);
                vetor[x] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o número X: ");
            int numeroX = int.Parse(Console.ReadLine());

            int maioresQueX = 0;
            int menoresQueX = 0;
            int iguaisAX = 0;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (vetor[i] > numeroX)
                {
                    maioresQueX++;
                }
                else if (vetor[i] < numeroX)
                {
                    menoresQueX++;
                }
                else
                {
                    iguaisAX++;
                }
            }

            Console.WriteLine("Quantidade de números maiores que X: " + maioresQueX);
            Console.WriteLine("Quantidade de números menores que X: " + menoresQueX);
            Console.WriteLine("Quantidade de números iguais a X: " + iguaisAX);


        }
        public void Atividade48()
        {
            int quantidadeCandidatas = 20;

            string[] nomes = new string[quantidadeCandidatas];
            int[] idades = new int[quantidadeCandidatas];

            Console.WriteLine("Digite o nome e idade das candidatas:");
            for (int x = 0; x < quantidadeCandidatas; x++)
            {
                Console.Write("Nome da candidata {0}: ", x + 1);
                nomes[x] = Console.ReadLine();

                Console.Write("Idade da candidata {0}: ", x + 1);
                idades[x] = int.Parse(Console.ReadLine());
            }

            string[] candidatasAptas = new string[quantidadeCandidatas];
            int contador = 0;

            for (int x = 0; x < quantidadeCandidatas; x++)
            {
                if (idades[x] >= 18 && idades[x] <= 20)
                {
                    candidatasAptas[contador] = nomes[x];
                    contador++;
                }
            }

            Console.WriteLine("Candidatas aptas para a campanha publicitária:");
            for (int x = 0; x < contador; x++)
            {
                Console.WriteLine(candidatasAptas[x]);
            }


        }
        public void Atividade49()
        {
            int n = 0;
            do
            {
                Console.Write("Digite o tamanho dos vetores (entre 1 e 50): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 50);

            int[] v1 = new int[n];
            int[] v2 = new int[n];

            Console.WriteLine("Digite os elementos do vetor V1:");
            for (int x = 0; x < n; x++)
            {
                Console.Write("Elemento {0}: ", x + 1);
                v1[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor V2:");
            for (int x = 0; x < n; x++)
            {
                Console.Write("Elemento {0}: ", x + 1);
                v2[x] = int.Parse(Console.ReadLine());
            }

            int contador = 0;

            for (int x = 0; x < n; x++)
            {
                if (v1[x] == v2[x])
                {
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de valores idênticos nas mesmas posições: " + contador);


        }
        public void Atividade50()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(101);
            int tentativas = 0;
            int tentativa;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar um número de 0 a 100.");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                if (tentativa < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior do que sua tentativa.");
                }
                else if (tentativa > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor do que sua tentativa.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número sorteado em " + tentativas + " tentativas.");
                }
            }
            while (tentativa != numeroSorteado);

            Console.ReadLine();


        }
        public void Atividade51()
        {
            Console.Write("Digite a quantidade de alunos: ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            double[] notas = new double[quantidadeAlunos];
            double somaNotas = 0;
            int alunosAcimaDeSete = 0;

            for (int x = 0; x < quantidadeAlunos; x++)
            {
                Console.Write("Digite a nota do aluno " + (x + 1) + ": ");
                notas[x] = double.Parse(Console.ReadLine());
                somaNotas += notas[x];

                if (notas[x] > 7.0)
                {
                    alunosAcimaDeSete++;
                }
            }

            if (quantidadeAlunos > 0)
            {
                double media = somaNotas / quantidadeAlunos;
                Console.WriteLine("A média aritmética das notas é: " + media.ToString("F2"));

                if (alunosAcimaDeSete > 0)
                {
                    Console.WriteLine("Quantidade de alunos com nota acima de 7.0: " + alunosAcimaDeSete);
                }
                else
                {
                    Console.WriteLine("Não há nenhum aluno com nota acima de 7.0.");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno foi inserido.");
            }

            Console.ReadLine();


        }
        public void Atividade52()
        {
            int[] vetor = new int[100];
            int tamanho = 0, contador;


            Console.WriteLine("Digite os valores do vetor (-1 para encerrar):");
            int num = int.Parse(Console.ReadLine());
            while (num != -1 && tamanho < 100)
            {
                vetor[tamanho] = num;
                tamanho++;
                num = int.Parse(Console.ReadLine());
            }
            int contador1 = 0;
            int contador3 = 0;
            int contador4 = 0;
            for (int x = 0; x < tamanho; x++)
            {
                if (vetor[x] == 1)
                    contador1++;
                else if (vetor[x] == 3)
                    contador3++;
                else if (vetor[x] == 4)
                    contador4++;
            }
            Console.WriteLine(" O número 1 aparece: " + contador1 + " vezes");
            Console.WriteLine(" O número 3 aparece: " + contador3 + " vezes");
            Console.WriteLine(" O número 4 aparece: " + contador4 + " vezes");
            Console.WriteLine();


        }
        public void Atividade53()
        {
            Console.Write("Digite o número de voltas: ");
            int numVoltas = int.Parse(Console.ReadLine());

            double[] tempos = new double[numVoltas];
            double melhorTP = double.MaxValue;
            int voltaMelhorTP = -1;
            double somaTP = 0;

            for (int x = 0; x < numVoltas; x++)
            {
                Console.Write($"Digite o tempo da volta {x + 1}: ");
                tempos[x] = double.Parse(Console.ReadLine());

                if (tempos[x] < melhorTP)
                {
                    melhorTP = tempos[x];
                    voltaMelhorTP = x + 1;
                }

                somaTP += tempos[x];
            }

            double tempoMedio = somaTP / numVoltas;

            Console.WriteLine("O melhor tempo foi: " + melhorTP);
            Console.WriteLine("A volta do melhor tempo foi: " + voltaMelhorTP);
            Console.WriteLine("O tempo médio das voltas foram: " + tempoMedio);
            Console.WriteLine();



        }
        public void Atividade54()
        {
            int[] vetorA = { 1, 3, 4, 5, 8 };
            int[] vetorB = { 4, 5, 6, 7, 8, 10, 11, 12 };

            Console.WriteLine(" Os elementos comuns dos vetores A e B são:");

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    if (vetorA[i] == vetorB[j])
                    {
                        Console.WriteLine(vetorA[i]);
                        break;
                    }
                }
            }


        }
        public void Atividade55()
        {
            Console.WriteLine("Digite uma frase de até 50 caracteres:");
            string frase = Console.ReadLine();

            string fraseSemEspacos = frase.Replace(" ", "");


            int qtdEspacos = frase.Length - fraseSemEspacos.Length;

            Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
            Console.WriteLine("Quantidade de espaços em branco: " + qtdEspacos);
            Console.WriteLine();


        }
        public void Atividade56()
        {
            int[] vetor = new int[5];
            int qtdPares = 0;
            int qtdMultiplosDe5 = 0;

            Console.WriteLine("Informe os valores do vetor:");

            for (int x = 0; x < 5; x++)
            {
                Console.Write("Vetor[{0}]: ", x);
                vetor[x] = int.Parse(Console.ReadLine());

                if (vetor[x] % 2 == 0)
                {
                    qtdPares++;
                }

                if (vetor[x] % 5 == 0)
                {
                    qtdMultiplosDe5++;
                }
            }

            Console.WriteLine("Quantidade de números pares: " + qtdPares);
            Console.WriteLine("Quantidade de múltiplos de 5: " + qtdMultiplosDe5);
            Console.WriteLine();



        }
        public void Atividade57()
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("As Vogais na frase são:");

            for (int x = 0; x < frase.Length; x++)
            {
                char caractere = frase[x];

                if (IsVowel(caractere))
                {
                    Console.Write(caractere);
                }
            }

            Console.WriteLine();

            static bool IsVowel(char c)
            {
                c = char.ToLower(c);

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    return true;
                }

                return false;
            }




        }
        public void Atividade58()
        {
            Console.WriteLine("Quantidade de números a serem lidos:");
            int qtd = int.Parse(Console.ReadLine());

            int[] numeros = new int[qtd];
            int soma = 0;
            int maior = 0;

            for (int x = 0; x < qtd; x++)
            {
                Console.WriteLine("Digite o número {0}:", x + 1);
                numeros[x] = int.Parse(Console.ReadLine());

                soma += numeros[x];

                if (numeros[x] > maior)
                {
                    maior = numeros[x];
                }
            }

            double media = (double)soma / qtd;

            Console.WriteLine("Média: {0}", +media);
            Console.WriteLine("Maior número: {0}", +maior);
            Console.WriteLine();


        }
        public void Atividade59()
        {
            Console.WriteLine("Digite dois caracteres de A a Z em ordem alfabética:");
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            if (char1 >= 'A' && char1 <= 'Z' && char2 >= 'A' && char2 <= 'Z')
            {
                if (char1 > char2)
                {
                    Console.WriteLine("Erro: Os caracteres não estão em ordem alfabética.");
                }
                else
                {
                    int numCaracteres = char2 - char1 - 1;
                    Console.WriteLine("O número de caracteres entre '{0}' e '{1}' é: {2}", char1, char2, numCaracteres);
                }
            }
            else
            {
                Console.WriteLine("Erro: Os caracteres devem ser letras maiúsculas de A a Z.");
            }


        }
        public void Atividade60()
        {
            int x = 0, y = 0;

            Console.WriteLine("Informe o valor da cordenada x");
            int X =
            int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da cordenada y");
            int Y =
            int.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)

            {
                Console.WriteLine("O ponto x é:" + X + " e y:" + Y + " pertence ao primeiro quadrante");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("O ponto x é:" + X + " e y:" + Y + " pertence ao segundo quadrante");
            }
            if (X < 0 && Y < 0)
            {
                Console.WriteLine("O ponto x é:" + X + " e y:" + Y + " pertence ao terceiro quadrante");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("O ponto x é:" + X + " e y:" + Y + " pertence ao quarto quadrante");
            }
            Console.ReadLine();



        }
        public void Atividade61()
        {
            int salario, reajuste, novoS;

            Console.WriteLine("informe o salário atual:");
            int Salario =
            int.Parse(Console.ReadLine());
            Console.WriteLine("informe a porcentagem do reajuste:");
            reajuste =
            int.Parse(Console.ReadLine());
            reajuste = 2500 * 10 / 100;
            novoS = 2500 + 250;
            Console.WriteLine("o novo salário é de: " + novoS);
            Console.ReadLine();


        }
        public void Atividade62()
        {
            double Base, altura, Hipotenusa;



            Console.WriteLine("digite o tamanho da base");
            Base =
            double.Parse(Console.ReadLine());

            Console.WriteLine("digite o tamanho da altura");
            altura =
            double.Parse(Console.ReadLine());
            Hipotenusa = (Base * Base) + (altura * altura);
            Console.WriteLine("A hipotenusa é: " + Hipotenusa + "Base, altura:");



        }
        public void Atividade63()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            string resultado = Verifica(numero);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        static string Verifica(int numero)
        {
            if (numero % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "ÍMPAR";
            }


        }
        












    }
}
