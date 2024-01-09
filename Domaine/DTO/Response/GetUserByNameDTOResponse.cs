namespace Domaine.DTO.Response
{
    public class GetUserByNameDTOResponse
    {
        public GetUserByNameDTOResponse(string? name, int? id, string? email, string? telephone, DateTime? created, DateTime? updated, string? firstName, string? role)
        {
            Name = name;
            Id = id;
            Email = email;
            Telephone = telephone;
            Created = created;
            Updated = updated;
            FirstName = firstName;
            Role = role;
        }

        public string? Name { get; set; }
        public int? Id { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string? FirstName { get; set; }
        public string? Role { get; set; }
    }
}
