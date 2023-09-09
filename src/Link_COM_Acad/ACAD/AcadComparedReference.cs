namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadComparedReference 
	{
		public AXDBLib.IAcadComparedReference _i;
		internal AcadComparedReference(object AcadComparedReference_object) 
		{
			this._i = AcadComparedReference_object as AXDBLib.IAcadComparedReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
