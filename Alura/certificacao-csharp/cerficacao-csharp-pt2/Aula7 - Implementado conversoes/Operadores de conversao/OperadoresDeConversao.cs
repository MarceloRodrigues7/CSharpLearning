using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerficacao_csharp_pt2.Aula7___Implementado_conversoes.Operadores_de_conversao
{
    class OperadoresDeConversao : IAulaItem
    {
        public void Executar()
        {
            AnguloEmGraus anguloEmGraus = (AnguloEmGraus)45;
            Console.WriteLine(anguloEmGraus);

            AnguloEmRadianos anguloEmRadianos = 15;
            Console.WriteLine(anguloEmRadianos);

            double graus = anguloEmGraus;

            anguloEmRadianos = anguloEmGraus;
            anguloEmGraus = anguloEmRadianos;
            System.Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            System.Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }

        public struct AnguloEmRadianos
        {
            public double Radianos { get; }

            public AnguloEmRadianos(double radianos)
            {
                this.Radianos = radianos;
            }

            public static implicit operator AnguloEmRadianos (AnguloEmGraus graus)
            {
                return new AnguloEmRadianos(graus.Graus * System.Math.PI / 180);
            }

            public static implicit operator AnguloEmRadianos(double radianos)
            {
                return new AnguloEmRadianos(radianos);
            }

            public static implicit operator double (AnguloEmRadianos radianos)
            {
                return radianos.Radianos;
            }

            public override string ToString()
            {
                return String.Format("{0} radianos", this.Radianos);
            }
        }

        public struct AnguloEmGraus
        {
            public double Graus { get; }

            public AnguloEmGraus(double graus) { this.Graus = graus; }

            public static implicit operator AnguloEmGraus (AnguloEmRadianos radianos)
            {
                return new AnguloEmGraus(radianos.Radianos * 180 / System.Math.PI);
            }

            public static explicit operator AnguloEmGraus (double graus)
            {
                return new AnguloEmGraus(graus);
            }

            public static implicit operator double (AnguloEmGraus graus)
            {
                return graus.Graus;
            }

            public override string ToString()
            {
                return String.Format("{0} graus", this.Graus);
            }
        }

    }

    
}
