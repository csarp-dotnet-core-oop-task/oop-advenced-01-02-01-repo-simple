using System.Runtime.Serialization;

namespace SchoolClassManagmentProject.Models.AppExceptions
{
    [Serializable]
    internal class NewEmailEqualsToOldOneException : Exception
    {
        public NewEmailEqualsToOldOneException()
        {
        }

        public NewEmailEqualsToOldOneException(string? message) : base(message)
        {
        }

        public NewEmailEqualsToOldOneException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewEmailEqualsToOldOneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}