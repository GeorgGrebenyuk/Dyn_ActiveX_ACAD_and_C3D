using System.Collections.Generic;
using System.Reflection;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadTextStyles 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadTextStyles _i;
		internal AcadTextStyles(object AcadTextStyles_object) 
		{
			this._i = AcadTextStyles_object as Autodesk.AutoCAD.Interop.Common.AcadTextStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}


		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

	

		public List<AcadTextStyle> GetAcadTextStyles()
		{
			List<AcadTextStyle> st = new List<AcadTextStyle>();
			for (int i = 0; i < this._i.Count; i++)
			{
				st.Add(new AcadTextStyle(this._i.Item(i)));
            }
			return st;

        }
	}
}
