namespace Clinica.DDD.Architectura.API.ViewModels
{
    public class ConsultaViewModel
    {
        public string? Id { get; set; }
        public string? MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        // relacionamentos
        public MedicoViewModel? Medicos { get; set; }
    }
}
