namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidNode 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubEntSolidNode _i;
		internal AcadSubEntSolidNode(object AcadSubEntSolidNode_object) 
		{
			this._i = AcadSubEntSolidNode_object as Autodesk.AutoCAD.Interop.Common.AcadSubEntSolidNode;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
