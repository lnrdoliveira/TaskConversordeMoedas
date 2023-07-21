using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course{
    public class Conversor{
        public static double Iof = 6.0;
        public static double DolarToReal(double quantia, double cotacao){
            double total = quantia*cotacao;
            return total + total * Iof/100.0;
        }
    }
}