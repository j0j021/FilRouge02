using Domain.DTO.Request;
using FluentValidation;

namespace Domain.DTO.Request
{
    public class AddMaterielDTORequest
    {
        public AddMaterielDTORequest(string nom, int idCat, DateTime? debut, DateTime? fin)
        {
            if (debut is null)
            {
                Debut = DateTime.Now;
            }
            if (fin is null)
            {
                Fin = DateTime.Now;
            }

            Nom = nom;
            IdCat = idCat;
        }

        public string Nom { get; set; }
        public int IdCat { get; set; }
        public DateTime? Debut { get; set; }
        public DateTime? Fin { get; set; }


    }
}
public class AddMaterielDTORequesttValidator : AbstractValidator<AddMaterielDTORequest>
{
    public AddMaterielDTORequesttValidator()
    {
        RuleFor(x => x.Nom).NotEmpty();
        RuleFor(x => x.IdCat).NotEmpty();
    }
}

