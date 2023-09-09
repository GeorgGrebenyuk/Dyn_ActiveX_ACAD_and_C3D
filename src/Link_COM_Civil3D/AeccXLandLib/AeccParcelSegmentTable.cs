namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelSegmentTable _i;
		internal AeccParcelSegmentTable(object AeccParcelSegmentTable_object) 
		{
			this._i = AeccParcelSegmentTable_object as Autodesk.AECC.Interop.Land.IAeccParcelSegmentTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
