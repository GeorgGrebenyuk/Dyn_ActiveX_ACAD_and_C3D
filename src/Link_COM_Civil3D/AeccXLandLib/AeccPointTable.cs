namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointTable 
	{
		public AeccXLandLib.IAeccPointTable _i;
		internal AeccPointTable(object AeccPointTable_object) 
		{
			this._i = AeccPointTable_object as AeccXLandLib.IAeccPointTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
