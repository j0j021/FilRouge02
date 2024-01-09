using FluentValidation;

namespace Domaine.DTO.Request
{
    public class GetUserByNameDTORequest
    {
        public string Name { get; set; }
        public GetUserByNameDTORequest(string name)
        {
            Name = name;
        }


    }
    public class GetUserByNameValidator : AbstractValidator<GetUserByNameDTORequest>
    {
        public GetUserByNameValidator()
        {
            RuleFor(x => x.Name).NotEmpty();

        }
    }
}
