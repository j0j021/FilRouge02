namespace Domain.Entities
{
    public class Materiel : IEntity
    {
        public Materiel()
        {
        }

        public Materiel(int? id, string nom, string? proprietaire)
        {
            Id = id;
            Nom = nom;
            Proprietaire = proprietaire;
        }

        public int? Id { get; set; }
        public string Nom { get; set; }
        public string? Proprietaire { get; set; }
    }
}
