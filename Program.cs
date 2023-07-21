using System;
using System.Globalization;
using Course;

namespace TaskConv{
    class Porgram{
        static void Main(String[] args){

            System.Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = Conversor.DolarToReal(quantia, cotacao);
            System.Console.WriteLine("Valor a pagar: R$ "+ result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
} 