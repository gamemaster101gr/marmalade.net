namespace Marmalade
{
	public class CIwManaged : CIwParseable
	{
		public virtual string GetClassName()
		{
			return GetType().Name;
		}
		public virtual bool HandleEvent(CIwEvent pEvent)
		{
			return false;
		}
		public override bool  ParseAttribute (CIwTextParserITX pParser, string pAttrName)
		{
			return false;
		}
		public override void ParseClose(CIwTextParserITX pParser) 
		{
		}
		public virtual void ParseCloseChild(CIwTextParserITX pParser, CIwManaged pChild) 
		{
		}
		public override void ParseOpen(CIwTextParserITX pParser) 
		{
		}
		public virtual void  Resolve () 
		{
		}
		public virtual void  Serialise ()
		{
		}
		public virtual void SetName(string pName)
		{
		}

	}
}