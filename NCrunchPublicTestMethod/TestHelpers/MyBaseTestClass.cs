using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCrunchPublicTestMethod
{
	public abstract class MyBaseTestClass
	{
		[TestCleanup]
		public void Tidy()
		{

		}

		public MyBaseTestClass(BaseClass instance)
		{

		}

		[TestMethod]
		public virtual void MyTestMethod1()
		{

		}

		[TestMethod]
		public virtual void MyTestMethod2()
		{

		}

		[TestMethod]
		public virtual void MyTestMethod3()
		{

		}

		[TestMethod]
		public virtual void MyTestMethod4()
		{

		}
	}
}
