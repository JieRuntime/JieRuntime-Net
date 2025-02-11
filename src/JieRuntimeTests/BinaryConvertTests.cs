using Microsoft.VisualStudio.TestTools.UnitTesting;
using JieRuntime;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JieRuntime.Tests
{
	[TestClass ()]
	public class BinaryConvertTests
	{
		[TestMethod ()]
		public void ConvertTest ()
		{
			byte[] buf = [0, 0, 1, 2, 3];
			BinaryConvert.ToInt32 (buf, 1, true);
		}
	}
}