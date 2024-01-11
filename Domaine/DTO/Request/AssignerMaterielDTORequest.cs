using FluentValidation;

namespace Domain.DTO.Request
{
    public class AssignerMaterielDTORequest
    {
        public int? idUser { get; set; }
        public DateTime? Debut { get; set; }
        public DateTime? Fin { get; set; }
        public int idMateriel { get; set; }
        public AssignerMaterielDTORequest(int? idUser, int idMateriel, DateTime? debut, DateTime? fin)
        {
            this.idUser = idUser;
            this.idMateriel = idMateriel;
            Debut = debut;
            Fin = fin;
        }


    }
    public class AssignerMaterielDTORequestValidator : AbstractValidator<AssignerMaterielDTORequest>
    {
        public AssignerMaterielDTORequestValidator()
        {
            RuleFor(i => i.Debut).NotNull().NotEmpty();
            RuleFor(i => i.Fin).NotNull().NotEmpty();
            RuleFor(i => i.idUser).NotEmpty();
            RuleFor(u => u.idUser).NotEmpty();
        }
    }
}
