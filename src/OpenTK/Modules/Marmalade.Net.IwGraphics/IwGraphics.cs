using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marmalade
{
	public class IwGraphics
	{
		public void Init()
		{
			Iw.ClassRegister(typeof(CIwModel));
			Iw.ClassRegister(typeof(CIwModelBlock));
			Iw.ClassRegister(typeof(CIwModelBuildInfo));
			Iw.ClassRegister(typeof(CIwModelExtPos));
			Iw.ClassRegister(typeof(CIwModelExtSphere));
			Iw.ClassRegister(typeof(CIwModelExtSelSet));
			Iw.ClassRegister(typeof(CIwModelExtSelSetVert));
			Iw.ClassRegister(typeof(CIwModelExtSelSetEdge));
			Iw.ClassRegister(typeof(CIwModelExtSelSetFace));
			Iw.ClassRegister(typeof(CIwModelExt));
			Iw.ClassRegister(typeof(CIwResTemplateGEO));
			Iw.ClassRegister(typeof(CIwResHandlerGEO));
		}
	}
}
