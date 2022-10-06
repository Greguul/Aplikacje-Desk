using System;

namespace PassingParametersToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingParamteters testingParamteters = new TestingParamteters();
            
            testingParamteters.Test2();
            testingParamteters.Test1();
            testingParamteters.Test3();
        }
    }
}
