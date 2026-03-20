namespace Br.Com.ControleHoras.WebApi.Model
{
    public class Periodo
    {
        public int Id { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public ICollection<Dia> Dias { get; set; } = [];

        public Periodo(DateTime inicio, DateTime fim)
        {
            if (inicio >= fim)
            {
                throw new ArgumentException("Data inicial inválida.");
            }

            Inicio = inicio;
            Fim = fim;
            Dias = GerarPeriodo(inicio, fim);
        }

        private static ICollection<Dia> GerarPeriodo(DateTime inicio, DateTime fim)
        {
            ICollection<Dia> dias = [];
            int contador = 0;
            TimeSpan periodoEmDias = fim.Subtract(inicio);            
            
            do
            {
                if (contador > 0)
                {
                    inicio = inicio.AddDays(1);                                
                }

                dias.Add(new Dia(inicio));
                contador++;

            }
            while (contador <= periodoEmDias.Days);

            return dias;
        }
    }
}
