using System;

namespace lab_4
{
    public class ArmyOperationException : InvalidOperationException
    {
        public ArmyOperationException() : base(){ }
        public ArmyOperationException(string message) : base(message) { }
        public ArmyOperationException(string? message, Exception? innerException) : base(message, innerException)
        {}
    }

    public class EntityNotFoundException : ArmyOperationException
    {
        public string EntityName { get; }

        public EntityNotFoundException(string entityName)
            : base($"Entity '{entityName}' was not found.")
        { 
            EntityName = entityName;
        }

        public EntityNotFoundException(string entityName, string message) : base(message)
        {
            EntityName = entityName;
        }
    }


    public class InvalidParameterException : ArgumentException
    {
        public InvalidParameterException(string paramName, string message) : base(message, paramName) { }
        public InvalidParameterException(string message) :base(message){ }
    }
}
