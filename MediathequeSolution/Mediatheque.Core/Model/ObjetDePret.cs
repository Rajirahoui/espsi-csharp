using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Core.Model
{

    public class ObjetDePret
    {
        public string TitreDeLObjet { get; set; }
        public string Emprunteur { get; set; }
        public bool EstDisponible { get; private set; } = true;
                
        public ObjetDePret (string  titreDeLObjet , string emprunteur )
        {
            this.TitreDeLObjet = titreDeLObjet;
            this.Emprunteur = emprunteur;
            this.EstDisponible = true;

        }

        public bool Emprunte(string emprunteur)
        {
    if (!EstDisponible) return false;
    
    this.Emprunteur = emprunteur;
    this.EstDisponible = false;
    return true;
}
    }
}
