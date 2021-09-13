using System;
using System.Collections.Generic;
using System.Text;

namespace CalcCirculo
{
    class Calculadora
    {   
        //Cria a variavel com o valor de Pi
        public static double Pi = 3.14;
        
        //Fórmula para calcular a Circunferencia do raio
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        //Fórmula para Calcular o Volume do Raio
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
