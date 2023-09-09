namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidVertex 
	{
		public AXDBLib.IAcadSubEntSolidVertex _i;
		internal AcadSubEntSolidVertex(object AcadSubEntSolidVertex_object) 
		{
			this._i = AcadSubEntSolidVertex_object as AXDBLib.IAcadSubEntSolidVertex;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
