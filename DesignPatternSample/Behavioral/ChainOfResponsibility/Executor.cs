using DesignPatternSample.Behavioral.ChainOfResponsibility.MethodChain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Behavioral.ChainOfResponsibility
{
    class Executor
    {
        public Executor()
        {
            new MethodChainDemo();
        }
    }
}
