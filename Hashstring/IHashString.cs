using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassing
{
    public interface IHashString
    {
        string StringHash(string text,string salt);
    }
}
