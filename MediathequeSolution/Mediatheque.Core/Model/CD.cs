namespace Mediatheque.Core.Model
{

    public class CD : ObjetDePret
    {
        public string Groupe { get; set; }
        public string Titre { get; set; }


        public CD(string titreDeLObjet, string groupe) : base(titreDeLObjet,"null")
        {
            this.Titre = titreDeLObjet ;
            this.Groupe = groupe ;
        }

    }
}
