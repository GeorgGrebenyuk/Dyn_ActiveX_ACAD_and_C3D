namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentTable _i;
		internal AeccAlignmentTable(object AeccAlignmentTable_object) 
		{
			this._i = AeccAlignmentTable_object as Autodesk.AECC.Interop.Land.IAeccAlignmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
