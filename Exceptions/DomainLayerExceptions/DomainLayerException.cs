using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared_kernel.Exceptions.DomainLayerExceptions
{
    public class DomainLayerException : Exception
    {

        public DomainLayerException(string? message) : base(message)
        {
        }
    }
}