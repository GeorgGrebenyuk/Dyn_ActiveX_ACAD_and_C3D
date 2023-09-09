namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLineTable 
	{
		public AeccXLandLib.IAeccLineTable _i;
		internal AeccLineTable(object AeccLineTable_object) 
		{
			this._i = AeccLineTable_object as AeccXLandLib.IAeccLineTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
