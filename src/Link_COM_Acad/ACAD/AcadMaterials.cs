using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// The collection of all materials in the drawing
    ///</summary>
    public class AcadMaterials 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadMaterials _i;
		internal AcadMaterials(object AcadMaterials_object) 
		{
			this._i = AcadMaterials_object as Autodesk.AutoCAD.Interop.Common.AcadMaterials;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private AcadMaterial Item(object Index) 
		{
			return new AcadMaterial(this._i.Item(Index));
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		public List<AcadMaterial> GetAcadMaterials()
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
