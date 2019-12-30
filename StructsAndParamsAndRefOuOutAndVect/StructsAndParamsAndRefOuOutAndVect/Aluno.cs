using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndParamsAndRefOuOutAndVect {
    class Aluno {
        public string Nome { get; set; }
        private double _nota;
        public Aluno prox;

        public double Nota {
            get { return _nota; }
            set { if (value < 0 || value > 10) {
                    _nota = 0;
                }
                else {
                    _nota = value; 
                } }
        }
        
        public Aluno() { }
        public Aluno(string nome, double nota) {
            Nome = nome;
            Nota = nota;
        }

        public override string ToString() {
            return "Nome: " + Nome + " Nota: " + Nota; //retorna um ponteiro para string
        }


    }
}
