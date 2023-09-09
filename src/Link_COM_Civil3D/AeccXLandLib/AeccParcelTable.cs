namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelTable _i;
		internal AeccParcelTable(object AeccParcelTable_object) 
		{
			this._i = AeccParcelTable_object as Autodesk.AECC.Interop.Land.IAeccParcelTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
