namespace Domain.Entities
{
    public class Categorie : IEntity
    {
        public Categorie()
        {
        }

        public Categorie(string label)
        {
            Label = label;
        }

        public int Id { get; set; }
        public string Label { get; set; }
    }
}
