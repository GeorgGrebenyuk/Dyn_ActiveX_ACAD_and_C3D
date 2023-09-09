namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLegendTable 
	{
		public AeccXLandLib.IAeccLegendTable _i;
		internal AeccLegendTable(object AeccLegendTable_object) 
		{
			this._i = AeccLegendTable_object as AeccXLandLib.IAeccLegendTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
