namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentTable 
	{
		public AeccXLandLib.IAeccAlignmentTable _i;
		internal AeccAlignmentTable(object AeccAlignmentTable_object) 
		{
			this._i = AeccAlignmentTable_object as AeccXLandLib.IAeccAlignmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
