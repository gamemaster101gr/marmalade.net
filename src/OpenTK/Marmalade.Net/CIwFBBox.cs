#region Math binding for XNA and OpenTK
#if XNA_MATH
using CIwFVec3=Microsoft.Xna.Framework.Vector3;
#else
using CIwFVec3=OpenTK.Vector3;
#endif
#endregion

namespace Marmalade
{
	public class CIwFBBox
	{
		public CIwFVec3 m_Min;
		public CIwFVec3 m_Max; 
	}
}
