using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayouts 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLayouts _i;
		internal AcadLayouts(object AcadLayouts_object) 
		{
			this._i = AcadLayouts_object as Autodesk.AutoCAD.Interop.Common.AcadLayouts;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private AcadLayout Item(object Index) 
		{
			return new AcadLayout(this._i.Item(Index));
		}
		/// <summary>
		/// Get all layouts in drawing
		/// </summary>
		/// <returns></returns>
		public List<AcadLayout> GetLayouts()
		{
			List<AcadLayout> ls = new List<AcadLayout>();
			foreach (var l in this._i)
			{
				ls.Add(new AcadLayout(l));
			}
			return ls;
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;


	}
}
