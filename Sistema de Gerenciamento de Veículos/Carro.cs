﻿namespace Sistema_de_Gerenciamento_de_Veículos
{
    public class Carro : Veiculo
    {
        public string Tipo { get; set; } 

        public Carro(string modelo, int ano, double capacidadeTanque, double consumoPorKm, string tipo)
            : base(modelo, ano, capacidadeTanque, consumoPorKm)
        {
            Tipo = tipo;
        }

       
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Tipo: {Tipo}");
        }


        public override double CalcularConsumo(double distancia)
        {
            double consumoFinal = base.CalcularConsumo(distancia);

            switch (Tipo)
            {
                case "Híbrido":
                    consumoFinal *= 0.8;
                    break;
                case "Sedan":
                    consumoFinal *= 0.12;
                    break;
                case "Coupe":
                    consumoFinal *= 0.15;
                    break;
                case "Van":
                    consumoFinal *= 0.18;
                    break;
                case "Hatchback":
                    consumoFinal *= 0.14;
                    break;
                default:
                    consumoFinal *= 1;
                    break;
            }

            return consumoFinal;
        }
    }

}
