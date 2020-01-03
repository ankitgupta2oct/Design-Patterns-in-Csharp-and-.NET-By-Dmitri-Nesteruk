namespace DesignPatternSample.Structural.Proxy.ProtectionProxy
{
    internal class ProtectionProxyDemo
    {
        public ProtectionProxyDemo()
        {
            ICar carProxy = new CarProxy();
            carProxy.Drive(new Driver(18, "Ankit"));
        }
    }
}