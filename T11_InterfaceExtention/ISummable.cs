using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_InterfaceExtention
{
    public interface ISummable : IEnumerable
    {
        decimal GetSum { get; }
        
    }
}
