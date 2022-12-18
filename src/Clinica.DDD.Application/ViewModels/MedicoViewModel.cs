using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.DDD.Application.ViewModel
{
    public class MedicoViewModel
    {
        public int Id { get; set; }

        //autommaper
        public string Nome { get; set; }
        public string NomeClinica { get; set; }


        public int Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }

        public IEnumerable<ConsultaViewModel > Consulta { get; set; }
    }
}
