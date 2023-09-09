namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentTable 
	{
		public AeccXLandLib.IAeccParcelSegmentTable _i;
		internal AeccParcelSegmentTable(object AeccParcelSegmentTable_object) 
		{
			this._i = AeccParcelSegmentTable_object as AeccXLandLib.IAeccParcelSegmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
