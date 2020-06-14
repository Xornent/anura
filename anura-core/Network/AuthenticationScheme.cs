using System;
using System.Collections.Generic;
using System.Text;

namespace Anura.Network
{
    [Flags]
    public enum AuthenticationSchemes
    {
        None = 0x00000000,
        Digest = 0x00000001,
        Negotiate = 0x00000002,
        Ntlm = 0x00000004,
        Basic = 0x00000008,

        Anonymous = 0x00008000,

        IntegratedWindowsAuthentication = Negotiate | Ntlm,
    }
}
