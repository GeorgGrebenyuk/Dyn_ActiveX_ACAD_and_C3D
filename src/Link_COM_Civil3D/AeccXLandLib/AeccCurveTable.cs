namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCurveTable 
	{
		public AeccXLandLib.IAeccCurveTable _i;
		internal AeccCurveTable(object AeccCurveTable_object) 
		{
			this._i = AeccCurveTable_object as AeccXLandLib.IAeccCurveTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
