#if NETSTANDARD1_5

using System.Text;

namespace Serilog.Sinks.Email
{
    /// <summary>
    ///  Simple network crdential class
    /// </summary>
    public class SimpleNetworkCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
#endif
