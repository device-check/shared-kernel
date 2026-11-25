namespace shared_kernel.Exceptions.ApplicationLayerExceptions
{
    public class ApplicationLayerException : Exception
    {
        public ApplicationLayerException()
        {
        }

        public ApplicationLayerException(string? message) : base(message)
        {
        }
    }
}