namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelTable 
	{
		public AeccXLandLib.IAeccParcelTable _i;
		internal AeccParcelTable(object AeccParcelTable_object) 
		{
			this._i = AeccParcelTable_object as AeccXLandLib.IAeccParcelTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
