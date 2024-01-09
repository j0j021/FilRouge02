using FluentValidation;

namespace Domain.DTO.Request;

public class GetRoleRequest
{
    public GetRoleRequest(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public string Name { get; set; }
    public string Password { get; set; }

}
public class GetRoleValidator : AbstractValidator<GetRoleRequest>
{
    public GetRoleValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}
