namespace Marmalade
{
	public class IwAnim
	{
		public static void Init()
		{
			Iw.ClassRegister(typeof(CIwAnimBone));
			Iw.ClassRegister(typeof(CIwAnim));
			Iw.ClassRegister(typeof(CIwAnimPlayer));
			Iw.ClassRegister(typeof(CIwAnimSkel));
			Iw.ClassRegister(typeof(CIwAnimSkinSet));
			Iw.ClassRegister(typeof(CIwAnimSkin));
			Iw.ClassRegister(typeof(CIwResTemplateANIM));
			Iw.ClassRegister(typeof(CIwResHandlerANIM));
			Iw.ClassRegister(typeof(CIwResTemplateSKEL));
			Iw.ClassRegister(typeof(CIwResHandlerSKEL));
			Iw.ClassRegister(typeof(CIwResTemplateSKIN));
			Iw.ClassRegister(typeof(CIwResHandlerSKIN));
		}
	}
}