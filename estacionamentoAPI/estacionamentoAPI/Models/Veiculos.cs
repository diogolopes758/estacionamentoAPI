namespace EstacionamentoAPI.Models
{
    public class Veiculos
    {
        public string Placa { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime? DataSaida { get; set; }

        public decimal? ValorPago { get; set; }

    }
}
