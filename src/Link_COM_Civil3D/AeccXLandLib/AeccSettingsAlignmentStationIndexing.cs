namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAlignmentStationIndexing 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAlignmentStationIndexing _i;
		internal AeccSettingsAlignmentStationIndexing(object AeccSettingsAlignmentStationIndexing_object) 
		{
			this._i = AeccSettingsAlignmentStationIndexing_object as Autodesk.AECC.Interop.Land.IAeccSettingsAlignmentStationIndexing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultStationIndexIncrement => this._i.DefaultStationIndexIncrement;
	}
}
