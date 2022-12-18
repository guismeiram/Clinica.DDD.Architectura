using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.DDD.Application.ViewModel
{
    public class ConsultaViewModel
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public MedicoViewModel Medicos { get; set; }
        // relacionamentos

    }
}
