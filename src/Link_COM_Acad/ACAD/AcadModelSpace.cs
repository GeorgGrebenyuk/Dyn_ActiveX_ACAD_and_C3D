namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadModelSpace 
	{
		public AXDBLib.IAcadModelSpace _i;
		internal AcadModelSpace(object AcadModelSpace_object) 
		{
			this._i = AcadModelSpace_object as AXDBLib.IAcadModelSpace;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
