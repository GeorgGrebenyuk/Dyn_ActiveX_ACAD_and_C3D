namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLineTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccLineTable _i;
		internal AeccLineTable(object AeccLineTable_object) 
		{
			this._i = AeccLineTable_object as Autodesk.AECC.Interop.Land.IAeccLineTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
