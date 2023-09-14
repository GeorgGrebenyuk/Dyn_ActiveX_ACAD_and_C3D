using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadUCSs 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadUCSs _i;
		internal AcadUCSs(object AcadUCSs_object) 
		{
			this._i = AcadUCSs_object as Autodesk.AutoCAD.Interop.Common.AcadUCSs;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private AcadUCS Item(object Index) 
		{
			return new AcadUCS(this._i.Item(Index));
		}
		/// <summary>
		/// Get all ucs
		/// </summary>
		/// <returns></returns>
		public List<AcadUCS> GetAll()
		{
			List<AcadUCS> us = new List<AcadUCS>(0);
			foreach (var u in this._i)
			{
				 us.Add(new AcadUCS(u));
			}
			return us;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		
	}
}
