using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Core.DomainObjects
{
    public abstract class Entity
    {
        public DateTime DataCadastro { get; private set; }
        public int Id { get; private set; }

        protected Entity() { }
        public Entity(int id)
        {
            Id = id;
            DataCadastro = DateTime.Now.Date;
        }
    }
}
