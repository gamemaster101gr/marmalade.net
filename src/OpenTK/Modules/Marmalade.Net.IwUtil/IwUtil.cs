using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marmalade
{
	public class IwUtil
	{
		public static void Init()
		{
			Iw.ClassRegister(typeof(CIwManagedRefCount));
			Iw.ClassRegister(typeof(CIwResource));
		}
		public static void Terminate()
		{

		}
	}
}
