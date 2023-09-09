namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMassHaulLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccMassHaulLine _i;
		internal AeccMassHaulLine(object AeccMassHaulLine_object) 
		{
			this._i = AeccMassHaulLine_object as Autodesk.AECC.Interop.Land.IAeccMassHaulLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
