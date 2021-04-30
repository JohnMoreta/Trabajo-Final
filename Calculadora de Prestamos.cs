using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora de Prestamos
{
    class Program
    {
        static void Main(string[] args)
        {

            float Pago;
            float Interes_pagado;
            float Capital_pagado;
            float Monto;
            float Interes;
            float Mensual;
            int Fila;
            int Plazo;
            int i;

            Console.Write("Introduce el monto del prestamo: ");
            float.TryParse(Console.ReadLine(), out Monto);
            Console.Write("Introduce la tasa de interes anual: ");
            float.TryParse(Console.ReadLine(), out Interes);
            Console.Write("Introduce el plazo en meses: ");
            int.TryParse(Console.ReadLine(), out Plazo);

            Mensual = (Interes / 100) / 12;

            Pago = Mensual + 1;
            Pago = (float)Math.Pow(Pago, Plazo);
            Pago = Pago - 1;
            Pago = Mensual / Pago;
            Pago = Mensual + Pago;
            Pago = Monto * Pago;

            Console.WriteLine();
            Fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de pago \t");
            Console.Write("Pago \t\t");
            Console.Write("Intereses Pagados \t\t");
            Console.Write("Capital Pagado \t\t");
            Console.Write("Monto del prestamo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Monto);


            for (i = 1; i <= Plazo; i++)
            {

                Console.Write("\t{0}\t\t", Fila);

                Console.Write("{0}\t", Pago);

                Interes_pagado = Mensual * Monto;
                Console.Write("{0}\t\t", Interes_pagado);

                Capital_pagado = Pago - Interes_pagado;
                Console.Write("\t{0}\t", Capital_pagado);

                Monto = Monto - Capital_pagado;
                Console.Write("\t{0}\t", Monto);

                Fila = Fila + 1;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}