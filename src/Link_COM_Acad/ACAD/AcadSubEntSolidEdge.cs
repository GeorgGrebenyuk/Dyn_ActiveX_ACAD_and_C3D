namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidEdge 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubEntSolidEdge _i;
		internal AcadSubEntSolidEdge(object AcadSubEntSolidEdge_object) 
		{
			this._i = AcadSubEntSolidEdge_object as Autodesk.AutoCAD.Interop.Common.AcadSubEntSolidEdge;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
