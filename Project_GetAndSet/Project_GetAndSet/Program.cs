using System;

namespace Project_GetAndSet {
    class Program {
        static void Main(string[] args) {
      
            Aluno aluno = new Aluno("Cleonice");

            Calc.InsereNotas();

            Console.WriteLine("Aluna: " + aluno.Nome);
            Console.WriteLine("Media: " + Calc.Media().ToString("F2"));
            Console.WriteLine(aluno.Situacao());

            Aluno aluno2 = new Aluno("Fernando");

            Calc.InsereNotas();

            Console.WriteLine("Aluno: " + aluno2.Nome);
            Console.WriteLine("Media: " + Calc.Media());
            Console.WriteLine(aluno.Situacao());
        }
    }
}
