using System;
using System.Collections.Generic;
using System.IO;

namespace Marmalade
{
	public class CIwTextParserITX
	{
		private List<CIwManaged> parseStack = new List<CIwManaged>();

		public CIwManaged   GetObject (int level=0)
		{
			return parseStack[parseStack.Count - 1 + level];
		}

		public virtual object  ParseFile (string pPathname, bool allowNonExist=false)
		{
			if (!File.Exists(pPathname))
				return null;
			using (var tr = File.OpenText(pPathname))
			{
				return ParseFile(tr);
			}
		}
		public virtual object ParseFile(System.IO.StreamReader reader)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Read the next string into a buffer and reset the read position, so ReadString will read the same string. 
		/// </summary>
		/// <returns></returns>
		public string PeekString()
		{
			throw new NotImplementedException();
		}
		public CIwManaged PopObject()
		{
			var o = GetObject(0);
			parseStack.RemoveAt(parseStack.Count-1);
			return o;
		}

	}
}