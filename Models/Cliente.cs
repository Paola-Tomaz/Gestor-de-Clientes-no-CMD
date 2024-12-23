using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Gestor_de_clientes_do_CMD.Models
{
    [System.Serializable]
    public struct Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        
    }

    
}