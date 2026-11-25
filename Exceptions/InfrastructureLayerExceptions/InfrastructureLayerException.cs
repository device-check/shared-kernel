namespace shared_kernel.Exceptions.InfrastructureLayerExceptions
{
    public class InfrastructureLayerException : Exception
    {
        public InfrastructureLayerException()
        {
        }

        public InfrastructureLayerException(string? message) : base(message)
        {
        }
    }
}