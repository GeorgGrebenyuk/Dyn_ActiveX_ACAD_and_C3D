namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccPointTable _i;
		internal AeccPointTable(object AeccPointTable_object) 
		{
			this._i = AeccPointTable_object as Autodesk.AECC.Interop.Land.IAeccPointTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
