namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntSolidNode 
	{
		public AXDBLib.IAcadSubEntSolidNode _i;
		internal AcadSubEntSolidNode(object AcadSubEntSolidNode_object) 
		{
			this._i = AcadSubEntSolidNode_object as AXDBLib.IAcadSubEntSolidNode;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
