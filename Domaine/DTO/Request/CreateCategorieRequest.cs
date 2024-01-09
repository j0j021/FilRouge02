using FluentValidation;

namespace Domain.DTO.Request;

public class CreateCategorieRequest
{
    public CreateCategorieRequest(string label)
    {
        Label = label;
    }

    public int Id { get; set; }
    public string Label { get; set; }
}
public class CreateCategorieRequestValidator : AbstractValidator<CreateCategorieRequest>
{
    public CreateCategorieRequestValidator()
    {
        RuleFor(x => x.Label).NotEmpty()
        .NotNull();
    }
}
