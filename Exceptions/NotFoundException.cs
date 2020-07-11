namespace CQRSMediatR.Exceptions
{
    public class NotFoundException : RestException
    {
        public NotFoundException(object errors)
            : base(System.Net.HttpStatusCode.NotFound, errors)
        {
        }
    }
}
