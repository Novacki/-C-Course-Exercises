using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndParamsAndRefOuOutAndVect {
    struct Fila {
        public static Aluno Aluno { get; set; } 
        
        public static Aluno Criar() {
            Aluno = new Aluno();

            Aluno.prox = null;
            if(Aluno == null) {
                Console.WriteLine("Sem Memória");
            }
            else {
                Console.WriteLine("Nome");
                Aluno.Nome = Console.ReadLine();

                Console.WriteLine("Nota");
                Aluno.Nota = double.Parse(Console.ReadLine());
            }

            return Aluno;
        }

        public static void InserirAluno( ref Aluno i, ref Aluno f) { //out Não funcionou
            Aluno novo = Criar();

            if(i == null) {
                i = novo;
            }
            else {
                f.prox = novo;
            }
            f = novo;
        }

        public static void Listar(Aluno i) {
            if(i == null) {
                Console.WriteLine("Fila Vazia");
            }
            else {
                while(i != null) {
                    Console.WriteLine(i);
                    i = i.prox;
                }
            }
        }
    }
}
