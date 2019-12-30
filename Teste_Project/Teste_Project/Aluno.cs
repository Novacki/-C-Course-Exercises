using System;


namespace Teste_Project {
    class Aluno {
       public string Nome;
       public double[] Nota = new double[4];

        public double CalculaMedia() {
            double media = 0;
            for(int i = 0; i < Nota.Length; i++) {
                media += Nota[i];
            }

            return media / Nota.Length;            
        }

        public string Situacao() {
            if(CalculaMedia() > 6) {
                return "Aprovado";
            }else {
                return "Reprovado";
            }
        }

        public override string ToString() { //Override indica que é um método de outra classe
            return " A Média é: " + CalculaMedia()
                    + " Situação do Aluno " + Nome + ": " + Situacao();
        }
    }
}
