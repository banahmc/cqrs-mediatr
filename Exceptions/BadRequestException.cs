namespace CQRSMediatR.Exceptions
{
    public class BadRequestException : RestException
    {
        public BadRequestException(object errors)
            : base(System.Net.HttpStatusCode.BadRequest, errors)
        {
        }
    }
}
