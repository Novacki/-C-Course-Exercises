using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GetAndSet {
    class Calc {
        public static double[] Notas = new double[4]; 
   
        
        //Insere Notas
        public static void InsereNotas() {

            for(int i = 0; i < Notas.Length; i++) {
                Console.WriteLine($"Digite a {i + 1}º Nota:");
                Notas[i] = double.Parse(Console.ReadLine());
             
            }
        }


        public static double Media() {
            return Calcula() / Notas.Length;        
        }

        private static double Calcula() {
            double total = 0;
      
            for(int i = 0; i < Notas.Length; i++) {
                total += Notas[i];    
            }

            return total;
        }
    }
}
