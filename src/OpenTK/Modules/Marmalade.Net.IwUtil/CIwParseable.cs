namespace Marmalade
{
	abstract public class CIwParseable
	{
		public abstract bool ParseAttribute (CIwTextParserITX pParser, string pAttrName);
		public abstract void ParseClose(CIwTextParserITX pParser);
		public abstract void ParseOpen(CIwTextParserITX pParser);
	}
	public class CIwTextParserITX
	{
		
	}
}