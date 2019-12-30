using System;

namespace StructsAndParamsAndRefOuOutAndVect {
    class Program {
        static void Main(string[] args) {
            char op = '0';
            int quantidade = 0;
            Aluno i = null, f = null;

            while(op != '5') {
                Console.WriteLine("1 - Inserir || 2 - Listar");
                op = char.Parse(Console.ReadLine());
                if(op == '1') {
                    Fila.InserirAluno(ref  i, ref f);
                    quantidade++;
                }
                else if (op == '2') {
                    Fila.Listar(i);
                }
            }
            Aluno[] aluno = new Aluno[quantidade];
            Aluno aux = i;
            for (int j = 0; j < aluno.Length; j++) {
                aluno[j] = aux;
                aux = aux.prox;
            }

            Console.WriteLine("Imprimir por Vetor");

            foreach(Aluno novo in aluno) { //novo = apelido para cada elemento da coleção 
                Console.WriteLine(novo.ToString());
            }


        }
    }
}
