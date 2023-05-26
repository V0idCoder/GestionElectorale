using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_electoraleUI
{
    public class Election
    {
        public int electionId { get; set; }
        public String nom { get; set; }
        public DateOnly dateElection { get; set; }
        public int nbSiege { get; set; }
        public String Description { get; set; }
        public int nbBulletin { get; set; }
        public int nbBulletinNull { get; set; }
        public int nbBulletinBlanc { get; set; }

        //Héritage de communeId ? --> 


    }
}
