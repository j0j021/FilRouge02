using FluentValidation;

namespace Domain.DTO.Request
{
    public class ModifyCategorieDTORequest
    {
        public ModifyCategorieDTORequest(int id, string label)
        {
            Id = id;
            Label = label;
        }

        public int Id { get; set; }
        public string Label { get; set; }
    }
    public class ModifyCategorieDTORequestValidator : AbstractValidator<ModifyCategorieDTORequest>
    {
        public ModifyCategorieDTORequestValidator()
        {
            RuleFor(x => x.Label).NotEmpty();
        }
    }
}
