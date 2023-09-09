namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddTotalVolumeTable 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsAddTotalVolumeTable _i;
		internal AeccSettingsAddTotalVolumeTable(object AeccSettingsAddTotalVolumeTable_object) 
		{
			this._i = AeccSettingsAddTotalVolumeTable_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsAddTotalVolumeTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreation => this._i.TableCreation;
	}
}
