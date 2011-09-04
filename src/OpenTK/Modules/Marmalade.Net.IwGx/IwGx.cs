namespace Marmalade
{
	public class IwGx
	{
		public void Init()
		{
			Iw.ClassRegister(typeof(_IwGxDebugDataCacheType));
			Iw.ClassRegister(typeof(CIwGxShaderTechnique));
			Iw.ClassRegister(typeof(CIwMaterial));
			Iw.ClassRegister(typeof(CIwResTemplateMTL));
			Iw.ClassRegister(typeof(CIwResHandlerMTL));
			Iw.ClassRegister(typeof(CIwTexture));
		}
	}
}