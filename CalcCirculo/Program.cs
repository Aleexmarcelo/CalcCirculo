using System;
using System.Globalization;

namespace CalcCirculo
{
    class Program
    {
        static void Main(string[] args)

        {
            Calculadora calc = new Calculadora();

            //Pede para o usuário digitar o tamanho do circulo desejado
            Console.WriteLine("Entre com o valor do raio");
            //Joga os dados para a classe Calculadora e efetua o calculo
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            //Printa no console o resultado da area do circulo
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}

