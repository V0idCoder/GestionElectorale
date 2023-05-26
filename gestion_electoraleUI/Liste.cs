using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_electoraleUI
{
    public class Liste
    {
        public int listeId { get; set; }
        public int numero { get; set; }
        public string? nom { get; set; }
        public string? abreviation { get; set; }
        public int nbBulletinCompact { get; set; }

        //Héritage de electionId ? -->
    }
}
