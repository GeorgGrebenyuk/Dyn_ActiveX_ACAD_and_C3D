namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLegendTable 
	{
		public Autodesk.AECC.Interop.Land.IAeccLegendTable _i;
		internal AeccLegendTable(object AeccLegendTable_object) 
		{
			this._i = AeccLegendTable_object as Autodesk.AECC.Interop.Land.IAeccLegendTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
