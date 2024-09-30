using System.Runtime.Serialization;

namespace SchoolClassManagmentProject.Models.AppExceptions
{
    [Serializable]
    internal class NewPhoneEqualsToOldOneException : Exception
    {
        public NewPhoneEqualsToOldOneException()
        {
        }

        public NewPhoneEqualsToOldOneException(string? message) : base(message)
        {
        }

        public NewPhoneEqualsToOldOneException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewPhoneEqualsToOldOneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}