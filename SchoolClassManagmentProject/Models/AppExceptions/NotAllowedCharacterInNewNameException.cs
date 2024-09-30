using System.Runtime.Serialization;

namespace SchoolClassManagmentProject.Models.AppExceptions
{
    [Serializable]
    internal class NotAllowedCharacterInNewNameException : Exception
    {
        public NotAllowedCharacterInNewNameException()
        {
        }

        public NotAllowedCharacterInNewNameException(string? message) : base(message)
        {
        }

        public NotAllowedCharacterInNewNameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotAllowedCharacterInNewNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}