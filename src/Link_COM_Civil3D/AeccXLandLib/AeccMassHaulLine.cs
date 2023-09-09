namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMassHaulLine 
	{
		public AeccXLandLib.IAeccMassHaulLine _i;
		internal AeccMassHaulLine(object AeccMassHaulLine_object) 
		{
			this._i = AeccMassHaulLine_object as AeccXLandLib.IAeccMassHaulLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
