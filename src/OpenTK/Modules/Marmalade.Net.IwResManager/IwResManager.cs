using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marmalade
{
	public static class IwResManager
	{
		static public void Init()
		{
			Iw.ClassRegister(typeof(ResScale));
			Iw.ClassRegister(typeof(CIwResGroupBuildData));
			Iw.ClassRegister(typeof(CIwResList));
			Iw.ClassRegister(typeof(CIwResGroup));
			Iw.ClassRegister(typeof(CIwResTemplate));
			Iw.ClassRegister(typeof(CIwResHandler));
			Iw.ClassRegister(typeof(CIwResTemplateGROUP));
			Iw.ClassRegister(typeof(CIwResHandlerGROUP));
			Iw.ClassRegister(typeof(CIwResTemplateImage));
			Iw.ClassRegister(typeof(CIwResHandlerImage));
			Iw.ClassRegister(typeof(CIwResHandlerITX));
		}

		static public void Terminate()
		{
			
		}
	}
}
