using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefinalGarateAdolfina.Entidades
{
    class Triangulo
    {
        public double LadoA { get; private set; }
        public double LadoB { get; private set; }
        public double LadoC { get; private set; }
        public Color ColorRelleno { get; private set; }

        public Triangulo(double ladoA, double ladoB, double ladoC, Color colorRelleno)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
            ColorRelleno = colorRelleno;
        }

        public bool ValidarTriangulo()
        {
            return LadoA + LadoB > LadoC && LadoA + LadoC > LadoB && LadoB + LadoC > LadoA;
        }

        public double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public double CalcularArea()
        {
            double p = CalcularPerimetro() / 2;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }

        public string TipoTriangulo()
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                return "Equilátero";
            }
            else if (LadoA == LadoB || LadoB == LadoC || LadoA == LadoC)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}
