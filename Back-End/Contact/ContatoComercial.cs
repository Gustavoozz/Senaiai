using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj { get; set; }
    }
}