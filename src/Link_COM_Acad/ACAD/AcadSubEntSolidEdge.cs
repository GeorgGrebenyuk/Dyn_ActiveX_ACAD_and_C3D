namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidEdge 
	{
		public AXDBLib.IAcadSubEntSolidEdge _i;
		internal AcadSubEntSolidEdge(object AcadSubEntSolidEdge_object) 
		{
			this._i = AcadSubEntSolidEdge_object as AXDBLib.IAcadSubEntSolidEdge;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
