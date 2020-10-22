using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCrunchPublicTestMethod.Three
{
	public partial class Class3
	{
		[TestClass]

		public class MyTestClass : MyBaseTestClass
		{
			public MyTestClass() : base(new Class3())
			{

			}
		}
	}
}
