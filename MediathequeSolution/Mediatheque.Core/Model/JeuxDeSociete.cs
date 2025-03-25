namespace Mediatheque.Core.Model
{
    public class JeuxDeSociete: ObjetDePret
    {
        public JeuxDeSociete(string titreDeLObjet, int ageMini, int ageMaxi, string editeur, TypeJeuxDeSociete type) : base(titreDeLObjet,"Null")
        {
            this.AgeMaximum = ageMaxi;
            this.AgeMinimum = ageMini;
            this.Editeur = editeur;
            this.TypeJeux = type;
        }

        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public string Editeur { get; set; }
        public TypeJeuxDeSociete TypeJeux { get; set; }
    }
}
