using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_electoraleUI
{
    public class Candidat
    {
        public int candidatId { get; set; }
        public int numero { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateOnly dateNaissance { get; set; }
        public string profession { get; set; }
        public int listeId { get; set; }
    }
}
