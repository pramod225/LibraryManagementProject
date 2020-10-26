using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application
{
    class CustomException : Exception
    {
        string massage;
         public CustomException( string massage)
        {
            this.massage = massage;
        }
    }
}
