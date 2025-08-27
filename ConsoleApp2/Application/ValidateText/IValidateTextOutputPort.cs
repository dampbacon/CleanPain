using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopedVmBundleClean.Application.ValidateText
{

    public interface IValidateTextOutputPort
    {
        void Present(string? error);
    }

}
