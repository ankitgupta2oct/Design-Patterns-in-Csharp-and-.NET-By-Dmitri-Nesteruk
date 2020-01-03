using DesignPatternSample.Structural.Proxy.DynamicLoggingProxy;
using DesignPatternSample.Structural.Proxy.PropertyProxy;
using DesignPatternSample.Structural.Proxy.ProtectionProxy;

namespace DesignPatternSample.Structural.Proxy
{
    class Executor
    {
        public Executor()
        {
            // Protection Proxy
            //new ProtectionProxyDemo();

            // Property Proxy
            //new PropertyProxyDemo();

            // Dynamic Logging Proxy
            new DynamicLoggingProxyDemo();
        }
    }
}
