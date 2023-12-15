namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                foreach(Pessoa hospede in hospedes)
                {
                    Console.WriteLine($"Hospede:{hospede.Nome}");   
                }
                Console.WriteLine("Usuários cadastrados com sucesso");
            }
            else
            {
                Console.WriteLine($"Você está tentando cadastrar {hospedes.Count} em uma suíte que tem capacidade para {Suite.Capacidade}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            if (DiasReservados >= 10)
            {
                decimal desconto = 0.9M;
                valor = DiasReservados * Suite.ValorDiaria * desconto;
            }
            else 
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }
            return valor;
        }
    }
}