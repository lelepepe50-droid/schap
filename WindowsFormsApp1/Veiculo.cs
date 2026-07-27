using System;

namespace WindowsFormsApp1
{
    public class Veiculo
    {
        private static int nextId = 1;

        public Veiculo()
        {
            Id = nextId++;
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Combustivel { get; set; }
        public decimal Quilometragem { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public string Foto { get; set; }
    }
}
