using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Services.Abstraction.Providers
{
    public interface IPasswordProvider
    {
        SecureString Password { get; }
    }
}
