using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.Exceptions
{
    class AppException:ApplicationException
    {
        public AppException(string message): base(message)
        {

        }
    }
}
