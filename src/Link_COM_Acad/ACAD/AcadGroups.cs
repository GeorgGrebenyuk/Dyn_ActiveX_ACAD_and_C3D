using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGroups 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadGroups _i;
		internal AcadGroups(object AcadGroups_object) 
		{
			this._i = AcadGroups_object as Autodesk.AutoCAD.Interop.Common.AcadGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///
        ///</summary>
        private AcadGroup Item(object Index) 
		{
			return new AcadGroup(this._i.Item(Index));
		}
		public List<AcadGroup> GetGroups()
		{
			List<AcadGroup> gr = new List<AcadGroup>();
			foreach (var g in this._i)
			{
				gr.Add(new AcadGroup(g));
			}
			return gr;
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

	}
}
