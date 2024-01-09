using FluentValidation;

namespace Domain.DTO.Request
{
    public class AddMaterielDTORequest
    {
        public AddMaterielDTORequest(string nom, int idCat)
        {
            Nom = nom;
            IdCat = idCat;
        }

        public string Nom { get; set; }
        public int IdCat { get; set; }

    }
    public class AddMaterielDTORequesttValidator : AbstractValidator<AddMaterielDTORequest>
    {
        public AddMaterielDTORequesttValidator()
        {
            RuleFor(x => x.Nom).NotEmpty();
            RuleFor(x => x.IdCat).NotEmpty();
        }
    }
}
