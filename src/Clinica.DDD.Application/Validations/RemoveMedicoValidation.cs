using Clinica.DDD.Application.Commands;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Validations
{
    public class RemoveMedicoValidation : Validation<RemoveMedicoCommand>
    {
        public RemoveMedicoValidation()
        {
            ValidarId();
        }
    }
}
