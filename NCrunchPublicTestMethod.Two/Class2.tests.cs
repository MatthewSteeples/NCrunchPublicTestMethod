using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCrunchPublicTestMethod.Two
{
	//TODO: Rename this class (but not the other partial class) to Class4 and a _different_ test fails
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
