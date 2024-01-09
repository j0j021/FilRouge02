using Domain.DTO.Request;
using FluentValidation;

namespace Domain.DTO.Request
{
    public class ModifyMaterielDTORequest
    {
        public ModifyMaterielDTORequest(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
public class ModifyMaterielDTORequestValidator : AbstractValidator<ModifyMaterielDTORequest>
{
    public ModifyMaterielDTORequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Id).NotEmpty();
    }
}