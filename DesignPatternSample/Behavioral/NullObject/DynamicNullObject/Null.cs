
using ImpromptuInterface;
using System;
using System.Dynamic;

namespace DesignPatternSample.Behavioral.NullObject.DynamicNullObject
{
    class Null<TInterface> : DynamicObject where TInterface : class
    {
        public static TInterface Instance
        {
            get
            {
                if (!typeof(TInterface).IsInterface)
                    throw new ArgumentException("Should be interfece");

                return new Null<TInterface>().ActLike<TInterface>();
            }
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Activator.CreateInstance(binder.ReturnType);
            return true;
        }
    }
}