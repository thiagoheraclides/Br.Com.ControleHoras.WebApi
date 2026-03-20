namespace Br.Com.ControleHoras.WebApi.Model
{
    public class Dia(DateTime dataHora)
    {
        public DateOnly DataHora { get; set; } = DateOnly.FromDateTime(dataHora);

        public string DiaDaSemana { get; set; } = ObterDiaSemana(dataHora.DayOfWeek);

        public bool DiaUtil { get; set; } = !(dataHora.DayOfWeek == DayOfWeek.Sunday | dataHora.DayOfWeek == DayOfWeek.Saturday);

        public TimeSpan? HorasTrabalhadas { get; set; }

        public ICollection<Marcacao> Marcacoes { get; set; } = [];

        private static string ObterDiaSemana(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Domingo";
                case DayOfWeek.Monday:
                    return "Segunda";
                case DayOfWeek.Tuesday:
                    return "Terça";
                case DayOfWeek.Wednesday:
                    return "Quarta";
                case DayOfWeek.Thursday:
                    return "Quinta";
                case DayOfWeek.Friday:
                    return "Sexta";
                case DayOfWeek.Saturday:
                    return "Sábado";
                default:
                    return string.Empty;
            }
        }
    }
}
