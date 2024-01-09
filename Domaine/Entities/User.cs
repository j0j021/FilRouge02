namespace Domain.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime Created { get; set; }
        public string Telephone { get; set; }
    }
}
