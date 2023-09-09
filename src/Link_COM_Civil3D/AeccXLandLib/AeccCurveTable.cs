namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCurveTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccCurveTable _i;
		internal AeccCurveTable(object AeccCurveTable_object) 
		{
			this._i = AeccCurveTable_object as Autodesk.AECC.Interop.Land.IAeccCurveTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
