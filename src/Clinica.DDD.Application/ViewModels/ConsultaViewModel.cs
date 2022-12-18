using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.DDD.Application.ViewModel
{
    public class ConsultaViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public string? MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        public MedicoViewModel? Medicos { get; set; }
        // relacionamentos

    }
}
