using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DesignPatternSample.Structural.Proxy.DynamicLoggingProxy
{
    class Log<T> : DynamicObject where T : class, new()
    {
        private T _subject;
        private readonly Dictionary<string, int> _metholdCallCount;

        public Log(T subject)
        {
            _subject = subject;
            _metholdCallCount = new Dictionary<string, int>();
        }

        public string Info
        {
            get
            {
                var stringBuilder = new StringBuilder();
                foreach (var kv in _metholdCallCount)
                {
                    stringBuilder.Append($"{kv.Key} called {kv.Value} time(s)");
                }
                return stringBuilder.ToString();
            }
        }

        public static I As<I>() where I : class
        {
            if (!typeof(I).IsInterface)
                throw new ArgumentException("I must be an interface type");

            // duck typing here!
            return new Log<T>(new T()).ActLike<I>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args,
            out object result)
        {
            try
            {
                if (_metholdCallCount.ContainsKey(binder.Name)) _metholdCallCount[binder.Name]++;
                else _metholdCallCount.Add(binder.Name, 1);

                result = _subject.GetType().GetMethod(binder.Name).Invoke(_subject, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public override string ToString() => $"{_subject.GetType().Name}\n{Info}";
    }
}
