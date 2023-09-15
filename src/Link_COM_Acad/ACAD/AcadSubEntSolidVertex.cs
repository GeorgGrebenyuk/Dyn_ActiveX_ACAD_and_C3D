namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidVertex 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubEntSolidVertex _i;
		internal AcadSubEntSolidVertex(object AcadSubEntSolidVertex_object) 
		{
			this._i = AcadSubEntSolidVertex_object as Autodesk.AutoCAD.Interop.Common.AcadSubEntSolidVertex;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
