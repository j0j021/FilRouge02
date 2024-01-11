namespace Domain.Entities
{
    public class Materiel : IEntity
    {



        public Materiel()
        {

        }

        public Materiel(int id, string? nom, string? proprietaire, DateTime? debut, DateTime? fin)
        {
            Id = id;
            Nom = nom;
            Proprietaire = proprietaire;
            Debut = debut;
            Fin = fin;
        }

        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Proprietaire { get; set; }

        private DateTime? _debut = null;

        public DateTime? Debut
        {
            get
            {
                return _debut;
            }
            set
            {
                _debut = (value == DateTime.MinValue) ? null : value;
            }
        }

        private DateTime? _fin = null;
        public DateTime? Fin
        {
            get
            {
                return _fin;
            }
            set
            {
                _fin = (value == DateTime.MinValue) ? null : value;
            }
        }
    }
}
