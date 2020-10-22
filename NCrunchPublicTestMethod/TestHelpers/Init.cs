using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCrunchPublicTestMethod
{
    //TODO: If this isn't static then no tests fail
    [TestClass]
    public static class Init
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext _)
        {

        }
    }
}
