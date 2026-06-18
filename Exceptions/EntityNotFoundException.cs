namespace DiplomaticMission.Exceptions
{
    public class EntityNotFoundException : BaseDiplomaticException
    {
        public EntityNotFoundException(string entityName, object id) 
            : base($"{entityName} with ID {id} was not found.") { }
    }
}
