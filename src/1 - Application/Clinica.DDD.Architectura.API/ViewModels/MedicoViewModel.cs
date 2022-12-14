namespace Clinica.DDD.Architectura.API.ViewModels
{
    public class MedicoViewModel
    {
        public string? Id { get; set; }

        //autommaper
        public string? Nome { get; set; }
        public string? NomeClinica { get; set; }


        public string? Crm { get; set; }
        public string? Idade { get; set; }
        public string? Telefone { get; set; }
        public string? Ddd { get; set; }


        // relacionamentos
        public IEnumerable<ConsultaViewModel>? Consultas { get; set; }
    }
}
