using Clinica.DDD.Application.Commands;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Validations
{
    public class RemoveConsultaValidation : Validation<RemoveConsultaCommand>
    {
        public RemoveConsultaValidation()
        {
            ValidarId();
        }
    }
}
