using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.Platforms
{
    internal interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
