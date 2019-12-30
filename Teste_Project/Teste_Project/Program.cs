using System;
using System.Globalization;


namespace Teste_Project {
    class Program {
        static void Main(string[] args) {
            Aluno[] aluno = new Aluno[4];

            int j = 0, i = 0;

            for (i = 0; i < aluno.Length; i++) {
                aluno[i] = new Aluno();
                Console.WriteLine("Digite o Nome do Aluno: ");
                aluno[i].Nome = Console.ReadLine();
                Console.WriteLine("Aluno: " + aluno[i].Nome);

                for (j = 0; j < aluno.Length; j++) {
                    Console.WriteLine($"Digite a {j + 1}° nota:");
                    aluno[i].Nota[j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

            }
            MostraOrdem(aluno);
            Console.WriteLine("--------------------------------------------------------");
            Ordena(aluno);
            Console.WriteLine("--------------------------------------------------------");
            MostraOrdem(aluno);
        }

        public static void Ordena(Aluno[] aluno) {
            int i = 0, j = 0;
            for (i = 0; i < aluno.Length; i++) {
                for (j = i + 1; j < aluno.Length; j++) {
                    if (aluno[i].CalculaMedia() < aluno[j].CalculaMedia()) {
                        Aluno aux = new Aluno();
                        aux = aluno[i];
                        aluno[i] = aluno[j];
                        aluno[j] = aux;
                    }
                }
            }
        }

        public static void MostraOrdem(Aluno[] aluno) {
            int i = 0;
            do {
                Console.WriteLine(aluno[i]);
                i++;
            } while (i < aluno.Length);
        }
    }
}
