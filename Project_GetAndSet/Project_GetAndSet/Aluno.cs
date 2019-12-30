using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GetAndSet {
    class Aluno {
        public string Nome { get; set; }
        
        public Aluno(string nome) {
            Nome = nome;
        }

        public string Situacao() {
           
            if(Calc.Media() < 6) {
                return "Reprovado";
            }
            else {
                return "Aprovado";
            }
        }
    }
}
