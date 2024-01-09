namespace FilRouge
{
    /// <summary>
    /// repésente les différentes catégories de matériel
    /// </summary>
    public class Categories
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public Categories(int id, string label)
        {
            Id = id;
            Label = label;
        }
    }
}
