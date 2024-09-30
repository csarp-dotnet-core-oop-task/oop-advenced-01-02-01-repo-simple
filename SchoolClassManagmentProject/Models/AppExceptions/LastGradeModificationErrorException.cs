namespace SchoolClassManagmentProject.Models.AppExceptions
{
    [Serializable]
    public class LastGradeModificationErrorException : ArgumentException
    {
        public LastGradeModificationErrorException() 
        {
        }

        public LastGradeModificationErrorException(string? message) : base(message)
        {
        }

        public LastGradeModificationErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public LastGradeModificationErrorException(string? message, string? parameterName ,Exception? innerException) : base(message,parameterName,innerException)
        {
             
        }
    }
}