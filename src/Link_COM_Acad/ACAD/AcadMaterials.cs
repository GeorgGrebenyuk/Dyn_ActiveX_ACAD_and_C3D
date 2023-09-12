using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMaterials 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadMaterials _i;
		internal AcadMaterials(object AcadMaterials_object) 
		{
			this._i = AcadMaterials_object as Autodesk.AutoCAD.Interop.Common.IAcadMaterials;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public AcadMaterial Item(object Index) 
		{
			return new AcadMaterial(this._i.Item(Index));
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		public List<AcadMaterial> GetAll()
		{
			List<AcadMaterial> ms = new List<AcadMaterial>();
			foreach (var item in this._i)
			{
				ms.Add(new AcadMaterial(item));
			}
			return ms;
		}
	}
}
