using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeCSharp
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    internal class DBMethodAttribute : Attribute
    {
        public DBMethodAttribute(string msg)
        {
            this.Message = msg;
        }

        public string Message { get; private set; }
    }
}