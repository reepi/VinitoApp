using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Cata
    {
        public string Nombre { get; set; }
        public Wine Vino { get; set; }
        public List<string> ListaDeInvitados { get; set; } = new List<string>();
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
