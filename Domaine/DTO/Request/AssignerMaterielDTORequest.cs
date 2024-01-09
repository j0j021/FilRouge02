using FluentValidation;

namespace Domain.DTO.Request
{
    public class AssignerMaterielDTORequest
    {
        public int idUser { get; set; }
        public int idMateriel { get; set; }
        public AssignerMaterielDTORequest(int idUser, int idMateriel)
        {
            this.idUser = idUser;
            this.idMateriel = idMateriel;
        }


    }
    public class AssignerMaterielDTORequestValidator : AbstractValidator<AssignerMaterielDTORequest>
    {
        public AssignerMaterielDTORequestValidator()
        {
            RuleFor(i => i.idUser).NotEmpty();
            RuleFor(u => u.idUser).NotEmpty();
        }
    }
}
