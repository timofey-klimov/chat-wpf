using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Chat.Security
{
    public static class SecureStringExtensions
    {
        public static string UnsecurePassword(this SecureString secureString)
        {
            if (secureString == null)
                return string.Empty;

            var unmanageString = IntPtr.Zero;

            try
            {
                unmanageString = Marshal.SecureStringToGlobalAllocAnsi(secureString);
                return Marshal.PtrToStringAnsi(unmanageString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanageString);
            }
        }
    }
}
