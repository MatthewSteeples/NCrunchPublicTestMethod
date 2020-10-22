using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCrunchPublicTestMethod.Two
{
	public partial class Class2
	{
		[TestClass]

		public class MyTestClass : MyBaseTestClass
		{
			public MyTestClass() : base(getBaseClass())
			{

			}

			private static BaseClass getBaseClass()
			{
				return new Class2();
			}
		}
	}
}
