using System.Collections.Generic;

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
		public AcadTextStyle Item(int Index) 
		{
			return new AcadTextStyle(this._i.Item(Index));
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public AcadTextStyle Add(string Name) 
		{
			return new AcadTextStyle(this._i.Add(Name));
		}

		public List<AcadTextStyle> GetAll()
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
