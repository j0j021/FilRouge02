namespace Domaine.Exceptions;
public class NotFoundEntityException : Exception
{
    public NotFoundEntityException(string entity, int id) : base($"L'entité {entity} avec l'id :{id}est introuvable")
    {

    }
}

